using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandscapeDesign.Administrator
{
    public partial class Simulate : Form
    {
        database sql = new database();
        public Simulate()
        {
            InitializeComponent();
        }

        private bool working = false;
        private int countUser = 0;
        private DateTime date = new DateTime(2022, 02, 10);


        public void SimulationsReg()
        {
            string  login, password, name;

            string[] Arrlogin = { "Iassi", "Kayol", "Soaaa", "Dreamer", "Syaako", "Usti", "Nnabigna", "Zells" };
            string[] Arrpassword = { "wKv2UkCU", "Evn0Vxkk", "5WyBFgL0", "0GpHttwh", "Ig7Xyx7M", "2ru3zuJb" };
            string[] Arrname = { "Ева", "Анна", "Вера", "Арсений", "Кира", "Эрик", "Александра", "Даниил", "Дарина", "Иван", "Василиса", "Владимир" };

            Random random = new Random();

            while (working)
            {
                login = Arrlogin[random.Next(0, Arrlogin.Length - 1)];
                password = Arrpassword[random.Next(0, Arrpassword.Length - 1)];
                name = Arrname[random.Next(0, Arrname.Length - 1)];


                countUser++;



                sql.Create( login, password, name);

                Thread.Sleep(500);

            }





        }
        private void SimLoop()
        {
            while (working)
            {
                if (date.DayOfWeek == DayOfWeek.Monday)
                {

                }
                label1.Invoke(new Action(() => label1.Text = countUser.ToString()));

                label3.Invoke(new Action(() => label3.Text = date.ToString("d")));

                date = date.AddDays(1);
                Thread.Sleep(1000);

            }
        }


        private void Start()
        {
            working = true;
            Task.Run(() => SimLoop());
            Task.Run(() => SimulationsReg());
        }

        private void Stop()
        {
            working = false;
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {

            Start();

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Stop();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
