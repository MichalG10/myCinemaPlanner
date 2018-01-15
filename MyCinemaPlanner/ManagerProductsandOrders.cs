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
    public partial class ManagerProductsandOrders : UserControl
    {
        private static ManagerProductsandOrders _instance;

        public static ManagerProductsandOrders Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ManagerProductsandOrders();
                return _instance;
            }
        }

        public ManagerProductsandOrders()
        {
            InitializeComponent();
            var ctx = new myCinemaPlannerDBEntities();

            updateProductsGrid(ctx);
            updateOrderedGrid(ctx);
            updateRealizedGrid(ctx);
        }

        private void updateRealizedGrid(myCinemaPlannerDBEntities ctx)
        {
            realizedGrid.DataSource = ctx.Products_Realized.ToList();
            realizedGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void updateProductsGrid(myCinemaPlannerDBEntities ctx)
        {
            productsGrid.DataSource = ctx.Products_with_OLT.ToList();
            productsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            PKategoriaBox.DataSource = (from p in ctx.Products
                                        select p.Category).Distinct().ToList();
        }

        private void updateOrderedGrid(myCinemaPlannerDBEntities ctx)
        {
            orderedGrid.DataSource = ctx.Products_Ordered.ToList();
            orderedGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void productsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PNazwaBox.Text = productsGrid.CurrentRow.Cells[1].Value.ToString();
            PKategoriaBox.Text = productsGrid.CurrentRow.Cells[5].Value.ToString();
            PLiczbaNumeric.Value = (int)productsGrid.CurrentRow.Cells[3].Value;
            PMinimalnaNumeric.Value = (int)productsGrid.CurrentRow.Cells[4].Value;
            PCenaNumeric.Value = (decimal)productsGrid.CurrentRow.Cells[2].Value;

        }

        private void PAddModifyButton_Click(object sender, EventArgs e)
        {
            using(var ctx = new myCinemaPlannerDBEntities())
            {
                int idtoUse = (int)productsGrid.CurrentRow.Cells[0].Value;
                string name = PNazwaBox.Text;
                try
                {
                    var p = (from product in ctx.Products
                             where product.ProductID == idtoUse 
                             && product.Name == name
                             select product).First();


                }
                catch (DbEntityValidationException ex)
                {
                    var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);
                    var fullErrorMessage = string.Join("; ", errorMessages);
                    MessageBox.Show(fullErrorMessage);
                }
                catch (System.Data.Entity.Core.EntityCommandExecutionException ex)
                {
                    if (ex.InnerException == null) MessageBox.Show("Wyjątek: Wprowadzono nie właściwy typ danych.");
                    else MessageBox.Show("Wyjątek: " + ex.InnerException.Message);
                }
                catch (Exception ex)
                {
                    if (ex.InnerException == null) MessageBox.Show("Wyjątek: Wprowadzono nie właściwy typ danych.");
                    else MessageBox.Show("Wyjątek: " + ex.InnerException.InnerException.Message);
                }
            }
        }
    }
}
