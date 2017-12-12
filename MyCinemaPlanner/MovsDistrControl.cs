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
    public partial class MovsDistrControl : UserControl
    {
        private int cellRowM, cellColM;
        private int cellRowD, cellColD;
        private string lastItem;

        private static MovsDistrControl _instance;

        public static MovsDistrControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MovsDistrControl();
                return _instance;
            }
        }

        public MovsDistrControl()
        {
            InitializeComponent();

            var ctx = new myCinemaPlannerDBEntities();
            cellRowM = 0;
            cellColM = 0;
            cellRowD = 0;
            cellRowM = 0;

            comboBox1.SelectedItem = "Movies";
            dataGrid.DataSource = ctx.Movies.ToList();
            dataGridDist.DataSource = ctx.Distributors.ToList();
            countedDistributionsView.DataSource = ctx.Distributors_counted_movies.ToList();
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridDist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            refreshComboBox(ctx);

            lastItem = comboBox1.Text;
            label1.Text = comboBox1.Text;
            labelGridDist.Text = "Distributors";
            label16.Text = "Distributions";

            updateDistributions(ctx);
        }

        private void updateDistributions(myCinemaPlannerDBEntities ctx)
        {
            var query = (from dis in ctx.Distributions
                         from ds in ctx.Distributors
                         from mv in ctx.Movies
                         where dis.DistributorID == ds.DistributorID
                         where dis.MovieID == mv.MovieID
                         select new { mv.Title, ds.Name, dis.Dubbing, dis.Subtitle, dis.is3D } ).ToList();
            distributionsGridView.DataSource = query;
            distributionsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }


        // Zapisuje pozycje kursora po kliknięciu w komórkę
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cellRowM = dataGrid.CurrentRow.Index;
            cellColM = dataGrid.CurrentCell.ColumnIndex;

            filmidBox.Text = dataGrid.CurrentRow.Cells[0].Value.ToString();
            tytulBox.Text = dataGrid.CurrentRow.Cells[1].Value.ToString();
            rezyserBox.Text = dataGrid.CurrentRow.Cells[2].Value.ToString();
            comboBox2.Text = dataGrid.CurrentRow.Cells[3].Value.ToString();
            ocenaBox.Text = dataGrid.CurrentRow.Cells[5].Value.ToString();
            comboBox3.Text = dataGrid.CurrentRow.Cells[4].Value.ToString();
        }

        private void DistributorsGrid_Click(object sender, DataGridViewCellEventArgs e)
        {
            cellRowD = dataGridDist.CurrentRow.Index;
            cellColD = dataGridDist.CurrentCell.ColumnIndex;

            idDistBox.Text = dataGridDist.CurrentRow.Cells[0].Value.ToString();
            nazwaDistBox.Text = dataGridDist.CurrentRow.Cells[1].Value.ToString();
            emailDistBox.Text = dataGridDist.CurrentRow.Cells[2].Value.ToString();
            telDistBox.Text = dataGridDist.CurrentRow.Cells[3].Value.ToString();
            adresDistBox.Text = dataGridDist.CurrentRow.Cells[4].Value.ToString();
            kodDistBox.Text = dataGridDist.CurrentRow.Cells[5].Value.ToString();
            miastoDistBox.Text = dataGridDist.CurrentRow.Cells[6].Value.ToString();
            krajDistBox.Text = dataGridDist.CurrentRow.Cells[7].Value.ToString();
        }

        // Po naciśnięciu wypisz wszystko z tabelii
        private void ShowAll_Click(object sender, EventArgs e)
        {

            if (lastItem != comboBox1.Text)
            {
                lastItem = comboBox1.Text; cellRowM = 0; cellColM = 0;
            }

            refreshGrid();

            label1.Text = comboBox1.Text;
            label1.Update();

        }

        /* dodaj nowy film do bazy danych */
        private void Dodaj_Click(object sender, EventArgs e)
        {
            using (var ctx = new myCinemaPlannerDBEntities())
            {
                try
                {
                    Movies x = new Movies
                    {
                        Title = tytulBox.Text,
                        Director = rezyserBox.Text,
                        Genre = comboBox2.Text,
                        Rating = decimal.Parse(ocenaBox.Text),
                        Studio = comboBox3.Text
                    };
                    String rec = x.Title + " | " + x.Director + " | " + x.Genre + " | " + x.Rating + " | " + x.Studio;

                    DialogResult dr = MessageBox.Show("Czy napewno chcesz dodać rekord ?\n" + rec, "Potwierdzenie", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        ctx.Movies.Add(x);
                        ctx.SaveChanges();
                    }
                    else
                    {
                        exceptionLabel.Text = "Wiadomość: Nie dodano rekordu.";
                    }

                }
                catch (NullReferenceException ex)
                {
                    exceptionLabel.Text = "Wyjątek: Film nie istnieje w bazie danych.";
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
        /* usuń film z bazy danych */
        private void UsunFilm_Click(object sender, EventArgs e)
        {
            int IdtoDelete = Int32.Parse(filmidBox.Text);
            using (var ctx = new myCinemaPlannerDBEntities())
            {
                try
                {
                    var x = (from m in ctx.Movies
                             where m.MovieID == IdtoDelete
                             select m).FirstOrDefault();
                    String rec = x.Title + " | " + x.Director + " | " + x.Genre + " | " + x.Rating + " | " + x.Studio;

                    DialogResult dr = MessageBox.Show("Czy napewno chcesz usunąć rekord ?\n" + rec, "Potwierdzenie", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        ctx.Movies.Remove(x);
                        ctx.SaveChanges();
                    }
                    else
                    {
                        exceptionLabel.Text = "Wiadomość: Nie usunięto rekordu.";
                    }

                }
                catch (NullReferenceException ex)
                {
                    exceptionLabel.Text = "Wyjątek: Film nie istnieje w bazie danych.";
                }
                catch (Exception ex)
                {
                    exceptionLabel.Text = "Wyjątek: " + ex.InnerException.InnerException.Message;
                }
            }

            refreshGrid();
        }

        /*edytuj film */
        private void EdytujFilm_Click(object sender, EventArgs e)
        {
            int IdtoEdit = Int32.Parse(filmidBox.Text);
            using (var ctx = new myCinemaPlannerDBEntities())
            {
                try
                {
                    var x = (from m in ctx.Movies
                             where m.MovieID == IdtoEdit
                             select m).FirstOrDefault();
                    String rec = x.Title + " | " + x.Director + " | " + x.Genre + " | " + x.Rating + " | " + x.Studio;

                    x.Title = tytulBox.Text;
                    x.Director = rezyserBox.Text;
                    x.Genre = comboBox2.Text;
                    x.Rating = decimal.Parse(ocenaBox.Text);
                    x.Studio = comboBox3.Text;
                    String recafter = x.Title + " | " + x.Director + " | " + x.Genre + " | " + x.Rating + " | " + x.Studio;

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
                    exceptionLabel.Text = "Wyjątek: " + ex.InnerException.InnerException.Message;
                }
            }

            refreshGrid();
        }

        /* dodaj dystrybutora do bazy danych */
        private void DodajDystrybutora_Click(object sender, EventArgs e)
        {
            using (var ctx = new myCinemaPlannerDBEntities())
            {
                try
                {
                    Distributors x = new Distributors
                    {
                        Name = nazwaDistBox.Text,
                        Email = emailDistBox.Text,
                        PhoneNumber = telDistBox.Text,
                        Adress = adresDistBox.Text,
                        ZipCode = kodDistBox.Text,
                        City = miastoDistBox.Text,
                        Country = krajDistBox.Text

                    };
                    String rec = x.Name + " | " + x.Email + " | " + x.PhoneNumber + " | " + x.Adress + " | " + x.ZipCode + " | " + x.City + " | " + x.Country;

                    DialogResult dr = MessageBox.Show("Czy napewno chcesz dodać rekord ?\n" + rec, "Potwierdzenie", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        ctx.Distributors.Add(x);
                        ctx.SaveChanges();
                    }
                    else
                    {
                        exceptionLabel.Text = "Wiadomość: Nie dodano rekordu.";
                    }

                }
                catch (NullReferenceException ex)
                {
                    exceptionLabel.Text = "Wyjątek: Film nie istnieje w bazie danych.";
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

        /* usuń dystrybutora z bazy danych */
        private void UsunDystrybutora_Click(object sender, EventArgs e)
        {
            int IdtoDelete = Int32.Parse(idDistBox.Text);
            using (var ctx = new myCinemaPlannerDBEntities())
            {
                try
                {
                    var x = (from d in ctx.Distributors
                             where d.DistributorID == IdtoDelete
                             select d).FirstOrDefault();
                    String rec = x.Name + " | " + x.Email + " | " + x.PhoneNumber + " | " + x.Adress + " | " + x.ZipCode + " | " + x.City + " | " + x.Country;

                    DialogResult dr = MessageBox.Show("Czy napewno chcesz usunąć rekord ?\n" + rec, "Potwierdzenie", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        ctx.Distributors.Remove(x);
                        ctx.SaveChanges();
                    }
                    else
                    {
                        exceptionLabel.Text = "Wiadomość: Nie usunięto rekordu.";
                    }

                }
                catch (NullReferenceException ex)
                {
                    exceptionLabel.Text = "Wyjątek: Film nie istnieje w bazie danych.";
                }
                catch (Exception ex)
                {
                    exceptionLabel.Text = "Wyjątek: " + ex.InnerException.InnerException.Message;
                }
            }

            refreshGrid();
        }

        /* edytuj dystrybutora */
        private void EdytujDystrybutora_Click(object sender, EventArgs e)
        {
            int IdtoEdit = Int32.Parse(idDistBox.Text);

            using (var ctx = new myCinemaPlannerDBEntities())
            {
                try
                {
                    var x = (from d in ctx.Distributors
                             where d.DistributorID == IdtoEdit
                             select d).FirstOrDefault();
                    String rec = x.Name + " | " + x.Email + " | " + x.PhoneNumber + " | " + x.Adress + " | " + x.ZipCode + " | " + x.City + " | " + x.Country;

                    x.Name = nazwaDistBox.Text;
                    x.Email = emailDistBox.Text;
                    x.PhoneNumber = telDistBox.Text;
                    x.Adress = adresDistBox.Text;
                    x.ZipCode = kodDistBox.Text;
                    x.City = miastoDistBox.Text;
                    x.Country = krajDistBox.Text;
                    String recafter = x.Name + " | " + x.Email + " | " + x.PhoneNumber + " | " + x.Adress + " | " + x.ZipCode + " | " + x.City + " | " + x.Country;

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
                    exceptionLabel.Text = "Wyjątek: " + ex.InnerException.InnerException.Message;
                }
            }

            refreshGrid();
        }

        /* Refresh values in Grid */
        private void refreshGrid()
        {
            var ctx = new myCinemaPlannerDBEntities();

            try
            {
                if (comboBox1.SelectedItem.ToString() == "Employee") dataGrid.DataSource = ctx.Employee.ToList();
                else if (comboBox1.SelectedItem.ToString() == "Staff") dataGrid.DataSource = ctx.Staff.ToList();
                else if (comboBox1.SelectedItem.ToString() == "Technicians") dataGrid.DataSource = ctx.Technicians.ToList();
                else if (comboBox1.SelectedItem.ToString() == "Cleaning") dataGrid.DataSource = ctx.Cleaning.ToList();
                else if (comboBox1.SelectedItem.ToString() == "Sellings") dataGrid.DataSource = ctx.Sellings.ToList();
                else if (comboBox1.SelectedItem.ToString() == "Movies") dataGrid.DataSource = ctx.Movies.ToList();
                else if (comboBox1.SelectedItem.ToString() == "Distributors") dataGrid.DataSource = ctx.Distributors.ToList();
                else if (comboBox1.SelectedItem.ToString() == "Rooms") dataGrid.DataSource = ctx.Rooms.ToList();
                else if (comboBox1.SelectedItem.ToString() == "Cashes") dataGrid.DataSource = ctx.Cashes.ToList();
                else if (comboBox1.SelectedItem.ToString() == "Distributions") dataGrid.DataSource = ctx.Distributions.ToList();
                else if (comboBox1.SelectedItem.ToString() == "Orders") dataGrid.DataSource = ctx.Orders.ToList();
                else if (comboBox1.SelectedItem.ToString() == "Products") dataGrid.DataSource = ctx.Products.ToList();
                else if (comboBox1.SelectedItem.ToString() == "Seance") dataGrid.DataSource = ctx.Seance.ToList();
                else if (comboBox1.SelectedItem.ToString() == "Usage") dataGrid.DataSource = ctx.Usage.ToList();
                dataGridDist.DataSource = ctx.Distributors.ToList();

                updateCursor(cellRowM, cellColM, dataGrid);
                updateCursor(cellRowD, cellColD, dataGridDist);

            }
            catch (ArgumentOutOfRangeException ex)
            {
                cellRowM = 0;
                cellColM = 0;
                cellRowD = 0;
                cellColD = 0;

                updateCursor(cellRowM, cellColM, dataGrid);
                updateCursor(cellRowD, cellColD, dataGridDist);
            }

            refreshComboBox(ctx);
        }

        private void refreshComboBox(myCinemaPlannerDBEntities ctx)
        {

            /* Init Film - Combobox - Gatunek */
            var qGenres = (from m in ctx.Movies
                           orderby m.Genre
                           select m.Genre).Distinct().ToList();
            comboBox2.DataSource = qGenres;

            /* Init Film - Combobox - Studio */
            var qStudios = (from m in ctx.Movies
                            orderby m.Studio
                            select m.Studio).Distinct().ToList();
            comboBox3.DataSource = qStudios;

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