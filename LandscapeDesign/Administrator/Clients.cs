using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandscapeDesign.Administrator
{
    public partial class Clients : Form
    {
        database sql = new database();
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.AllClients();
        }
    }
}
