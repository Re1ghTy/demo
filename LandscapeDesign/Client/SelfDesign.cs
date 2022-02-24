using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandscapeDesign.Client
{
    public partial class SelfDesign : Form
    {
        Acc account = new Acc();
        List<string> size = new List<string>() { "До 100 км2", "До 1000 км2", "До 10000 км2" };
        List<int> price_size = new List<int>() { 1000, 5000, 10000 };
        database sql = new database();
        OpenFileDialog file = new OpenFileDialog();
        int totalPrice = 30000;
        public SelfDesign(Acc acc)
        {
            InitializeComponent();
            account = acc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(file.ShowDialog() == DialogResult.OK)
            {
                label1.Text = file.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sql.CreateOrder(account.Id, file.FileName, comboBox1.SelectedItem.ToString(), totalPrice.ToString()))
            {
                MessageBox.Show("Заказ успешно создан!");
                comboBox1.SelectedIndex = 0;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            totalPrice = 30000;
            totalPrice += price_size[comboBox1.SelectedIndex];
            label4.Text = totalPrice.ToString();
        }

        private void SelfDesign_Load(object sender, EventArgs e)
        {
            foreach (var item in size)
            {
                comboBox1.Items.Add(item);
            }
        }
    }
}
