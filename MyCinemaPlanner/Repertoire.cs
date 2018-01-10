using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyCinemaPlanner
{
    public partial class Repertoire : UserControl
    {
        private static Repertoire _instance;

        public static Repertoire Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Repertoire();
                return _instance;
            }
        }
        public Repertoire()
        {
            InitializeComponent();
            var ctx = new myCinemaPlannerDBEntities();
            var data = DateTime.ParseExact(RepertoiredateTimePicker.Value.ToShortDateString(), "yyyy-MM-dd", null);
            var query = (from s in ctx.Seance
                         from di in ctx.Distributions
                         from m in ctx.Movies
                         from t in ctx.Technicians
                         from em in ctx.Employee
                         where s.ShowDate == data
                         where di.DistributionID == s.DistributionID
                         where di.MovieID == m.MovieID
                         where t.TechnicianID == s.TechnicianID
                         where em.EmployeeID == t.EmployeeID
                         select new { m.Title , s.RoomID, di.Dubbing, di.Subtitle, di.is3D, s.ShowDate, s.StartTime, s.EndTime, em.FirstName, em.LastName }).ToList();
            RepertoiredataGridView.DataSource = query;
        }

        private void RepertoiredateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var ctx = new myCinemaPlannerDBEntities();
            var data = DateTime.ParseExact(RepertoiredateTimePicker.Value.ToShortDateString(), "yyyy-MM-dd", null);
            var query = (from s in ctx.Seance
                         from di in ctx.Distributions
                         from m in ctx.Movies
                         from t in ctx.Technicians
                         from em in ctx.Employee
                         where s.ShowDate == data
                         where di.DistributionID==s.DistributionID
                         where di.MovieID == m.MovieID
                         where t.TechnicianID == s.TechnicianID
                         where em.EmployeeID==t.EmployeeID
                         select new { m.Title, s.RoomID, di.Dubbing ,di.Subtitle, di.is3D,  s.ShowDate, s.StartTime, s.EndTime, em.FirstName, em.LastName }).ToList();
            RepertoiredataGridView.DataSource = query;
        }

        private void Raportbutton_Click(object sender, EventArgs e)
        {
            var ctx = new myCinemaPlannerDBEntities();
            var data = DateTime.ParseExact(RepertoiredateTimePicker.Value.ToShortDateString(), "yyyy-MM-dd", null);
            var query = (from s in ctx.Seance
                         from di in ctx.Distributions
                         from m in ctx.Movies
                         from t in ctx.Technicians
                         from em in ctx.Employee
                         where s.ShowDate == data
                         where di.DistributionID == s.DistributionID
                         where di.MovieID == m.MovieID
                         where t.TechnicianID == s.TechnicianID
                         where em.EmployeeID == t.EmployeeID
                         select new { m.Title, s.RoomID, di.Dubbing, di.Subtitle, di.is3D, s.ShowDate, s.StartTime, s.EndTime, em.FirstName, em.LastName }).ToList();
            RepertoiredataGridView.DataSource = query;
            string dat= data.ToShortDateString();
            string value = String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8}", "Tytuł".PadRight(31), "RoomID".PadRight(8), "Dubbing".PadRight(9), "Subtitle".PadRight(10), "is3D".PadRight(7), "ShowDate".PadRight(12), "StartTime".PadRight(12), "EndTime".PadRight(12), "Technician");
            var pom = "C:'Users'Michal'Documents'GitHub'myCinemaPlanner'MyCinemaPlanner'bin'Debug'Raporty'".Replace("'", "\\");
            pom = pom + dat + ".txt";
            ctx.WriteToFile(pom, value);
            foreach (var z in query)
            {
                String result = String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8}", z.Title.ToString().PadRight(30)+"|", z.RoomID.ToString().PadRight(7) + "|", z.Dubbing.ToString().PadRight(8) + "|", z.Subtitle.ToString().PadRight(9) + "|", z.is3D.ToString().PadRight(5) + " |", dat.PadRight(11) + "|", z.StartTime.ToString().PadRight(11) + "|", z.EndTime.ToString().PadRight(11) + "|", z.FirstName.ToString() + " " + z.LastName.ToString());
                
                ctx.WriteToFile(pom, result);
            }
        }
        }
}
