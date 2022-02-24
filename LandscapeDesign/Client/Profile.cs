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
    public partial class Profile : Form
    {
        Acc account = new Acc();
        public Profile(Acc acc)
        {
            InitializeComponent();
            account= acc;
        }
    }
}
