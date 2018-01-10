using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace MyCinemaPlanner
{
    public partial class Employee_control : UserControl
    {
        private int cellRow, cellCol;
        private int cellRowS, cellColS;
        private int cellRowT, cellColT;
        //zmienna pomocnicza do określenia czy zaznaczony pracownik jest technikiem czy staffem 0-startowy 1-technician, 2-staff
        private int pos_pom = 0;
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
            cellRowS = 0;
            cellColS = 0;
            cellRowT = 0;
            cellColT = 0;
            var ctx = new myCinemaPlannerDBEntities();
            Employees_grid.DataSource = ctx.Employee.ToList();
            Staff_grid.DataSource = ctx.Staff.ToList();
            Technicians_grid.DataSource = ctx.Technicians.ToList();
        }

        private void Staff_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos_pom = 2;
            cellRowS = Staff_grid.CurrentRow.Index;
            cellColS = Staff_grid.CurrentCell.ColumnIndex;
            String pom = Staff_grid.CurrentRow.Cells[1].Value.ToString();
            int Tech_employeeID = Int32.Parse(pom);
            bool is_in = false;

            perHourNettotextBox.Text = Staff_grid.CurrentRow.Cells[2].Value.ToString();
            perHourBruttotextBox.Text = Staff_grid.CurrentRow.Cells[3].Value.ToString();
            WorkedHourstextBox.Text = Staff_grid.CurrentRow.Cells[4].Value.ToString();
            PaymenttextBox.Text = Staff_grid.CurrentRow.Cells[5].Value.ToString();
            TScomboBox.SelectedIndex = TScomboBox.FindStringExact("Staff");
            SanepidcomboBox.SelectedIndex = SanepidcomboBox.FindStringExact(Staff_grid.CurrentRow.Cells[6].Value.ToString());
            Experience3DcomboBox.SelectedIndex = Experience3DcomboBox.FindStringExact(null);

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

        private void Technicians_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos_pom = 1;
            cellRowT = Technicians_grid.CurrentRow.Index;
            cellColT = Technicians_grid.CurrentCell.ColumnIndex;
            String pom = Technicians_grid.CurrentRow.Cells[1].Value.ToString();
            int Tech_employeeID = Int32.Parse(pom);
            bool is_in = false;

            perHourNettotextBox.Text = Technicians_grid.CurrentRow.Cells[2].Value.ToString();
            perHourBruttotextBox.Text = Technicians_grid.CurrentRow.Cells[3].Value.ToString();
            WorkedHourstextBox.Text = Technicians_grid.CurrentRow.Cells[4].Value.ToString();
            PaymenttextBox.Text = Technicians_grid.CurrentRow.Cells[5].Value.ToString();
            TScomboBox.SelectedIndex = TScomboBox.FindStringExact("Technician");
            Experience3DcomboBox.SelectedIndex = Experience3DcomboBox.FindStringExact(Technicians_grid.CurrentRow.Cells[6].Value.ToString());
            SanepidcomboBox.SelectedIndex = SanepidcomboBox.FindStringExact(null);

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

                FirstNametextBox.Text = Employees_grid.CurrentRow.Cells[1].Value.ToString();
                LastNametextBox.Text = Employees_grid.CurrentRow.Cells[2].Value.ToString();
                PeseltextBox.Text = Employees_grid.CurrentRow.Cells[3].Value.ToString();
                DateTime dat= DateTime.Parse(Employees_grid.CurrentRow.Cells[4].Value.ToString()).Date;
                DateOFBirthtextBox.Text = dat.ToShortDateString();
                AdresstextBox.Text = Employees_grid.CurrentRow.Cells[5].Value.ToString();
                CitytextBox.Text = Employees_grid.CurrentRow.Cells[6].Value.ToString();
                CountrytextBox.Text = Employees_grid.CurrentRow.Cells[7].Value.ToString();


                x = (from m in ctx.Staff
                     where m.EmployeeID == EmployeeID
                     select m).Count();
                if (x != 0)
                {
                    x = (from m in ctx.Staff
                         where m.EmployeeID == EmployeeID
                         select m.StaffID).First();
                    foreach (DataGridViewRow row in Staff_grid.Rows)
                    {
                        if (row.Cells[1].Value.ToString().Equals(pom))
                        {
                            cellRowS = row.Index;
                            pos_pom = 2;
                            break;
                        }
                    }
                    Staff_grid.ClearSelection();
                    Staff_grid.Rows[cellRowS].Selected = true;
                    PositioncomboBox.SelectedIndex = PositioncomboBox.FindStringExact("Staff");
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
                                cellRowT = row.Index;
                                pos_pom = 1;
                                break;
                            }
                        }
                        Technicians_grid.ClearSelection();
                        Technicians_grid.Rows[cellRowT].Selected = true;
                        PositioncomboBox.SelectedIndex = PositioncomboBox.FindStringExact("Technician");
                    }
                }


            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            using (var ctx = new myCinemaPlannerDBEntities())
            {
                try
                {

                    Employee x = new Employee
                    {
                        FirstName = FirstNametextBox.Text,
                        LastName = LastNametextBox.Text,
                        Pesel = PeseltextBox.Text,
                        DateofBirth = DateTime.ParseExact(DateOFBirthtextBox.Text, "yyyy-MM-dd", null),
                        Adress = AdresstextBox.Text,
                        City = CitytextBox.Text,
                        Country = CountrytextBox.Text,

                    };
                    if (PositioncomboBox.SelectedItem.ToString() == null)
                    {
                        MessageBox.Show("Nie wybrano stanowiska pracownika");
                        return;
                    }
                    string position = PositioncomboBox.SelectedItem.ToString();
                    String rec = x.FirstName + " | " + x.LastName + " | " + x.Pesel + " | " + x.DateofBirth + " | " + x.Adress + " | " + x.City + " | " + x.Country + " | " + position;

                    DialogResult dr = MessageBox.Show("Czy napewno chcesz dodać rekord ?\n" + rec, "Potwierdzenie", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        ctx.Employee.Add(x);
                        if (position == "Staff")
                        {
                            Staff s = new Staff { EmployeeID = x.EmployeeID, perHourBrutto = 13.70M, perHourNetto = 10.50M, Sanepid=false  };
                            ctx.Staff.Add(s);
                        }
                        else if (position == "Technician")
                        {
                            Technicians t = new Technicians { EmployeeID = x.EmployeeID, perHourBrutto = 20.70M, perHourNetto = 16.50M, Experience3D=false };
                            ctx.Technicians.Add(t);
                        }
                        ctx.SaveChanges();
                    }
                    else
                    {
                        exceptionLabel.Text = "Wiadomość: Nie dodano rekordu.";
                    }

                }
                catch (NullReferenceException ex)
                {
                    exceptionLabel.Text = "Wyjątek: Nie podano wszystkich danych.";
                }
                catch (FormatException ex)
                {
                    exceptionLabel.Text = "Wyjątek: Wprowadzono nie właściwy typ danych.";
                }
                catch (Exception ex)
                {
                    exceptionLabel.Text = "Wyjątek: " + ex.InnerException.InnerException.Message;
                }
            }
            refreshGrid();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            int IdtoDelete = Int32.Parse(Employees_grid.Rows[cellRow].Cells[0].Value.ToString());
            using (var ctx = new myCinemaPlannerDBEntities())
            {
                try
                {
                    var x = (from m in ctx.Employee
                             where m.EmployeeID == IdtoDelete
                             select m).FirstOrDefault();
                    string position = PositioncomboBox.SelectedItem.ToString();
                    String rec = x.FirstName + " | " + x.LastName + " | " + x.Pesel + " | " + x.DateofBirth + " | " + x.Adress + " | " + x.City + " | " + x.Country + " | " + position;

                    DialogResult dr = MessageBox.Show("Czy napewno chcesz usunąć rekord ?\n" + rec, "Potwierdzenie", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        if (pos_pom == 1)
                        {
                            var t = (from m in ctx.Technicians
                                     where m.EmployeeID == IdtoDelete
                                     select m).FirstOrDefault();
                            ctx.Technicians.Remove(t);
                        }

                        else if (pos_pom == 2)
                        {
                            var s = (from m in ctx.Staff
                                     where m.EmployeeID == IdtoDelete
                                     select m).FirstOrDefault();
                            ctx.Staff.Remove(s);
                        }
                        ctx.Employee.Remove(x);
                        ctx.SaveChanges();
                    }
                    else
                    {
                        exceptionLabel.Text = "Wiadomość: Nie usunięto rekordu.";
                    }

                }
                catch (NullReferenceException ex)
                {
                    exceptionLabel.Text = "Wyjątek: Pracownik nie istnieje w bazie danych.";
                }
                catch (Exception ex)
                {
                    exceptionLabel.Text = "Wyjątek: " + ex.InnerException.InnerException.Message;
                }
            }

            refreshGrid();
        }

        private void TSbutton_Click(object sender, EventArgs e)
        {
            using (var ctx = new myCinemaPlannerDBEntities())
            {
                try
                {
                    if (pos_pom == 1)
                    {
                        int IdtoModify = Int32.Parse(Technicians_grid.CurrentRow.Cells[0].Value.ToString());
                        var x = (from m in ctx.Technicians
                                 where m.TechnicianID == IdtoModify
                                 select m).FirstOrDefault();
                        String rec = x.perHourNetto + " | " + x.perHourBrutto + " | " + x.WorkedHours + " | " + x.Payment + " | " + x.Experience3D + "  from Technician ";

                        x.perHourNetto = Decimal.Parse(perHourNettotextBox.Text);
                        x.perHourBrutto = Decimal.Parse(perHourBruttotextBox.Text);
                        x.WorkedHours = Int32.Parse(WorkedHourstextBox.Text);
                        x.Payment = Decimal.Parse(PaymenttextBox.Text);
                        x.Experience3D = Boolean.Parse(Experience3DcomboBox.Text);

                        String recafter = x.perHourNetto + " | " + x.perHourBrutto + " | " + x.WorkedHours + " | " + x.Payment + " | " + x.Experience3D + "  from Technician";

                        DialogResult dr = MessageBox.Show("Czy napewno chcesz zmienić rekord z\n" + rec + "\nna\n" + recafter + " ?", "Potwierdzenie", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            ctx.SaveChanges();
                        }
                        else
                        {
                            exceptionLabel.Text = "Wiadomość: Nie zmieniono rekordu.";
                        }
                    }
                    else if (pos_pom == 2)
                    {
                        int IdtoModify = Int32.Parse(Staff_grid.CurrentRow.Cells[0].Value.ToString());
                        var x = (from m in ctx.Staff
                                 where m.StaffID == IdtoModify
                                 select m).FirstOrDefault();
                        String rec = x.perHourNetto + " | " + x.perHourBrutto + " | " + x.WorkedHours + " | " + x.Payment + " | " + x.Sanepid + "  from Staff ";

                        x.perHourNetto = Decimal.Parse(perHourNettotextBox.Text);
                        x.perHourBrutto = Decimal.Parse(perHourBruttotextBox.Text);
                        x.WorkedHours = Int32.Parse(WorkedHourstextBox.Text);
                        x.Payment = Decimal.Parse(PaymenttextBox.Text);
                        x.Sanepid = Boolean.Parse(SanepidcomboBox.Text);

                        String recafter = x.perHourNetto + " | " + x.perHourBrutto + " | " + x.WorkedHours + " | " + x.Payment + " | " + x.Sanepid + "  from Staff";

                        DialogResult dr = MessageBox.Show("Czy napewno chcesz zmienić rekord z\n" + rec + "\nna\n" + recafter + " ?", "Potwierdzenie", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            ctx.SaveChanges();
                        }
                        else
                        {
                            exceptionLabel.Text = "Wiadomość: Nie zmieniono rekordu.";
                        }
                    }
                }
                catch (NullReferenceException ex)
                {
                    exceptionLabel.Text = "Wyjątek: Pracownik nie istnieje w bazie danych.";
                }
                catch (Exception ex)
                {
                    if (ex.InnerException == null) MessageBox.Show("Wyjątek: Wprowadzono nie właściwy typ danych.");
                    else MessageBox.Show("Wyjątek: " + ex.InnerException.InnerException.Message);
                }
            }

            refreshGrid();
        }

        private void Modify_button_Click(object sender, EventArgs e)
        {
            int IdtoModify = Int32.Parse(Employees_grid.Rows[cellRow].Cells[0].Value.ToString());
            using (var ctx = new myCinemaPlannerDBEntities())
            {
                try
                {
                    var x = (from m in ctx.Employee
                             where m.EmployeeID == IdtoModify
                             select m).FirstOrDefault();
                    string position = PositioncomboBox.SelectedItem.ToString();
                    String rec = x.FirstName + " | " + x.LastName + " | " + x.Pesel + " | " + x.DateofBirth + " | " + x.Adress + " | " + x.City + " | " + x.Country + " | " + position;

                    x.FirstName = FirstNametextBox.Text;
                    x.LastName = LastNametextBox.Text;
                    x.Pesel = PeseltextBox.Text;
                    x.DateofBirth = DateTime.ParseExact(DateOFBirthtextBox.Text, "yyyy-MM-dd", null);
                    x.Adress = AdresstextBox.Text;
                    x.City = CitytextBox.Text;
                    x.Country = CountrytextBox.Text;

                    String recafter = x.FirstName + " | " + x.LastName + " | " + x.Pesel + " | " + x.DateofBirth + " | " + x.Adress + " | " + x.City + " | " + x.Country + " | " + position;

                    DialogResult dr = MessageBox.Show("Czy napewno chcesz zmienić rekord z\n" + rec + "\nna\n" + recafter + " ?", "Potwierdzenie", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        ctx.SaveChanges();
                    }
                    else
                    {
                        exceptionLabel.Text = "Wiadomość: Nie zmieniono rekordu.";
                    }

                }
                catch (NullReferenceException ex)
                {
                    exceptionLabel.Text = "Wyjątek: Pracownik nie istnieje w bazie danych.";
                }
                catch (Exception ex)
                {
                    if (ex.InnerException == null) MessageBox.Show("Wyjątek: Wprowadzono nie właściwy typ danych.");
                    else MessageBox.Show("Wyjątek: " + ex.InnerException.InnerException.Message);
                }
            }

            refreshGrid();
        }

        

        private void refreshGrid()
        {
            var ctx = new myCinemaPlannerDBEntities();
            try
            {
                Employees_grid.DataSource = ctx.Employee.ToList();
                Technicians_grid.DataSource = ctx.Technicians.ToList();
                Staff_grid.DataSource = ctx.Staff.ToList();
                //updateDistributions(ctx);

                /* uaktualnia pozycje kursora, uodparnia przed "skakaniem" kursora do pierwszej pozycji */
                updateCursor(cellRowS, cellColS, Staff_grid);
                updateCursor(cellRowT, cellColT, Technicians_grid);
                updateCursor(cellRow, cellCol, Employees_grid);
                /* jeśli w wyniku operacji usuwania kursor będzie wskazywał nieistniejącą komórkę */
            }
            catch (ArgumentOutOfRangeException ex)
            {
                cellRow = 0; cellCol = 0;
                cellRowS = 0; cellColS = 0;
                cellRowT = 0; cellColT = 0;

                updateCursor(cellRowS, cellColS, Staff_grid);
                updateCursor(cellRowT, cellColT, Technicians_grid);
                updateCursor(cellRow, cellCol, Employees_grid);
            }
            /* odświeża wartości w wykorzystywanych ComboBoxach */
           // refreshComboBox(ctx);
        }

        private void updateCursor(int row, int coll, DataGridView dataGrid)
        {
            dataGrid.ClearSelection();
            dataGrid.Rows[row].Selected = true;
            dataGrid.FirstDisplayedScrollingRowIndex = row;
            dataGrid.CurrentCell = dataGrid.Rows[row].Cells[coll];
        }
    }
}
