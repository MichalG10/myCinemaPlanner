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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
            this.Size = new Size((int)(Manager_Welcome.Instance.Size.Width * 1.06), (int)(Manager_Welcome.Instance.Size.Height * 1.18));
            panel.Size = new Size(Manager_Welcome.Instance.Size.Width, Manager_Welcome.Instance.Size.Height);

            panel.Controls.Add(Manager_Welcome.Instance);
            Manager_Welcome.Instance.Dock = DockStyle.Fill;
            Manager_Welcome.Instance.BringToFront();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size((int)(Employee_control.Instance.Size.Width * 1.06), (int)(Employee_control.Instance.Size.Height * 1.18));
            panel.Size = new Size(Employee_control.Instance.Size.Width, Employee_control.Instance.Size.Height);

            if (!panel.Controls.Contains(Employee_control.Instance))
            {
                panel.Controls.Add(Employee_control.Instance);
                Employee_control.Instance.Dock = DockStyle.Fill;
                Employee_control.Instance.BringToFront();
            }
            else
                Employee_control.Instance.BringToFront();
        }

        private void moviesAnDistributionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size((int)(MovsDistrControl.Instance.Size.Width * 1.06), (int)(MovsDistrControl.Instance.Size.Height * 1.18));
            panel.Size = new Size(MovsDistrControl.Instance.Size.Width, MovsDistrControl.Instance.Size.Height);

            if (!panel.Controls.Contains(MovsDistrControl.Instance))
            {
                panel.Controls.Add(MovsDistrControl.Instance);
                MovsDistrControl.Instance.Dock = DockStyle.Fill;
                MovsDistrControl.Instance.BringToFront();

            }
            else
                MovsDistrControl.Instance.BringToFront();
        }

        private void dailyViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size((int)(DailyView.Instance.Size.Width * 1.06), (int)(DailyView.Instance.Size.Height * 1.18));
            panel.Size = new Size(DailyView.Instance.Size.Width, DailyView.Instance.Size.Height);

            if (!panel.Controls.Contains(DailyView.Instance))
            {
                panel.Controls.Add(DailyView.Instance);
                DailyView.Instance.Dock = DockStyle.Fill;
                DailyView.Instance.BringToFront();

            }
            else
                DailyView.Instance.BringToFront();
        }


    }
}
