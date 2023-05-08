using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRes.GUI.Manager.Food
{
    public partial class Fm_Add : Form
    {
        public Fm_Add()
        {
            InitializeComponent();
        }

        private void txt_price_Leave(object sender, EventArgs e)
        {
            txt_price.Text = string.Format("{0:0,0}", txt_price.Text);
        }
    }
}
