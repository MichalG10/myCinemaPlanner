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
    public partial class DailyView : UserControl
    {
        private static DailyView _instance;

        public static DailyView Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DailyView();
                return _instance;
            }
        }

        public DailyView()
        {
            InitializeComponent();
            var ctx = new myCinemaPlannerDBEntities();

            TimeStartPicker.CustomFormat = "HH:mm";
            TimeStartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            TimeStartPicker.ShowUpDown = true;

            TimeEndPicker.CustomFormat = "HH:mm";
            TimeEndPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            TimeEndPicker.ShowUpDown = true;

            updateMainGrid(ctx);
        }

        // aktualizuj glowna tabele
        private void updateMainGrid(myCinemaPlannerDBEntities ctx)
        {
            if (dailyViewComboBox.Text == "Pracownicy sal")
            {
                var query = (from c in ctx.Cleaning
                             from s in ctx.Staff
                             from e in ctx.Employee
                             where c.StaffID == s.StaffID
                             where s.EmployeeID == e.EmployeeID
                             select new { c.CleaningID, Name = e.FirstName + " " + e.LastName, c.RoomID, c.StartHour, c.EndHour, c.WorkDay });

                dailyViewMainGrid.DataSource = query.ToList();
                DV_SalaKasaBox.DataSource = ctx.Rooms.Select(r => r.RoomID).ToList();
            }
            else if (dailyViewComboBox.Text == "Pracownicy kas")
            {
                dailyViewMainGrid.DataSource = (from c in ctx.Sellings
                                                from s in ctx.Staff
                                                from e in ctx.Employee
                                                where c.StaffID == s.StaffID
                                                where s.EmployeeID == e.EmployeeID
                                                select new { c.SellingID, Name = e.FirstName + " " + e.LastName, c.CashID, c.StartHour, c.EndHour, c.WorkDay }).ToList();

                DV_SalaKasaBox.DataSource = ctx.Cashes.Select(c => c.CashID).ToList();
            }
            DV_PracownicyBox.DataSource = ctx.Employee.Select(e => e.FirstName + " " + e.LastName).ToList();
            dailyViewMainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dailyViewMainGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void PokazButton_Click(object sender, EventArgs e)
        {
            using(var ctx = new myCinemaPlannerDBEntities())
            {
                updateMainGrid(ctx);
            }
        }

        // dodaj wpis
        private void DV_DodajWpisButton_Click(object sender, EventArgs e)
        {
            using(var ctx = new myCinemaPlannerDBEntities())
            {
                DateTime dt = TimeStartPicker.Value;
                DateTime dtend = TimeEndPicker.Value;
                int Staffid = (from em in ctx.Employee
                               from s in ctx.Staff
                               where em.EmployeeID == s.EmployeeID
                               where em.FirstName + " " + em.LastName == DV_PracownicyBox.Text
                               select s.StaffID).FirstOrDefault();
                try
                {
                    if (dailyViewComboBox.Text == "Pracownicy sal")
                    {
                        Cleaning clean = new Cleaning
                        {
                            StaffID = Staffid,
                            RoomID = Int32.Parse(DV_SalaKasaBox.Text),
                            StartHour = new TimeSpan(dt.Hour, dt.Minute, dt.Second),
                            EndHour = new TimeSpan(dtend.Hour, dtend.Minute, dtend.Second),
                            WorkDay = DV_DatePicker.Value
                        };
                        ctx.Cleaning.Add(clean);
                    }
                    else if (dailyViewComboBox.Text == "Pracownicy kas")
                    {
                        Sellings sell = new Sellings
                        {
                            StaffID = Staffid,
                            CashID = Int32.Parse(DV_SalaKasaBox.Text),
                            StartHour = new TimeSpan(dt.Hour, dt.Minute, dt.Second),
                            EndHour = new TimeSpan(dtend.Hour, dtend.Minute, dtend.Second),
                            WorkDay = DV_DatePicker.Value
                        };
                        ctx.Sellings.Add(sell);
                    }
                    ctx.SaveChanges();
                    updateMainGrid(ctx);
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
        // usun wpis
        private void DV_UsunWpisButton_Click(object sender, EventArgs e)
        {
            using(var ctx = new myCinemaPlannerDBEntities())
            {
                int idtodelete = Int32.Parse(dailyViewMainGrid.CurrentRow.Cells[0].Value.ToString());
                try
                {
                    if (dailyViewComboBox.Text == "Pracownicy sal")
                    {
                        var clean = (from c in ctx.Cleaning
                                     where c.CleaningID == idtodelete
                                     select c).FirstOrDefault();
                        ctx.Cleaning.Remove(clean);
                    }
                    else if (dailyViewComboBox.Text == "Pracownicy kas")
                    {
                        var sell = (from s in ctx.Sellings
                                    where s.SellingID == idtodelete
                                    select s).FirstOrDefault();
                        ctx.Sellings.Remove(sell);
                    }

                    ctx.SaveChanges();
                    updateMainGrid(ctx);
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
