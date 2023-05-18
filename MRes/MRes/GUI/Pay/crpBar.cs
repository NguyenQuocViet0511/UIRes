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
    public partial class crpBar : Form
    {
        public crpBar()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            CrystalReportBar crypay = new CrystalReportBar();
            crypay.SetDataSource(Const.billinfoBar);
            crp.ReportSource = crypay;
            crypay.PrintToPrinter(1, true, 0, 0);

        }
    }
}
