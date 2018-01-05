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

        private void button1_Click(object sender, EventArgs e)
        {
            Products pr1 = null;
            int idtoEdit = int.Parse(PW_MainGrid.CurrentRow.Cells[0].Value.ToString());
            using (var ctx = new myCinemaPlannerDBEntities())
            {
                pr1 = (from p in ctx.Products
                       where p.ProductID == idtoEdit
                       select p).Single();
                pr1.AmountInStock += (int)PW_IloscwmagNumeric.Value;
                ctx.SaveChanges();
            }
        }
    }
}
