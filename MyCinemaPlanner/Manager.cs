using MongoDB.Bson.Serialization;
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

            // mapuje klasy na struktury jsonowe
            BsonClassMap.RegisterClassMap<Ticket>();
            BsonClassMap.RegisterClassMap<TicketOrder>();

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
                panel.Controls.Remove(Employee_control.Instance);
            //Employee_control.Instance.BringToFront();

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
                panel.Controls.Remove(MovsDistrControl.Instance);
            //MovsDistrControl.Instance.BringToFront();
            
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

        private void employeeVersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffForm f = new StaffForm();
            f.Show();
        }

        private void warehouseAndOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size((int)(ManagerProductsandOrders.Instance.Size.Width * 1.06), (int)(ManagerProductsandOrders.Instance.Size.Height * 1.18));
            panel.Size = new Size(ManagerProductsandOrders.Instance.Size.Width, ManagerProductsandOrders.Instance.Size.Height);

            if (!panel.Controls.Contains(ManagerProductsandOrders.Instance))
            {
                panel.Controls.Add(ManagerProductsandOrders.Instance);
                ManagerProductsandOrders.Instance.Dock = DockStyle.Fill;
                ManagerProductsandOrders.Instance.BringToFront();

            }
            else
                ManagerProductsandOrders.Instance.BringToFront();
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

        private void ticketsManagmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(TicketsManagment.Instance))
            {
                this.Size = new System.Drawing.Size((int)(TicketsManagment.Instance.Size.Width * 1.06), (int)(TicketsManagment.Instance.Size.Height * 1.18));
                panel.Size = new System.Drawing.Size(TicketsManagment.Instance.Size.Width, TicketsManagment.Instance.Size.Height);

                panel.Controls.Add(TicketsManagment.Instance);
                TicketsManagment.Instance.Dock = DockStyle.Fill;
                TicketsManagment.Instance.BringToFront();

            }
            else
                TicketsManagment.Instance.BringToFront();
        }
    }
}
