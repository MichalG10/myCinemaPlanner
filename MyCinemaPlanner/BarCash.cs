using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Validation;

namespace MyCinemaPlanner
{
    public partial class BarCash : UserControl
    {
        public class Record
        {
            public string Nazwa { get; set; }
            public int Liczba { get; set; }
            public decimal Cena { get; set; }
            public decimal Razem { get; set; }
            public decimal Znizka { get; set; }

            public Record(string n, int a, decimal p, decimal s, decimal z)
            {
                Nazwa = n; Liczba = a; Cena = p; Razem = s; Znizka = z;
            }
        }
        private decimal orderSum;
        private List<Record> orderList;

        private static BarCash _instance;

        public static BarCash Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BarCash();
                return _instance;
            }
        }

        public BarCash()
        {
            InitializeComponent();
            var ctx = new myCinemaPlannerDBEntities();
            orderList = new List<Record>();
            orderSum = 0;

            BC_CashBox.DataSource = (from c in ctx.Cashes
                                     where c.Bar == true
                                     select c.CashID).ToList();
            updateGrid(ctx);
        }

        private void updateGrid(myCinemaPlannerDBEntities ctx)
        {
            BC_GridView.DataSource = (from p in ctx.Products
                                      select new { p.ProductID, Nazwa = p.Name, Cena = p.UnitPrice,  LiczbawMagazynie = p.AmountInStock, Kategoria = p.Category}).ToList();

            BC_GridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void BC_GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BC_ProduktLabel.Text = BC_GridView.CurrentRow.Cells[1].Value.ToString();
        }

        private void BC_DodajZamowienieButton_Click(object sender, EventArgs e)
        {
            decimal p = decimal.Parse(BC_GridView.CurrentRow.Cells[2].Value.ToString());
            decimal sum = p * (int)BC_IloscNumeric.Value;
            decimal disc = BC_ZnizkaNumeric.Value * (decimal)0.01;

            Record r = new Record(BC_ProduktLabel.Text, (int)BC_IloscNumeric.Value, p, sum, disc);
            orderList.Add(r);
            orderSum += (sum*(1-disc));

            BC_IloscNumeric.Value = 0;
            BC_ZnizkaNumeric.Value = 0;
            updateZamowienia();
        }

        private void updateZamowienia()
        {
            var source = new BindingSource();
            source.DataSource = orderList;
            BC_ZamowieniaGrid.DataSource = source;
            BC_RazemLabel.Text = "Razem do zapłaty:        " + orderSum.ToString("###.##") + "zł";
        }

        private void BC_AnulujButton_Click(object sender, EventArgs e)
        {
            orderSum = 0;
            orderList.Clear();

            updateZamowienia();
        }

        // Działanie przycisku Potwierdz zamówienie - Transakcja
        private void BC_PotwierdzButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new myCinemaPlannerDBEntities())
            {
                // Stworzenie obiektu przechowującego informację o rozpoczęciu transakcji - dbTran
                // dzięki niemu będzie możliwy ewentualny rollback w przypadku niepowodzenia
                using (System.Data.Entity.DbContextTransaction dbTran = ctx.Database.BeginTransaction())
                {
                    try
                    {
                        // Każdy element zamówienia z pomocniczej struktury orderList
                        // zostaje zamieniony na rekord tabeli Usage przechowującej
                        // informację o każdym wykorzystaniu produktu z magazynu
                        foreach (Record rec in orderList)
                        {
                            int id = (from p in ctx.Products
                                      where p.Name == rec.Nazwa
                                      select p.ProductID).FirstOrDefault();

                            Usage usa = new Usage
                            {
                                ProductID = id,
                                CashID = int.Parse(BC_CashBox.Text),
                                Amount = rec.Liczba,
                                WorkDay = DateTime.Now
                            };

                            // Dodanie elementu do tabeli Usage wywołuje trigger
                            ctx.Usage.Add(usa);

                            // Zostaje również zmiejszona liczba elementów w magazynie
                            Products prod = (from pr in ctx.Products
                                             where pr.ProductID == id
                                             select pr).FirstOrDefault();
                            prod.AmountInStock -= rec.Liczba;
                            ctx.Entry(prod).State = System.Data.Entity.EntityState.Modified;
                        }

                        // Zmiany zostają zapisane dopiero po dodaniu wszystkich elementów
                        ctx.SaveChanges();
                        // Jeśli zmiany zostały zapisane bez problemów można potwierdzić otwartą transakcję
                        dbTran.Commit();
                        MessageBox.Show("Transakcja przeprowadzona pomyślnie.");

                        updateGrid(ctx);
                    }
                    // Wyjątki wywoływane przez triggery, bądź CHECK
                    catch (System.Data.Entity.Core.EntityCommandExecutionException ex)
                    {
                        if (ex.InnerException == null) MessageBox.Show("Wyjątek: Wprowadzono nie właściwy typ danych.");
                        else MessageBox.Show("Wyjątek: " + ex.InnerException.Message + "\n======================\nTransakcja przerwana.");
                        // W przypadku błędu wszystkie zmiany są cofane, a baza pozostaje w stane sprzed rozpoczęcia transakcji.
                        dbTran.Rollback();
                    }
                    catch (Exception ex)
                    {
                        if (ex.InnerException == null) MessageBox.Show("Wyjątek: Wprowadzono nie właściwy typ danych.");
                        else MessageBox.Show("Wyjątek: " + ex.InnerException.InnerException.Message + "\n======================\nTransakcja przerwana.");
                        // W przypadku błędu wszystkie zmiany są cofane, a baza pozostaje w stane sprzed rozpoczęcia transakcji.
                        dbTran.Rollback();
                    }

                    BC_AnulujButton_Click(null, null);
                }
            }
        }
    }
}
