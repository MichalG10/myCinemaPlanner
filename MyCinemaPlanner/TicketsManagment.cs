using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace MyCinemaPlanner
{
    public partial class TicketsManagment : UserControl
    {
        private static TicketsManagment _instance;

        public static TicketsManagment Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TicketsManagment();
                return _instance;
            }
        }

        // link do bazy lokalnej w mongodb
        private string connectionString = "mongodb://localhost:27017";
        private string databaseName = "myCinemaPlannerMDB";

        // mongo db connection
        private MongoClient client;
        private IMongoDatabase db;

        public TicketsManagment()
        {
            InitializeComponent();

            try
            {
                client = new MongoClient(connectionString);
                db = client.GetDatabase(databaseName);
                updateGrid();
                updateComboBox();
                updateTicketGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się połączyć z serwerem.\n Przekroczono czas dostępu do serwera.");
                MessageBox.Show(ex.Message);
            }
        }

        private void updateComboBox()
        {
            // zbierz kolekcje "tickets" z mongodb
            var collect = db.GetCollection<Ticket>("tickets");
            // zbierz wszystki dokumenty
            var ticketCollection = collect.Find(FilterDefinition<Ticket>.Empty).ToList();
            // wybierz tylko kolumne name z dostepnymi rodzajami biletów
            var filtered = ticketCollection.Select(t => t.Name).Distinct().ToList();
            nameBox.DataSource = filtered;
        }

        private void updateTicketGrid()
        {
            // pobieranie kolekcji tickets z mongodb
            var collection = db.GetCollection<Ticket>("tickets");
            // wybranie wszystkich dokumentów z kolekcji
            var documents = collection.Find(FilterDefinition<Ticket>.Empty).ToList();
            ticketsGrid.DataSource = documents;
        }

        private void updateGrid()
        {
            // pobieranie kolekcji tickerOrder z mongodb
            var collection = db.GetCollection<TicketOrder>("tickerOrder");
            // wybranie wszystkich dokumentów z kolekcji
            var documents = collection.Find(FilterDefinition<TicketOrder>.Empty).ToList();
            ticketOrderGrid.DataSource = documents;
        }

        private void odswiezButton_Click(object sender, EventArgs e)
        {
            if (calosciowaCheckBox.Checked)
                updateGrid();
            else
            {
                // pobieranie kolekcji tickerOrder z mongodb
                var collection = db.GetCollection<TicketOrder>("tickerOrder");
                // wybranie wszystkich dokumentów z kolekcji
                var documents = collection.Find(FilterDefinition<TicketOrder>.Empty).ToList();
                // przefiltrowanie w poszukiwaniu tych o wybranej dacie
                var filtered = documents.Where(t => t.Date.Date == sprzedazDateTimePicker.Value.Date).ToList();
                ticketOrderGrid.DataSource = filtered;
            }
        }

        private void mostPopularButton_Click(object sender, EventArgs e)
        {
            // pobieranie kolekcji tickerOrder z mongodb
            var collection = db.GetCollection<TicketOrder>("tickerOrder");
            // wybranie wszystkich dokumentów z kolekcji
            var documents = collection.Find(FilterDefinition<TicketOrder>.Empty).ToList();

            // sprawdz ilosc sprzedanych biletów w danych dniach
            var query = (from p in collection.AsQueryable()
                            where p.Date >= dateOD.Value && p.Date <= dateDO.Value
                            group p by p.seanceId into g
                            orderby g.Count() descending
                            select new { IdSeansu = g.Key, Sprzedane = g.Count() }).ToList();
            ticketOrderGrid.DataSource = query;

        }

        private string constructId()
        {
            string id = "";
            id += nameBox.Text.ToUpper()[0];
            id += typeCheckBox.Checked ? "WEEK" : "WORK";
            id += timeCheckBox.Checked ? "17" : "12";

            return id;
        }

        // dodaj dokument do kolekcji "tickets"
        private void ticketAddButton_Click(object sender, EventArgs e)
        {
            try {
                // pobranie kolekcji "tickets" z bazy danych
                var collection = db.GetCollection<Ticket>("tickets");

                // pobranie wartości z pól interfjesu
                string ticketID = constructId();
                string type = typeCheckBox.Checked ? "weekend" : "workweek";
                string timeofday = timeCheckBox.Checked ? "evening" : "midday";

                // utworzenie nowego obiektu klasy Ticket zmapowanej na strukture JSON
                Ticket t = new Ticket
                {
                    Id = ticketID,
                    Name = nameBox.Text,
                    Type = type,
                    TimeOfDay = timeofday,
                    Price = priceNumeric.Value
                };

                // dodanie obiektu do kolekcji "tickets"
                // wyzwolenie tej funkcji od razu dodaje dokument do bazy, bez dodatkowego potwierdzenia
                collection.InsertOne(t);

                // aktualizacja interfejsu
                updateTicketGrid();
                updateComboBox();
            }
            // przechwytuje wyjątki związane z naruszeniami spójności bazy mongodb
            catch(MongoException mex)
            {
                MessageBox.Show("Wystąpił problem z warunkami dodania dokumentu.\nDokładna treść błędu:\n"
                    + mex.Message);
            }
        }
        
        // zmodyfikuj dokument z kolekcji "tickets"
        private void ticketModifyButton_Click(object sender, EventArgs e)
        {
            string id = ticketsGrid.CurrentRow.Cells[0].Value.ToString();
            string name = nameBox.Text;
            string type = typeCheckBox.Checked ? "weekend" : "workweek";
            string timeofday = timeCheckBox.Checked ? "evening" : "midday";
            decimal price = priceNumeric.Value;

            try {
                // pobranie kolekcji "tickets" z bazy danych
                var collection = db.GetCollection<Ticket>("tickets");
                // pobierz dokładnie jeden dokument
                var filter = Builders<Ticket>.Filter.Eq("_id", id);
                // ustal elementy do modyfikacji
                var update = Builders<Ticket>.Update.Set("name", name).Set("type", type)
                    .Set("timeofday", timeofday).Set("price", price);
                // dodonaj modyfikacji pojedyńczego dokumentu
                collection.UpdateOne(filter, update);

                // aktualizacja interfejsu
                updateTicketGrid();
                updateComboBox();
            }
            catch(MongoException mex)
            {
                MessageBox.Show("Wystąpił błąd podczas aktualizacji.\n Szczegóły błędy:\n" +
                    mex.Message);
            }

        }

        // usuń dokument z kolekcji "tickets"
        private void ticketRemoveButton_Click(object sender, EventArgs e)
        {
            try {
                // pobranie kolekcji "tickets" z bazy danych
                var collection = db.GetCollection<Ticket>("tickets");
                // pobierz potrzebny dokument używając id
                string id = ticketsGrid.CurrentRow.Cells[0].Value.ToString();
                var filter = Builders<Ticket>.Filter.Eq("_id", id);
                // usuń dokument
                collection.DeleteOne(filter);

                // aktualizacja interfejsu
                updateTicketGrid();
                updateComboBox();
            }
            catch (MongoException mex)
            {
                MessageBox.Show("Wystąpił błąd podczas usuwania biletu.\n Szczegóły błędy:\n" +
                    mex.Message);
            }

        }

        private void ticketsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nameBox.Text = ticketsGrid.CurrentRow.Cells[1].Value.ToString();
            if (ticketsGrid.CurrentRow.Cells[2].Value.ToString() == "weekend") typeCheckBox.Checked = true;
            else typeCheckBox.Checked = false;
            if (ticketsGrid.CurrentRow.Cells[3].Value.ToString() == "evening") timeCheckBox.Checked = true;
            else timeCheckBox.Checked = false;
            priceNumeric.Value = decimal.Parse(ticketsGrid.CurrentRow.Cells[4].Value.ToString());
        }
    }
}
