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
    
    public partial class statistical : Form
    {
        BillData billData;
        public statistical()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_statistical_Click(object sender, EventArgs e)
        {
            loadData();

        }

    
        public void  loadData()
        {
            MessageBox.Show("Đang lấy dữ liệu vui lòng chờ!");
            Task t = new Task(
                () =>
                {
                    if(ckn_today.Checked == true)
                    {
                        DateTime today = DateTime.Today;
                        billData = APIBill.Instance.GetBillByDate(today.ToString("yyyy-MM-dd"));

                    }
                    else
                    {
                        billData = APIBill.Instance.GetBill(datestart.Text, dateend.Text);

                    }
                    if (billData != null)
                    {
                        grid_data.BeginInvoke((Action)delegate ()
                        {
                            double sum = 0;
                            grid_data.DataSource = billData.data.data;
                            foreach(var item in billData.data.data)
                            {
                                sum += item.sum;
                            }
                            lblMoney.Text = sum.ToString();

                        });
                    }

                }
                );
            t.Start();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        
    }
}
