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
    public partial class Design : Form
    {
        database sql = new database();
        public Design()
        {
            InitializeComponent();
        }

        private void Design_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.AllDesign();
        }
    }
}
