using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;

namespace MyCinemaPlanner
{
    public partial class TicketCash : UserControl
    {
        private static TicketCash _instance;

        public static TicketCash Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TicketCash();
                return _instance;
            }
        }

        private List<TicketOrder> listofOrdered;
        private decimal orderSum;

        // link do bazy lokalnej w mongodb
        private string connectionString = "mongodb://localhost:27017";
        private string databaseName = "myCinemaPlannerMDB";

        // mongo db connection
        private MongoClient client;
        IMongoDatabase db;

        public TicketCash()
        {
            InitializeComponent();
            listofOrdered = new List<TicketOrder>();
            orderSum = 0;

            try {
                client = new MongoClient(connectionString);
                db = client.GetDatabase(databaseName);
                updateGrid();
                updateComboBox();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nie udało się połączyć z serwerem.\n Przekroczono czas dostępu do serwera.");
                MessageBox.Show(ex.Message);
            }
        }

        private void updateGrid()
        {
            using(var ctx = new myCinemaPlannerDBEntities())
            {
                var distributionCollection = ctx.Distributions.ToList();
                BC_GridView.DataSource = ctx.Distribution_TicketCash.ToList();
                BC_GridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
            categoryBox.DataSource = filtered;
        }

        private void BC_GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BC_ProduktLabel.Text = BC_GridView.CurrentRow.Cells[1].Value.ToString();
        }

        private void dodajBiletButton_Click(object sender, EventArgs e)
        {
            string ticketID = "";
            string nameCH = categoryBox.Text;
            ticketID += nameCH.ToUpper()[0];

            if (weekCheckBox.Checked) ticketID += "WEEK";
            else ticketID += "WORK";

            if (eveningCheckBox.Checked) ticketID += "17";
            else ticketID += "12";

            // zbierz kolekcje "tickets" z mongodb
            var collectTickets = db.GetCollection<Ticket>("tickets");
            // zbierz pojedyńczy dokument o danym id
            var ticketCollection = collectTickets.Find(t => t.Id == ticketID).FirstOrDefault();
            
            // Stwórz nowy obiekt klasy odpowiadającej obiektowi JSON - ticketOrders
            // następnie wypełnij go potrzebnymi informacjami
            TicketOrder to = new TicketOrder {
                seanceId = (int)BC_GridView.CurrentRow.Cells[0].Value,
                Place = (int)placeNumeric.Value,
                Discount = (decimal)discountNumeric.Value,
                ticketsId = ticketID,
                Date = DateTime.Now.Date
            };

            listofOrdered.Add(to);
            orderSum += ticketCollection.Price * (1- (decimal)discountNumeric.Value);

            updateListView();
        }

        private void updateListView()
        {
            var source = new BindingSource();
            source.DataSource = listofOrdered;
            orderedGrid.DataSource = source;
            razemDoZaplaty.Text = "Razem do zapłaty:    " + orderSum.ToString("###.##") + "zł";
        }

        private void anulujTransButton_Click(object sender, EventArgs e)
        {
            orderSum = 0;
            listofOrdered.Clear();

            updateListView();
        }

        private void potwierdzTransButton_Click(object sender, EventArgs e)
        {
            try {
                // Pobierz kolekcje z bazy mongodb - tickerOrders
                var collect = db.GetCollection<TicketOrder>("tickerOrder");

                // Wstaw do kolekcji i jednocześnie bazy mongodb dokumenty
                collect.InsertMany(listofOrdered);

                // Zresetuj GUI
                MessageBox.Show("Transakcja zakończona.");
                anulujTransButton_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Transakcja nieudana.");
            }
        }
    }
}
