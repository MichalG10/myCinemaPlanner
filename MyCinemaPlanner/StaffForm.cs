using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCinemaPlanner
{
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private void kasaBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size((int)(BarCash.Instance.Size.Width * 1.06), (int)(BarCash.Instance.Size.Height * 1.18));
            tableLayoutPanel1.RowStyles[2].Height = BarCash.Instance.Size.Height * (float)1.18;
            StaffPanel.Size = new Size(BarCash.Instance.Size.Width, BarCash.Instance.Size.Height);

            if (!StaffPanel.Controls.Contains(BarCash.Instance))
            {
                StaffPanel.Controls.Add(BarCash.Instance);
                BarCash.Instance.Dock = DockStyle.Fill;
                BarCash.Instance.BringToFront();
            }
            else
                BarCash.Instance.BringToFront();
        }

        private void StaffForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void magazynToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size((int)(ProductWarehouse.Instance.Size.Width * 1.06), (int)(ProductWarehouse.Instance.Size.Height * 1.18));
            tableLayoutPanel1.RowStyles[2].Height = ProductWarehouse.Instance.Size.Height*(float)1.18;
            StaffPanel.Size = new Size(ProductWarehouse.Instance.Size.Width, ProductWarehouse.Instance.Size.Height);

            if (!StaffPanel.Controls.Contains(ProductWarehouse.Instance))
            {
                StaffPanel.Controls.Add(ProductWarehouse.Instance);
                ProductWarehouse.Instance.Dock = DockStyle.Fill;
                ProductWarehouse.Instance.BringToFront();
            }
            else
                ProductWarehouse.Instance.BringToFront();
        }
    }
}
