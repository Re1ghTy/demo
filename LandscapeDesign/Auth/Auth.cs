using LandscapeDesign.Administrator;
using LandscapeDesign.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandscapeDesign.Auth
{
    public partial class Auth : Form
    {
        database data = new database();
        public Auth()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                MessageBox.Show("Поля не должны быть пустыми!");
            }
            else
            {
                if (data.Auth(textBox1.Text, textBox2.Text))
                {
                    Auth.ActiveForm.Hide();
                    Main main = new Main(textBox1.Text);
                    main.ShowDialog();

                }
                else if (textBox1.Text == "admin" && textBox2.Text == "admin")
                {
                    Auth.ActiveForm.Hide();
                    MainAdmin main = new MainAdmin();
                    main.ShowDialog();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Auth.ActiveForm.Hide();
            Reg main = new Reg();
            main.ShowDialog();

        }
    }
}
