using MRes.DAL;
using MRes.GUI.Manager.Category;
using MRes.GUI.Manager.Food;
using MRes.GUI.Manager.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRes
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string Chonse = "";
        bool CheckClick = false;
        Fm_category Category;
        Fm_Staff staff;
        QL_Food food;
        public Main()
        {
            InitializeComponent();
        }

        private void btn_food_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            food = new QL_Food();
            CreateForm(food,null);
            this.Chonse = Const.MANAGER_FOOD;

        }


        //Created one new form
        private void CreateForm(Form form = null ,UserControl userControl = null)
        {
            ManagerController.Controls.Clear();
         
            if(form !=null)
             {
                form.Dock = DockStyle.Fill;
                form.TopLevel = false;
                ManagerController.Controls.Add(form);
                form.Show();
             }
            if (userControl != null)
            {
                userControl.Dock = DockStyle.Fill;
                ManagerController.Controls.Add(userControl);
                userControl.Show();
            }

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChoseAdd(this.Chonse);
            this.CheckClick = true;
           
        }

        private void btn_staff_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            staff = new Fm_Staff();
            CreateForm(staff, null);
        }

        private void btn_category_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Category = new Fm_category();
            CreateForm(Category, null);
        }
        //
        private void setshoseadd(bool set)
        {
            btn_edit.Enabled = set;
            btn_delete.Enabled = set;
        }

        private void setshoseedit(bool set)
        {
            btn_add.Enabled = set;
            btn_delete.Enabled = set;
        }
        private void setshoseall(bool set)
        {
            btn_add.Enabled = set;
            btn_delete.Enabled = set;
            btn_edit.Enabled = set;
        }
        private void ChoseAdd(string text)
        {
        //public static string MANAGER_FOOD = "QLFOOD";
        //public static string MANAGER_CATEGORY = "QLCATEGORY";
        //public static string MANAGER_STAFF = "QLSTAFF";
            switch (text)
            {
                case "QLFOOD":
                    food.setPanel(true);
                    food.Cleartext();
                    setshoseadd(false);
                    break;
                case "QLCATEGORY":

                    break;
                case "QLSTAFF":

                    break;
            }    
        }
        private void Choseclose(string text)
        {
            //public static string MANAGER_FOOD = "QLFOOD";
            //public static string MANAGER_CATEGORY = "QLCATEGORY";
            //public static string MANAGER_STAFF = "QLSTAFF";
            switch (text)
            {
                case "QLFOOD":
                    food.setPanel(false);
                    food.ClearandAdd();
                    break;
                case "QLCATEGORY":

                    break;
                case "QLSTAFF":

                    break;
            }
        }
        private void Chosesave(string text)
        {
            //public static string MANAGER_FOOD = "QLFOOD";
            //public static string MANAGER_CATEGORY = "QLCATEGORY";
            //public static string MANAGER_STAFF = "QLSTAFF";
            switch (text)
            {
                case "QLFOOD":
                    food.setPanel(false);
                    food.Add();
                    food.GetData();
                    break;
                case "QLCATEGORY":

                    break;
                case "QLSTAFF":

                    break;
            }
        }
        private void Chosedelete(string text)
        {
            //public static string MANAGER_FOOD = "QLFOOD";
            //public static string MANAGER_CATEGORY = "QLCATEGORY";
            //public static string MANAGER_STAFF = "QLSTAFF";
            switch (text)
            {
                case "QLFOOD":
                    food.delete();    
                    break;
                case "QLCATEGORY":

                    break;
                case "QLSTAFF":

                    break;
            }
        }
        private void btn_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(CheckClick == true)
            {
                if (MessageBox.Show("Bạn Có Muốn Lưu Bỏ Không", "Thông Báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
                {
                    Chosesave(this.Chonse);
                    setshoseall(true);
                    CheckClick = false;
                }
            }   
           
        }

        private void btn_close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bạn Có Muốn Hủy Bỏ Không","Thông Báo",MessageBoxButtons.OKCancel) != DialogResult.Cancel)
            {
                Choseclose(this.Chonse);
                setshoseall(true);
                CheckClick = false;
            }
        }

        private void btn_delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Xóa Bỏ Không", "Thông Báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
            {
                Chosedelete(this.Chonse);

            }
        }
    }
}
