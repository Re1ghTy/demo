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
    public partial class Main : Form
    {
        private Button currentButton;
        private Form activeForm;
        Acc account = new Acc();
        DataTable data = new DataTable();
        database sql = new database();
        public Main(string login)
        {
            InitializeComponent();
            data = sql.GetClient(login);
            account.Id = data.Rows[0][0].ToString();
            account.Name = data.Rows[0][1].ToString();
            account.Login = data.Rows[0][2].ToString();

        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();

                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.Gray;
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

                }
            }
        }


        private void DisableButton()
        {
            foreach (Control previousBtn in panelBut.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.White;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

                }
            }
        }





        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Profile(account), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Catalog(account), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Orders(account), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SelfDesign(account), sender);
        }
    }
}
