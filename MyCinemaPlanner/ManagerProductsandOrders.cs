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
        }

        private void updateOrderedGrid(myCinemaPlannerDBEntities ctx)
        {
            orderedGrid.DataSource = ctx.Products_Ordered.ToList();
            orderedGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
