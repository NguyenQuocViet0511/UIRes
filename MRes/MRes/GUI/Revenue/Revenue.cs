using DevExpress.XtraCharts;
using MRes.DAL.API.Bill;
using MRes.Models.Bill;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRes.GUI.Revenue
{
    public partial class Revenue : Form
    {
        BillData bill;
        public Revenue()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            Task t1 = new Task(() =>
            {
                bill = APIBill.Instance.GetAll();

                if (bill != null)
                {
                    chartControl1.DataSource = bill.data.data;
                }    
            
            });


            t1.Start();

        }   
    }
}
