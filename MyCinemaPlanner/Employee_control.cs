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
    public partial class Employee_control : UserControl
    {
        private int cellRow, cellCol;
        private static Employee_control _instance;

        public static Employee_control Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Employee_control();
                return _instance;
            }
        }

        public Employee_control()
        {
            InitializeComponent();
            cellRow = 0;
            cellCol = 0;
            var ctx = new myCinemaPlannerDBEntities();
            Employees_grid.DataSource = ctx.Employee.ToList();
            Staff_grid.DataSource = ctx.Staff.ToList();
            Technicians_grid.DataSource = ctx.Technicians.ToList();
        }

        private void Staff_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cellRow = Staff_grid.CurrentRow.Index;
            cellCol = Staff_grid.CurrentCell.ColumnIndex;
            String pom = Staff_grid.CurrentRow.Cells[1].Value.ToString();
            int Tech_employeeID = Int32.Parse(pom);
            bool is_in = false;

            foreach (DataGridViewRow row in Employees_grid.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(pom))
                {
                    cellRow = row.Index;
                    is_in = true;
                    break;
                }
            }
            if (is_in == true)
            {
                Employees_grid.ClearSelection();
                Employees_grid.Rows[cellRow].Selected = true;
            }

        }

        private void Employees_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var ctx = new myCinemaPlannerDBEntities())
            {
                cellRow = Employees_grid.CurrentRow.Index;
                cellCol = Employees_grid.CurrentCell.ColumnIndex;
                String pom = Employees_grid.CurrentRow.Cells[0].Value.ToString();
                int EmployeeID = Int32.Parse(pom);
                int x = 0;
                x = (from m in ctx.Staff
                         where m.EmployeeID == EmployeeID
                         select m).Count();
                if (x != 0) {
                    x= (from m in ctx.Staff
                        where m.EmployeeID == EmployeeID
                        select m.StaffID).First();
                    foreach (DataGridViewRow row in Staff_grid.Rows)
                    {
                        if (row.Cells[1].Value.ToString().Equals(pom))
                        {
                            cellRow = row.Index;
                            break;
                        }
                    }
                    Staff_grid.ClearSelection();
                    Staff_grid.Rows[cellRow].Selected = true;
                }
                else if (x == 0)
                {
                    x = (from m in ctx.Technicians
                         where m.EmployeeID == EmployeeID
                         select m).Count();
                    if (x != 0)
                    {
                        x = (from m in ctx.Technicians
                             where m.EmployeeID == EmployeeID
                             select m.TechnicianID).First();
                        foreach (DataGridViewRow row in Technicians_grid.Rows)
                        {
                            if (row.Cells[1].Value.ToString().Equals(pom))
                            {
                                cellRow = row.Index;
                                break;
                            }
                        }
                        Technicians_grid.ClearSelection();
                        Technicians_grid.Rows[cellRow].Selected = true;
                    }
                }
                

            }
        }
    

        private void Technicians_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            cellRow = Technicians_grid.CurrentRow.Index;
            cellCol = Technicians_grid.CurrentCell.ColumnIndex;
            String pom = Technicians_grid.CurrentRow.Cells[1].Value.ToString();
            int Tech_employeeID = Int32.Parse(pom);
            bool is_in = false;
                
            foreach (DataGridViewRow row in Employees_grid.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(pom))
                {
                    cellRow = row.Index;
                    is_in = true;
                    break;
                }
            }
            if (is_in == true)
            {
                Employees_grid.ClearSelection();
                Employees_grid.Rows[cellRow].Selected = true;
            }

            
        }

        
    }
}
