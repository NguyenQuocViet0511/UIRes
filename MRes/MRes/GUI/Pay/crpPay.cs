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

namespace MRes.GUI.Pay
{
    public partial class crpPay : Form
    {
        public crpPay()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            CrystalReport crypay = new CrystalReport();
            crypay.SetDataSource(Const.billinfo);
            crp.ReportSource = crypay;
            crypay.PrintToPrinter(1, true, 0, 0);

        }
    }
}
