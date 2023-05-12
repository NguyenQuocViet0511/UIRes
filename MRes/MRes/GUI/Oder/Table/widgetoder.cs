using MRes.DAL;
using MRes.DAL.API.BillInfo;
using MRes.DAL.API.Food;
using MRes.Models.BillInfo;
using MRes.Models.Food;
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
    public partial class widgetoder : UserControl
    {
        FoodData food;
        public widgetoder()
        {
            InitializeComponent();
            GetData();
        }
        //get data
        public void GetData()
        {
            Task t = new Task(
                () =>
                {
                    food = APIFood.Instance.GetAll();

                    gridController.BeginInvoke((Action)delegate ()
                    {
                        if (food != null)
                        {
                            gridController.DataSource = food.data.data;
                            ClearandAdd();
                        }


                    });
                }
                );
            t.Start();

        }
        //oder
        public void Order()
        {
            Task t = new Task(
                () =>
                {
                    String result = APIBillInfo.Instance.CreateOrUpdate(txt_id.Text, Const.table.id, Const.table.id_bill,Convert.ToInt32(txt_number.Value),txt_note.Text,"US000000");
                     MessageBox.Show("" + result);
                    LoadBillandtable();

                }
                );
            t.Start();

        }
      
        //clearbingding
        public void ClearandAdd()
        {
            if (food != null)
            {
                txt_id.DataBindings.Clear();
                txt_id.DataBindings.Add("text", food.data.data, "id");
                //
                txt_name.DataBindings.Clear();
                txt_name.DataBindings.Add("text", food.data.data, "name");
                //

                //
                txt_price.DataBindings.Clear();
                txt_price.DataBindings.Add("text", food.data.data, "price");
                //

            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_number.Value > 0)
            {
                Order();

            }else
            {
                MessageBox.Show("Bạn Chưa thêm Số lượng món ăn");

            }
        }

        public delegate void Loadbill();
        public Loadbill LoadBillandtable;
    }
}
