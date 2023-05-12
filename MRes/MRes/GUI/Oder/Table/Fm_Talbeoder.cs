using MRes.DAL;
using MRes.DAL.API.BillInfo;
using MRes.DAL.API.Table;
using MRes.GUI.Pay;
using MRes.Models.BillInfo;
using MRes.Models.Table;
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
    public partial class Fm_Talbeoder : Form
    {
        TableData table;
        string chonse = "";
        string[] Split;
        BillInfoData billInfo; 
        Button Button;
        bool ClickTalbe = false;
        public Fm_Talbeoder()
        {
            InitializeComponent();
            loadTable();
        }

        //Created one new form
        private void CreateForm(Form form = null, UserControl userControl = null)
        {
            Manager_controller.Controls.Clear();

            if (form != null)
            {
                form.Dock = DockStyle.Fill;
                form.TopLevel = false;
                Manager_controller.Controls.Add(form);
                form.Show();
            }
            if (userControl != null)
            {
                userControl.Dock = DockStyle.Fill;
                Manager_controller.Controls.Add(userControl);
                userControl.Show();
            }

        }
        //clearbingding
        public void ClearandAdd()
        {
            if (billInfo != null)
            {
                txt_id.DataBindings.Clear();
                txt_id.DataBindings.Add("text", billInfo.data.data, "id");
                //
                txt_name.DataBindings.Clear();
                txt_name.DataBindings.Add("text", billInfo.data.data, "foodname");
                //
                txt_idbill.DataBindings.Clear();
                txt_idbill.DataBindings.Add("text", billInfo.data.data, "id_bill");
                //
                txt_number.DataBindings.Clear();
                txt_number.DataBindings.Add("text", billInfo.data.data, "count");
                //
                txt_sum1.DataBindings.Clear();
                txt_sum1.DataBindings.Add("text", billInfo.data.data, "sum");
                //
                txt_note.DataBindings.Clear();
                txt_note.DataBindings.Add("text", billInfo.data.data, "note");
                Const.table.id_bill = txt_idbill.Text;


            }
        }
        private void Cleartext()
        {
            txt_id.Text = "";
            txt_name.Text = ""; ;
            txt_idbill.Text = "";
            txt_sum1.Text = "";
            txt_number.Text = "";
            lbl_name.Text = "BÀN";




        }


        //
        private void enablebutton(string  chonse,bool check)
        {
            switch(chonse)
            {
                case "move":
                    btn_into.Enabled = check;
                    btn_oder.Enabled = check;
                    break;
                case "order":
                    btn_into.Enabled = check;
                    btn_move.Enabled = check;
                    break;
                case "into":
                    btn_move.Enabled = check;
                    btn_oder.Enabled = check;
                    break;
            }    
        }
        //get table
        private void loadTable()
        {


            Task t = new Task(
               () =>
               {
                   table = APITable.Instance.GetAll();

                   flow_Table.BeginInvoke((Action)delegate ()
                   {
                       flow_Table.Controls.Clear();
                       if (table != null)
                       {
                           foreach(var item in table.data.data)
                           {
                               Button = new Button();
                               Button.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                               Button.ForeColor = Color.White;
                               Button.BackColor = Color.FromArgb(133, 133, 133);
                               Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
                               Button.Location = new System.Drawing.Point(49, 196);
                               Button.Size = new System.Drawing.Size(120, 60);
                               Button.Text = item.name;
                               Button.FlatStyle = FlatStyle.Flat;
                               Button.Click += Button_Click1;
                               Button.Tag = item.id +"," +item.id_bill;
                               Button.FlatAppearance.BorderSize = 0;
                               switch (item.status)
                               {
                                   case "Yes":
                                       Button.Image = global::MRes.Properties.Resources.eat;
                                       break;
                                   case "No":
                                       Button.Image = global::MRes.Properties.Resources.eating;
                                       break;
                               }
                               Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                               flow_Table.Controls.Add(Button);

                           }


                       }


                   });
               }
               );
            t.Start();

        }

        private void Button_Click1(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lbl_name.Text = "BÀN :" + " " + btn.Text;
            SetClickButton(btn, null);
            ClickTalbe = true;
            string str = btn.Tag.ToString();
            Split = str.Split(',');
            Const.table.id = Split[0];
            Const.table.id_bill = "";
            Const.tableMove.id = Split[0];
            Const.tableMove.id_bill = Split[1];

            LoadDataBill();
        }

        private void LoadDataBill()
        {

          
            Task t = new Task(
                () =>
                {
                    
                    billInfo = APIBillInfo.Instance.GetBillInfo(Split[1].ToString(), Split[0].ToString());
                    if (billInfo != null)
                    {
                        grid_billinfo.BeginInvoke((Action)delegate ()
                        {
                            double sum = 0;
                            grid_billinfo.DataSource = null;
                            grid_billinfo.DataSource = billInfo.data.data;
                            foreach (var item in billInfo.data.data)
                            {
                                sum += item.sum;
                            }
                            txt_sum.Text = sum.ToString();
                            ClearandAdd();

                        });
                    }

                }
                );
            t.Start();
        }

        private void SetClickButton(object sender, EventArgs e)
        {
            foreach (Control c in flow_Table.Controls)
            {
                c.BackColor = Color.FromArgb(133, 133, 133);
                c.ForeColor = Color.White;
            }
            Control Click = sender as Control;
            Click.BackColor = Color.Black;
            Click.ForeColor = Color.White;
        }
     

        private void imageListBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btn_oder_Click_1(object sender, EventArgs e)
        {
           
            if (ClickTalbe == true)
            {
              
                enablebutton("order", false);
                chonse = "order";
                widgetoder widgetoder = new widgetoder()
                {
                    LoadBillandtable = new widgetoder.Loadbill(LoadBillandtable)

            };
                CreateForm(null, widgetoder);
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn Bàn Gọi Món");
            }
        }

        private void btn_move_Click_1(object sender, EventArgs e)
        {

            if (ClickTalbe == true)
            {

                WidgetTable WidgetTable = new WidgetTable()
                {
                    LoadBillandtable = new WidgetTable.Loadbill(LoadBillandtable)

                };
                chonse = "move";
                enablebutton("move", false);
                CreateForm(null, WidgetTable);
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn Bàn Cần Chuyển");
            }
        }

        private void btn_into_Click(object sender, EventArgs e)
        {
            WidgetTable WidgetTable = new WidgetTable();
            CreateForm(null, WidgetTable);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if(ClickTalbe)
            {
                if (MessageBox.Show("Bạn Có Muốn Hủy Bỏ Không", "Thông Báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
                {
                    btn_into.Enabled = true;
                    btn_oder.Enabled = true;
                    btn_move.Enabled = true;
                    lbl_name.Text = "BÀN";
                    ClickTalbe = false;
                    grid_billinfo.DataSource = null;
                    Manager_controller.Controls.Clear();

                    foreach (Control c in flow_Table.Controls)
                    {
                        c.BackColor = Color.FromArgb(133, 133, 133);
                        c.ForeColor = Color.White;
                    }
                    txt_sum.Text = "Tiền";
                    Cleartext();
                }    
           
            }
           
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Xóa Bỏ Không", "Cảnh Báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
            {
                delete();
            }
        }
        //clear
        public void delete()
        {
            Task t = new Task(
                () =>
                {
                    String result = APIBillInfo.Instance.delete(txt_id.Text, Const.table.id_bill, Const.table.id);
                    MessageBox.Show("" + result);
                    LoadDataBill();
                }
                );
            t.Start();

        }
        //send
        public void SendCook()
        {
            Task t = new Task(
                () =>
                {
                    String result = APIBillInfo.Instance.SendCook(txt_id.Text, Const.table.id_bill, Const.table.id);
                    MessageBox.Show("" + result);
                    LoadDataBill();

                }
                );
            t.Start();

        }
        private void btn_bar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Gửi Bếp Không", "Cảnh Báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
            {
                SendCook();

            }
        }
        //event load
        public delegate void Loadbill();
        public void LoadBillandtable()
        {
            chonseLoad(chonse);
        }
         private void chonseLoad(string text)
        {
            switch(text)
            {
                case "move":
                    loadTable();
                    flow_Table.BeginInvoke((Action)delegate ()
                       {
                           grid_billinfo.DataSource = null;
                           Cleartext();

                       });
                    break;
                case "order":
                    loadTable();
                    LoadDataBill();
                    break;
            }    
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            PayM pay = new PayM();
            pay.Show();
        }
       
    }
}
