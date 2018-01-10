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
            this.Size = new System.Drawing.Size((int)(Manager_Welcome.Instance.Size.Width * 1.06), (int)(Manager_Welcome.Instance.Size.Height * 1.18));
            panel.Size = new System.Drawing.Size(Manager_Welcome.Instance.Size.Width, Manager_Welcome.Instance.Size.Height); ;
            panel.Controls.Add(Manager_Welcome.Instance);
            Manager_Welcome.Instance.Dock = DockStyle.Fill;
            Manager_Welcome.Instance.BringToFront();
        }

       

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(Employee_control.Instance))
            {
                this.Size = new System.Drawing.Size((int)(Employee_control.Instance.Size.Width * 1.06), (int)(Employee_control.Instance.Size.Height * 1.18));
                panel.Size = new System.Drawing.Size(Employee_control.Instance.Size.Width, Employee_control.Instance.Size.Height); ;

                panel.Controls.Add(Employee_control.Instance);
                Employee_control.Instance.Dock = DockStyle.Fill;
                Employee_control.Instance.BringToFront();
            }
            else
                Employee_control.Instance.BringToFront();
        }

        private void moviesAnDistributionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(MovsDistrControl.Instance))
            {
                this.Size = new System.Drawing.Size((int)(MovsDistrControl.Instance.Size.Width * 1.06), (int)(MovsDistrControl.Instance.Size.Height * 1.18));
                panel.Size = new System.Drawing.Size(MovsDistrControl.Instance.Size.Width, MovsDistrControl.Instance.Size.Height); ;

                panel.Controls.Add(MovsDistrControl.Instance);
                MovsDistrControl.Instance.Dock = DockStyle.Fill;
                MovsDistrControl.Instance.BringToFront();

            }
            else
                MovsDistrControl.Instance.BringToFront();
        }

        private void seancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(User_Seances.Instance))
            {
                this.Size = new System.Drawing.Size((int)(User_Seances.Instance.Size.Width * 1.06), (int)(User_Seances.Instance.Size.Height * 1.18));
                panel.Size = new System.Drawing.Size(User_Seances.Instance.Size.Width, User_Seances.Instance.Size.Height); ;

                panel.Controls.Add(User_Seances.Instance);
                User_Seances.Instance.Dock = DockStyle.Fill;
                User_Seances.Instance.BringToFront();

            }
            else
                User_Seances.Instance.BringToFront();
        }

        private void repertoirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(Repertoire.Instance))
            {
                this.Size = new System.Drawing.Size((int)(Repertoire.Instance.Size.Width * 1.06), (int)(Repertoire.Instance.Size.Height * 1.18));
                panel.Size = new System.Drawing.Size(Repertoire.Instance.Size.Width, Repertoire.Instance.Size.Height); ;

                panel.Controls.Add(Repertoire.Instance);
                Repertoire.Instance.Dock = DockStyle.Fill;
                Repertoire.Instance.BringToFront();

            }
            else
                Repertoire.Instance.BringToFront();
        }
    
    }
}
