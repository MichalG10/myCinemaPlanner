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
    public partial class Manager_Welcome : UserControl
    {
        private static Manager_Welcome _instance;

        public static Manager_Welcome Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Manager_Welcome();
                return _instance;
            }
        }
        public Manager_Welcome()
        {
            InitializeComponent();
        }
    }
}
