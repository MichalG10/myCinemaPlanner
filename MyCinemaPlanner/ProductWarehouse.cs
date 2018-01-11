using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;

namespace MyCinemaPlanner
{
    public partial class ProductWarehouse : UserControl
    {
        private static ProductWarehouse _instance;

        public static ProductWarehouse Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProductWarehouse();
                return _instance;
            }
        }

        public ProductWarehouse()
        {
            InitializeComponent();
            var ctx = new myCinemaPlannerDBEntities();

            showProducts(ctx);
        }

        private void showProducts(myCinemaPlannerDBEntities ctx)
        {

            PW_MainGrid.DataSource = (from p in ctx.Products
                                        select new
                                        {
                                            p.ProductID,
                                            p.Name,
                                            p.Category,
                                            p.UnitPrice,
                                            p.AmountInStock,
                                            p.MinAmount
                                        }).ToList();

            PW_KategoriaBox.DataSource = ctx.Products.Select(p => p.Category).Distinct().ToList();
            PW_MainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void PW_MainGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PW_ProduktBox.Text = PW_MainGrid.CurrentRow.Cells[1].Value.ToString();
            PW_KategoriaBox.Text = PW_MainGrid.CurrentRow.Cells[2].Value.ToString();
        }

        // Obsługa przycisku - Aktualizuj produkt
        private void button1_Click(object sender, EventArgs e)
        {
            // Deklaracja obiektu - Products
            Products pr1 = null;
            int idtoEdit = int.Parse(PW_MainGrid.CurrentRow.Cells[0].Value.ToString());
            using (var ctx = new myCinemaPlannerDBEntities())
            {
                try
                {
                    // Pobranie odpowiedniego rekordu z bazy danych
                    pr1 = (from p in ctx.Products
                           where p.ProductID == idtoEdit
                           select p).Single();
                    // Aktualizacja stanu magazynowego danego rekordu - UPDATE
                    pr1.AmountInStock += (int)PW_IloscwmagNumeric.Value;
                    pr1.AmountInStock -= (int)PW_IloscdoodrzNumeric.Value;

                    // Oznaczenie rekordu jako zmodyfikowanego - zmiana wartości Rowversion
                    // Sygnał dla innych, że powinien być ruszany dopóki nie zostanie zapisany w bazie
                    ctx.Entry(pr1).State = System.Data.Entity.EntityState.Modified;
                    // Zapisanie zmian - inni mogą działać na danym rekordzie ponownie
                    ctx.SaveChanges();

                    // MessageBox informujący o przeprowadzonej operacji
                    if((int)PW_IloscwmagNumeric.Value > 0) MessageBox.Show(pr1.Name + " - dodano do magazynu - " + PW_IloscwmagNumeric.Value);
                    if ((int)PW_IloscdoodrzNumeric.Value > 0) MessageBox.Show(pr1.Name + " - usunięto z magazynu - " + PW_IloscwmagNumeric.Value);

                    // Aktualizacja interfejsu pracownika
                    PW_IloscwmagNumeric.Value = 0;
                    PW_IloscdoodrzNumeric.Value = 0;
                    showProducts(ctx);
                }
                // Wyjątek współbieżności - pojawia się jeśli podczas próby zapisu pole Rowversion różni się od pobranego wcześniej w rekordzie pr1
                // Innymi słowy w czasie aktualizowania wartości, została ona już zaktualizowana przez kogoś innegoi wymagane jest ponowne jej rozpatrzenie
                catch (DbUpdateConcurrencyException ex)
                {
                    if (ex.InnerException == null) MessageBox.Show("Wyjątek: Parę osób próbuje zmieniać wartość produktu w tym samym czasie." +
                        "\nSpróbuj ponownie za chwilę.");
                    else MessageBox.Show("Wyjątek: " + ex.InnerException.InnerException.Message);

                    showProducts(ctx);
                }
            }
        }
    }
 }
