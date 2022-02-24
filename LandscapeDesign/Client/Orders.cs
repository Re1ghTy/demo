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
    public partial class Orders : Form
    {
        Acc account = new Acc();
        database sql = new database();
        DataTable orders = new DataTable();
        public Orders(Acc acc)
        {
            InitializeComponent();
            account = acc;
            orders = sql.GetOrders(account.Id);
        }


        private void addLabelTicket(int i, FlowLayoutPanel flow)
        {

            Label lbl = new Label();
            lbl.Name = "lbl" + i;
            lbl.Font = new Font(lbl.Font.Name, 10);
            lbl.Text = "Ваш заказ " + orders.Rows[i][0].ToString() + " от " + orders.Rows[i][5].ToString() +
                ". Вы заказли проект " + orders.Rows[i][2].ToString() +" " + orders.Rows[i][3].ToString() +" на сумму:" + orders.Rows[i][4].ToString() +" руб.";

            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.AutoSize = true;
            //lbl.Dock = DockStyle.Fill;
            //lbl.Dock = DockStyle.Top;
            flow.Controls.Add(lbl);
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < orders.Rows.Count; i++)
            {
                //flowLayoutPanel1.Controls.Add(flw);
                addLabelTicket(i, flowLayoutPanel1);
            }
        }
    }
}
