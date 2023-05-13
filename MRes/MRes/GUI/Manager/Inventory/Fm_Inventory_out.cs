using DevExpress.XtraGrid.Views.Grid;
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

namespace MRes.GUI.Manager.Inventory
{
    public partial class Fm_Inventory_out : Form
    {
        bool Click = false;
        InventoryData inventory;
        int count = 0;
        HistoryinventoryData historyinventory;
        public Fm_Inventory_out()
        {
            InitializeComponent();
            Getinventory();
            Gethistoryinventory();
            CheckForIllegalCrossThreadCalls = false;
        }

        public void Getinventory()
        {
            Task t1 = new Task(
             () =>
             {
                 inventory = APIInventory.Instance.GetAll();
                 if (inventory != null)
                 {
                     gird_material.DataSource = inventory.data.data;
                     ClearandAdd();
                 }


             }
             );
            t1.Start();
        }
        public void Gethistoryinventory()
        {
            Task t1 = new Task(
             () =>
             {
                 historyinventory = APIHistoryInventory.Instance.GetAll();
                 if (historyinventory != null)
                 {
                     grid_history.DataSource = historyinventory.data.data;
                 }


             }
             );
            t1.Start();
        }
    
    public void ClearandAdd()
    {
        if (inventory != null)
        {
            txt_id.DataBindings.Clear();
            txt_id.DataBindings.Add("text", inventory.data.data, "id");
            //
     
            //

            //
            txt_name.DataBindings.Clear();
                txt_name.DataBindings.Add("text", inventory.data.data, "name");
        }


        //

    }

        private void btn_out_Click(object sender, EventArgs e)
        {
            Click = true;
            panel_controller.Enabled = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(Click)
            {
                check();
            }else
            {
                MessageBox.Show("Bạn Chưa Chọn Xuất Kho");
            }    
        }

        private void check()
        { 
            if(txt_number.Value <= 0)
            {
                MessageBox.Show("Vui Lòng Nhập Lớn Hơn 0");
            }else
            {
                if (count < txt_number.Value)
                {
                    MessageBox.Show("Kho Không Còn Đủ Số Lượng Lớn Hơn Số Lượng Bạn Xuất");

                }
                else
                {
                    update(txt_id.Text,0,txt_number.Value.ToString());
                }    
            }    
        }
  
        private void gird_material_Click(object sender, EventArgs e)
        {
            count = Convert.ToInt32(((GridView)gird_material.MainView).GetFocusedRowCellValue("quantity"));

        }

        private void update(string id_material, int count, string countout)
        {
            Task t1 = new Task(
             () =>
             {
                 
                 string result = APIInventory.Instance.update(id_material, count.ToString(), countout);
                 MessageBox.Show(result);
                 Getinventory();
                 Gethistoryinventory();

             }
             );
            t1.Start();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Click = false;
            panel_controller.Enabled = false;
        }
    }
}
