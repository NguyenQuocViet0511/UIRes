using DevExpress.Utils;
using DevExpress.XtraCharts;
using MRes.DAL.API.Inventory;
using MRes.Models.Inventory;
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
    public partial class Revenueinventory : Form
    {
        HistoryinventoryData historyinventory;

        public Revenueinventory()
        {
            InitializeComponent();
            LoadData();
            
            }

            public void LoadData()
            {
                Task t1 = new Task(() =>
                {
                    historyinventory = APIHistoryInventory.Instance.GetAll();

                    chartControl1.DataSource = historyinventory.data.data;
   

                });


                t1.Start();

            }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
