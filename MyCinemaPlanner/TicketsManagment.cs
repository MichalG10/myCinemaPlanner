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

            // mapuje klasy na struktury jsonowe
            BsonClassMap.RegisterClassMap<Ticket>();
            BsonClassMap.RegisterClassMap<TicketOrder>();
            try
            {
                client = new MongoClient(connectionString);
                db = client.GetDatabase(databaseName);
                updateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się połączyć z serwerem.\n Przekroczono czas dostępu do serwera.");
                MessageBox.Show(ex.Message);
            }
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
    }
}
