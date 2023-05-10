using MRes.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRes.GUI.Oder.Table
{
    public partial class Fm_Table : Form
    {
        List<string> a = new List<string>()
        {
            "1","2","3","4","5"
        };
        public Fm_Table()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
 
            


        }

        private void imageListBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
