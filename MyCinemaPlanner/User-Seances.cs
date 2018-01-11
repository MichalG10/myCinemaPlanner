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
    public partial class User_Seances : UserControl
    {
        private int cellRow, cellCol;
        private static User_Seances _instance;

        public static User_Seances Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new User_Seances();
                return _instance;
            }
        }

        public User_Seances()
        {
            InitializeComponent();
            cellRow = 0;
            cellCol = 0;
            var ctx = new myCinemaPlannerDBEntities();
            Seances_grid.DataSource = ctx.Seance.ToList();

            StartTimedateTimePicker.CustomFormat = "HH:mm:ss";
            StartTimedateTimePicker.Format = DateTimePickerFormat.Time;
            StartTimedateTimePicker.ShowUpDown = true;
            string d = (StartTimedateTimePicker.Value.ToString());
            DateTime s=DateTime.ParseExact(d, "yyyy-MM-dd HH:mm:ss", null);
            EndTimetextBox.Text = s.ToLongTimeString() ;
            refreshRoomIDBox(ctx);
            refreshTechnicianBox(ctx);
            refreshDistributionIDBox(ctx);
        }

        private void DistributionIDcomboBox_DropDown(object sender, EventArgs e)
        {
            var ctx = new myCinemaPlannerDBEntities();
            refreshDistributionIDBox(ctx);
        }

        private void DistributionIDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ctx = new myCinemaPlannerDBEntities();
            refreshDistributionDetails(ctx);
        }

        private void refreshDistributionIDBox(myCinemaPlannerDBEntities ctx)
        {
            /* Init DistributionsID - Combobox */
            var qDistributionID = (from m in ctx.Distributions
                              select m.DistributionID).ToList();
            List<String> Dist = new List<String>();
            foreach (int el in qDistributionID)
            {
                string im=el.ToString() ;
                Dist.Add(im);
            }
            DistributionIDcomboBox.DataSource = Dist;
        }

        private void StartTimedateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var ctx = new myCinemaPlannerDBEntities();
            TimeSpan mov;
           //////////////////TRY 
            if (DistributionIDcomboBox.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Nie wybrano  ID dystrybucji");
                return;
            }
            int ID = Int32.Parse(DistributionIDcomboBox.SelectedItem.ToString());
            var x = (from m in ctx.Distributions
                        where m.DistributionID == ID
                        select m).FirstOrDefault();

            var y = (from m in ctx.Movies
                        where m.MovieID == x.MovieID
                        select m).FirstOrDefault();
            mov = TimeSpan.Parse(y.Duration.ToString());

            string d = (StartTimedateTimePicker.Value.ToString());
            DateTime s = DateTime.ParseExact(d, "yyyy-MM-dd HH:mm:ss", null);
            d= s.ToLongTimeString();
            TimeSpan t = TimeSpan.Parse(d);
            t = t + TimeSpan.Parse("00:30:00")+mov;
            EndTimetextBox.Text = t.ToString();
        }

        private void RoomIDcomboBox_DropDown(object sender, EventArgs e)
        {
            var ctx = new myCinemaPlannerDBEntities();
            refreshRoomIDBox(ctx);
        }

        private void refreshRoomIDBox(myCinemaPlannerDBEntities ctx)
        {
            /* Init DistributionsID - Combobox */
            var qRoomID = (from m in ctx.Rooms
                           select m.RoomID).ToList();
            List<String> Roo = new List<String>();
            foreach (int el in qRoomID)
            {
                string im = el.ToString();
                Roo.Add(im);
            }
            RoomIDcomboBox.DataSource = qRoomID;
        }

        private void TechniciancomboBox_DropDown(object sender, EventArgs e)
        {
            var ctx = new myCinemaPlannerDBEntities();
            refreshTechnicianBox(ctx);
        }

        private void refreshTechnicianBox(myCinemaPlannerDBEntities ctx)
        {
            var x = (from m in ctx.Technicians
                           select m.EmployeeID).ToList();

            List<String> Tech = new List<String>();
            foreach(int el in x)
            {
                var y = (from m in ctx.Employee
                         where m.EmployeeID == el
                         select m).FirstOrDefault();
                var z = (from m in ctx.Technicians
                         where m.EmployeeID == el
                         select m).FirstOrDefault();
                string im = z.TechnicianID +" "+y.FirstName + " " + y.LastName;
                Tech.Add(im);
            }
            TechniciancomboBox.DataSource = Tech;
        }

        private void Seances_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var ctx = new myCinemaPlannerDBEntities();
            cellRow = Seances_grid.CurrentRow.Index;
            cellCol = Seances_grid.CurrentCell.ColumnIndex;

            DistributionIDcomboBox.SelectedIndex = DistributionIDcomboBox.FindStringExact(Seances_grid.CurrentRow.Cells[1].Value.ToString());
            refreshDistributionDetails(ctx);
            
            DateTime dat = DateTime.Parse(Seances_grid.CurrentRow.Cells[4].Value.ToString()).Date;
            dateTimePicker.Value = dat;
            string da = dat.ToLongDateString();

            string f = Seances_grid.CurrentRow.Cells[5].Value.ToString();
            da = da + " " + f;
            DateTime s = DateTime.Parse(da);
            StartTimedateTimePicker.Value = s;
            
            EndTimetextBox.Text = Seances_grid.CurrentRow.Cells[6].Value.ToString();

            RoomIDcomboBox.SelectedIndex = RoomIDcomboBox.FindStringExact(Seances_grid.CurrentRow.Cells[2].Value.ToString());
            int idtech = Int32.Parse(Seances_grid.CurrentRow.Cells[3].Value.ToString());
            var x = (from m in ctx.Technicians
                     where m.TechnicianID == idtech
                     select m).FirstOrDefault();
            var y = (from m in ctx.Employee
                     where m.EmployeeID == x.EmployeeID
                     select m).FirstOrDefault();
            string imie_naz = x.TechnicianID + " "+ y.FirstName + " " + y.LastName;
            TechniciancomboBox.SelectedIndex = TechniciancomboBox.FindStringExact(imie_naz);
           
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            using (var ctx = new myCinemaPlannerDBEntities())
            {
                try
                {
                    string imie_naz = TechniciancomboBox.SelectedItem.ToString();
                    String[] substrings = imie_naz.Split(' ');
                    
                    Seance x = new Seance
                    {
                        DistributionID = Int32.Parse(DistributionIDcomboBox.SelectedItem.ToString()),
                        RoomID= Int32.Parse(RoomIDcomboBox.SelectedItem.ToString()),
                        TechnicianID=Int32.Parse(substrings[0]),
                        ShowDate= DateTime.ParseExact(dateTimePicker.Value.ToShortDateString(), "yyyy-MM-dd", null),
                        EndTime = TimeSpan.Parse(EndTimetextBox.Text),
                        StartTime =TimeSpan.Parse(StartTimedateTimePicker.Value.ToLongTimeString())
                        
                    };
                    /*if (PositioncomboBox.SelectedItem.ToString() == null)
                    {
                        MessageBox.Show("Nie wybrano stanowiska pracownika");
                        return;
                    }*/
                    //string position = PositioncomboBox.SelectedItem.ToString();
                    String rec = x.DistributionID + " | " + x.RoomID + " | " + x.TechnicianID + " | " + x.ShowDate + " | " + x.StartTime + " | " + x.EndTime;

                    DialogResult dr = MessageBox.Show("Czy napewno chcesz dodać rekord ?\n" + rec, "Potwierdzenie", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        ctx.Seance.Add(x);
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

        private void Modifybutton_Click(object sender, EventArgs e)
        {
            int IdtoModify = Int32.Parse(Seances_grid.CurrentRow.Cells[0].Value.ToString());
            using (var ctx = new myCinemaPlannerDBEntities())
            {
                try
                {
                    string imie_naz = TechniciancomboBox.SelectedItem.ToString();
                    String[] substrings = imie_naz.Split(' ');
                    var x = (from m in ctx.Seance
                             where m.SeanceID == IdtoModify
                             select m).FirstOrDefault();
                    String rec = x.DistributionID + " | " + x.RoomID + " | " + x.TechnicianID + " | " + x.ShowDate + " | " + x.StartTime + " | " + x.EndTime;

                    x.DistributionID = Int32.Parse(DistributionIDcomboBox.SelectedItem.ToString());
                    x.RoomID = Int32.Parse(RoomIDcomboBox.SelectedItem.ToString());
                    x.TechnicianID = Int32.Parse(substrings[0]);
                    x.ShowDate = DateTime.ParseExact(dateTimePicker.Value.ToShortDateString(), "yyyy-MM-dd", null);
                    x.EndTime = TimeSpan.Parse(EndTimetextBox.Text);
                    x.StartTime = TimeSpan.Parse(StartTimedateTimePicker.Value.ToLongTimeString());
                    String recafter = x.DistributionID + " | " + x.RoomID + " | " + x.TechnicianID + " | " + x.ShowDate + " | " + x.StartTime + " | " + x.EndTime;

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
                    exceptionLabel.Text = "Wyjątek: Film nie istnieje w bazie danych.";
                }
                catch (Exception ex)
                {
                    if (ex.InnerException == null) MessageBox.Show("Wyjątek: Wprowadzono nie właściwy typ danych.");
                    else MessageBox.Show("Wyjątek: " + ex.InnerException.InnerException.Message);
                }
            }

            refreshGrid();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            int IdtoDelete = Int32.Parse(Seances_grid.Rows[cellRow].Cells[0].Value.ToString());
            using (var ctx = new myCinemaPlannerDBEntities())
            {
                try
                {
                    var x = (from m in ctx.Seance
                             where m.SeanceID == IdtoDelete
                             select m).FirstOrDefault();

                    String rec = x.DistributionID + " | " + x.RoomID + " | " + x.TechnicianID + " | " + x.ShowDate + " | " + x.StartTime + " | " + x.EndTime;
                    DialogResult dr = MessageBox.Show("Czy napewno chcesz usunąć rekord ?\n" + rec, "Potwierdzenie", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    { 
                        ctx.Seance.Remove(x);
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

        private void refreshDistributionDetails(myCinemaPlannerDBEntities ctx)
        {
            ///////////Try
            if (DistributionIDcomboBox.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Nie wybrano  ID dystrybucji");
                return;
            }
            int ID = Int32.Parse(DistributionIDcomboBox.SelectedItem.ToString());
            var x = (from m in ctx.Distributions
                     where m.DistributionID == ID
                     select m).FirstOrDefault();

            var y = (from m in ctx.Movies
                     where m.MovieID == x.MovieID
                     select m).FirstOrDefault();
            DistributionDetailstextBox.Text = (y.Title + " - " + x.Dubbing + " - " + x.Subtitle + " - "+ x.is3D );
        }

        private void refreshGrid()
        {
            var ctx = new myCinemaPlannerDBEntities();
            try
            {
                Seances_grid.DataSource = ctx.Seance.ToList();
                //updateDistributions(ctx);

                /* uaktualnia pozycje kursora, uodparnia przed "skakaniem" kursora do pierwszej pozycji */
                updateCursor(cellRow, cellCol, Seances_grid);
                
                /* jeśli w wyniku operacji usuwania kursor będzie wskazywał nieistniejącą komórkę */
            }
            catch (ArgumentOutOfRangeException ex)
            {
                cellRow = 0; cellCol = 0;

                updateCursor(cellRow, cellCol, Seances_grid);
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
