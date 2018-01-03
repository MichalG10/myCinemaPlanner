using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            public Record(string n, int a, decimal p, decimal s)
            {
                Nazwa = n; Liczba = a; Cena = p; Razem = s;
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
            BC_IloscNumeric.Value = 0;

            Record r = new Record(BC_ProduktLabel.Text, (int)BC_IloscNumeric.Value, p, sum);
            orderList.Add(r);
            orderSum += sum;

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

        private void BC_PotwierdzButton_Click(object sender, EventArgs e)
        {

        }
    }
}
