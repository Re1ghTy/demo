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
    public partial class Catalog : Form
    {
        Acc account = new Acc();
        List<string> type = new List<string>() { "Ландшафт по проекту,", "Поле для гольфа", "Парк" };
        List<string> size = new List<string>() { "До 100 км2", "До 1000 км2", "До 10000 км2" };
        List<int> price_type = new List<int>() { 3123, 2313, 7689 };
        List<int> price_size = new List<int>() { 1000, 5000, 10000 };
        database sql = new database();
        int totalPrice = 0;
        public Catalog(Acc acc)
        {
            InitializeComponent();
            account = acc;
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            foreach (var item in type)
            {
                comboBoxType.Items.Add(item);
            }

            foreach (var item in size)
            {
                comboBoxSize.Items.Add(item);
            }

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSize.Enabled = true;;
            totalPrice = price_type[comboBoxType.SelectedIndex];
            labelPrice.Text = totalPrice.ToString();

        }

        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            totalPrice = 0;
            totalPrice = price_type[comboBoxType.SelectedIndex] + price_size[comboBoxSize.SelectedIndex];
            labelPrice.Text = totalPrice.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if( sql.CreateOrder(account.Id, comboBoxType.SelectedItem.ToString(), comboBoxSize.SelectedItem.ToString(), totalPrice.ToString()))
            {
                MessageBox.Show("Заказ успешно создан!");
                comboBoxType.SelectedIndex = 0;
                comboBoxSize.SelectedIndex = 0;
            }
        }
    }
}
