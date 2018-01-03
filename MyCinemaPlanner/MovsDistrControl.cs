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
    public partial class MovsDistrControl : UserControl
    {
        private int cellRowM, cellColM;
        private int cellRowD, cellColD;
        private int cellRowDis, cellColDis;
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
            cellColM = 0;
            cellRowDis = 0;
            cellColDis = 0;

            /* inicjalizacja tabel */
            dataGrid.DataSource = ctx.Movies.ToList(); // tabela - Filmy
            dataGridDist.DataSource = ctx.Distributors.ToList(); // tabela - Dystrybutorzy
            countedDistributionsView.DataSource = ctx.Distributors_counted_movies.ToList(); // widok - Dystrybutorzy - Liczba filmów

            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridDist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            refreshComboBox(ctx);
            label1.Text = "Filmy";
            labelGridDist.Text = "Dystrybutorzy";
            label16.Text = "Dystrybucje";
            textBox1.Hide();

            updateDistributions(ctx);
        }

        // aktualizacja widoku w dataGrid - Dystrybucje
        private void updateDistributions(myCinemaPlannerDBEntities ctx)
        {
            var query = (from dis in ctx.Distributions
                         from ds in ctx.Distributors
                         from mv in ctx.Movies
                         where dis.DistributorID == ds.DistributorID
                         where dis.MovieID == mv.MovieID
                         select new { dis.DistributionID, mv.Title, ds.Name, dis.Dubbing, dis.Subtitle, dis.is3D } ).ToList();

            distributionsGridView.DataSource = query;
            distributionsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        // Zapisuje pozycje kursora po kliknieciu w komórkę - dataGrid - Movies
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
        // Zapisuje pozycje kursora - dataGrid - Dystrybutorzy
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
        // Zapisuje pozycje kursora - dataGrid - Dystrybucje
        private void distributionsGridView_Click(object sender, DataGridViewCellEventArgs e)
        {
            cellRowDis = dataGridDist.CurrentRow.Index;
            cellColDis = dataGridDist.CurrentCell.ColumnIndex;

            textBox1.Text = distributionsGridView.CurrentRow.Cells[0].Value.ToString();
            DistibutionMovieBox.Text = distributionsGridView.CurrentRow.Cells[1].Value.ToString();
            distributionDistributorBox.Text = distributionsGridView.CurrentRow.Cells[2].Value.ToString();
            dubbingBox.Text = distributionsGridView.CurrentRow.Cells[3].Value.ToString();
            subtitlesBox.Text = distributionsGridView.CurrentRow.Cells[4].Value.ToString();
            threedimBox.Text = distributionsGridView.CurrentRow.Cells[5].Value.ToString();
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

            refreshGrid();
        }

        /* dodaj dystrybutora do bazy danych */
        private void DodajDystrybutora_Click(object sender, EventArgs e)
        {
            using (var ctx = new myCinemaPlannerDBEntities())
            {
                int retCode = 0;

                try
                {
                    if (procedurecheckbox.Checked) {
                        retCode = ctx.AddDistributor(
                            nazwaDistBox.Text,
                            emailDistBox.Text,
                            telDistBox.Text,
                            adresDistBox.Text,
                            kodDistBox.Text,
                            miastoDistBox.Text,
                            krajDistBox.Text);
                    }
                    else {
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
                    }
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
                    if (ex.InnerException == null) MessageBox.Show("Wyjątek: Wprowadzono nie właściwy typ danych.\nKod błędu - " + retCode);
                    else MessageBox.Show("Wyjątek: " + ex.InnerException.Message + "\nKod błędu - " + retCode);
                }
                catch (Exception ex)
                {
                    if (ex.InnerException == null) MessageBox.Show("Wyjątek: Wprowadzono nie właściwy typ danych.");
                    else MessageBox.Show("Wyjątek: " + ex.InnerException.InnerException.Message);
                }

                refreshGrid();
            }
        }
        /* usuń dystrybutora z bazy danych */
        private void UsunDystrybutora_Click(object sender, EventArgs e)
        {
            int IdtoDelete = Int32.Parse(idDistBox.Text);
            int retCode = 0;
            using (var ctx = new myCinemaPlannerDBEntities())
            {
                try
                {
                    if (procedurecheckbox.Checked)
                    {
                        retCode = ctx.DeleteDistributor(IdtoDelete);
                    }
                    else
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
                    }
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Wyjątek: " + ex.InnerException.Message);
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
                    if (ex.InnerException == null) MessageBox.Show("Wyjątek: Wprowadzono nie właściwy typ danych.\nKod błędu - " + retCode);
                    else MessageBox.Show("Wyjątek: " + ex.InnerException.Message + "\nKod błędu - " + retCode);
                }
                catch (Exception ex)
                {
                    if (ex.InnerException == null) MessageBox.Show("Wyjątek: Wprowadzono nie właściwy typ danych.\nKod błędu - " + retCode);
                    else MessageBox.Show("Wyjątek: " + ex.InnerException.InnerException.Message + "\nKod błędu - " + retCode);
                }

                refreshGrid();
            }
        }
        /* edytuj dystrybutora */
        private void EdytujDystrybutora_Click(object sender, EventArgs e)
        {
            int IdtoEdit = Int32.Parse(idDistBox.Text);
            int retCode = 0;
            using (var ctx = new myCinemaPlannerDBEntities())
            {
                try
                {
                    if (procedurecheckbox.Checked)
                    {
                        retCode = ctx.EditDistributor( IdtoEdit, nazwaDistBox.Text, emailDistBox.Text,
                            telDistBox.Text, adresDistBox.Text, kodDistBox.Text, miastoDistBox.Text, krajDistBox.Text);
                    }
                    else
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
                    }
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Wyjątek: " + ex.InnerException.Message);
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
                    if (ex.InnerException == null) MessageBox.Show("Wyjątek: Wprowadzono nie właściwy typ danych.\nKod błędu - " + retCode);
                    else MessageBox.Show("Wyjątek: " + ex.InnerException.Message + "\nKod błędu - " + retCode);
                }
                catch (Exception ex)
                {
                    if (ex.InnerException == null) MessageBox.Show("Wyjątek: Wprowadzono nie właściwy typ danych.\nKod błędu - " + retCode);
                    else MessageBox.Show("Wyjątek: " + ex.InnerException.InnerException.Message + "\nKod błędu - " + retCode);
                }
            }

            refreshGrid();
        }

        /* dodaj dystrybucje - procedura */
        private void addDistributionButton_Click(object sender, EventArgs e)
        {
            using(var ctx = new myCinemaPlannerDBEntities())
            {
                int retCode = 0;
                bool threedim = false;
                try
                {
                    int distID = (from d in ctx.Distributors
                                where d.Name == distributionDistributorBox.Text
                                select d.DistributorID).FirstOrDefault();
                    int movID = (from m in ctx.Movies
                                 where m.Title == DistibutionMovieBox.Text
                                 select m.MovieID).FirstOrDefault();
                    if (threedimBox.Text == "True") threedim = true;
                    else threedim = false;

                    retCode = ctx.addDistribution(movID, distID, dubbingBox.Text, subtitlesBox.Text, threedim);

                } catch (DbEntityValidationException ex) {
                    var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);
                    var fullErrorMessage = string.Join("; ", errorMessages);
                    MessageBox.Show(fullErrorMessage);
                } catch (System.Data.Entity.Core.EntityCommandExecutionException ex) {
                    if (ex.InnerException == null) MessageBox.Show("Wyjątek: Wprowadzono nie właściwy typ danych.\nKod błędu - " + retCode);
                    else MessageBox.Show("Wyjątek: " + ex.InnerException.Message + "\nKod błędu - " + retCode);
                } catch (Exception ex) {
                    if (ex.InnerException == null) MessageBox.Show("Wyjątek: Wprowadzono nie właściwy typ danych.\nKod błędu - " + retCode);
                    else MessageBox.Show("Wyjątek: " + ex.InnerException.InnerException.Message + "\nKod błędu - " + retCode);
                }

                refreshGrid();
            }
        }
        /* edytuj dystrybucje - procedura */
        private void EditDistributionButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new myCinemaPlannerDBEntities())
            {
                int retCode = 0;
                int IdtoEdit = Int32.Parse(textBox1.Text);
                bool threedim = false;
                try
                {
                    int distID = (from d in ctx.Distributors
                                  where d.Name == distributionDistributorBox.Text
                                  select d.DistributorID).FirstOrDefault();
                    int movID = (from m in ctx.Movies
                                 where m.Title == DistibutionMovieBox.Text
                                 select m.MovieID).FirstOrDefault();
                    if (threedimBox.Text == "True") threedim = true;
                    else threedim = false;

                    retCode = ctx.editDistribution(IdtoEdit, movID, distID, dubbingBox.Text, subtitlesBox.Text, threedim);

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
                    if (ex.InnerException == null) MessageBox.Show("Wyjątek: Wprowadzono nie właściwy typ danych.\nKod błędu - " + retCode);
                    else MessageBox.Show("Wyjątek: " + ex.InnerException.Message + "\nKod błędu - " + retCode);
                }
                catch (Exception ex)
                {
                    if (ex.InnerException == null) MessageBox.Show("Wyjątek: Wprowadzono nie właściwy typ danych.\nKod błędu - " + retCode);
                    else MessageBox.Show("Wyjątek: " + ex.InnerException.InnerException.Message + "\nKod błędu - " + retCode);
                }

                refreshGrid();
            }
        }
        /* usuń dystrybucję - procedura */
        private void deleteDistributionButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new myCinemaPlannerDBEntities())
            {
                int retCode = 0;
                int IdtoEdit = Int32.Parse(textBox1.Text);
                try
                {
                    ctx.deleteDistribution(IdtoEdit);
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
                    if (ex.InnerException == null) MessageBox.Show("Wyjątek: Wprowadzono nie właściwy typ danych.\nKod błędu - " + retCode);
                    else MessageBox.Show("Wyjątek: " + ex.InnerException.Message + "\nKod błędu - " + retCode);
                }
                catch (Exception ex)
                {
                    if (ex.InnerException == null) MessageBox.Show("Wyjątek: Wprowadzono nie właściwy typ danych.\nKod błędu - " + retCode);
                    else MessageBox.Show("Wyjątek: " + ex.InnerException.InnerException.Message + "\nKod błędu - " + retCode);
                }

                refreshGrid();
            }
        }

        /* odświeża wartości w dataGridViews */
        private void refreshGrid()
        {
            var ctx = new myCinemaPlannerDBEntities();
            try
            {
                dataGrid.DataSource = ctx.Movies.ToList();
                dataGridDist.DataSource = ctx.Distributors.ToList();
                countedDistributionsView.DataSource = ctx.Distributors_counted_movies.ToList();
                updateDistributions(ctx);

                /* uaktualnia pozycje kursora, uodparnia przed "skakaniem" kursora do pierwszej pozycji */
                updateCursor(cellRowM, cellColM, dataGrid);
                updateCursor(cellRowD, cellColD, dataGridDist);

              /* jeśli w wyniku operacji usuwania kursor będzie wskazywał nieistniejącą komórkę */
            } catch (ArgumentOutOfRangeException ex) {
                cellRowM = 0; cellColM = 0;
                cellRowD = 0; cellColD = 0;
                cellRowDis = 0; cellColDis = 0;

                updateCursor(cellRowM, cellColM, dataGrid);
                updateCursor(cellRowD, cellColD, dataGridDist);
                updateCursor(cellRowDis, cellColDis, dataGridDist);
            }
            /* odświeża wartości w wykorzystywanych ComboBoxach */
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

            /* Init Distributions - Combobox - Film */
            var qDisMovies = (from m in ctx.Movies
                              select m.Title).ToList();
            DistibutionMovieBox.DataSource = qDisMovies;

            /* Init Distributions - Combobox - Studio */
            var qDisStudio = (from m in ctx.Distributors
                              select m.Name).ToList();
            distributionDistributorBox.DataSource = qDisStudio;

            /* Init Distributions - Combobox - Dubbing */
            qDisStudio = (from m in ctx.Distributions
                          select m.Dubbing).Distinct().ToList();
            dubbingBox.DataSource = qDisStudio;

            /* Init Distributions - Combobox - Dubbing */
            qDisStudio = (from m in ctx.Distributions
                          select m.Subtitle).Distinct().ToList();
            subtitlesBox.DataSource = qDisStudio;


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