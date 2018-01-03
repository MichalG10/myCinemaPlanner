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
    }
}
