using MRes.DAL;
using MRes.DAL.API.Table;
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
    public partial class WidgetTable : UserControl
    {
        bool ClickTable = false;
        Button Button;
        TableData table;
        string id_update = "";
        public WidgetTable()
        {
            InitializeComponent();
            loadTable();
        }
        private void loadTable()
        {


            Task t = new Task(
               () =>
               {
                   table = APITable.Instance.GetStatus();

                   flow_Table.BeginInvoke((Action)delegate ()
                   {
                       flow_Table.Controls.Clear();
                       if (table != null)
                       {
                           foreach (var item in table.data.data)
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
                               Button.Click += Button_Click;
                               Button.Tag = item.id;
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
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            SetClickButton(btn, null);
            id_update = btn.Tag.ToString();
            ClickTable = true;
        }

        private void btn_agree_Click(object sender, EventArgs e)
        {
            if(ClickTable)
            {
                if (MessageBox.Show("Bạn Có Muốn Chuyển Bàn Không", "Cảnh Báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
                {
                    move();
                }

            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn Bàn Cần Chuyển");
            }    
        }
        public void move()
        {
            Task t = new Task(
                () =>
                {
                    String result = APITable.Instance.Move(Const.tableMove.id,id_update, Const.tableMove.id_bill);
                    MessageBox.Show("" + result);
                    LoadBillandtable();
                    loadTable();
                    ClickTable = false;

                }
                );
            t.Start();

        }
        public delegate void Loadbill();
        public Loadbill LoadBillandtable;
    }
}
