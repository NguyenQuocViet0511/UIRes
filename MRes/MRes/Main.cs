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
        string type = "";
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
            this.type = "add";
            this.CheckClick = true;
           
        }

        private void btn_staff_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            staff = new Fm_Staff();
            CreateForm(staff, null);
            this.Chonse = Const.MANAGER_STAFF;

        }

        private void btn_category_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Category = new Fm_category();
            CreateForm(Category, null);
            this.Chonse = Const.MANAGER_CATEGORY;

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
        //add
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
                    Category.setPanel(true);
                    Category.Cleartext();
                    setshoseadd(false);
                    break;
                case "QLSTAFF":
                    staff.setPanel(true);
                    staff.Cleartext();
                    setshoseadd(false);
                    break;
            }    
        }
        private void Choseedit(string text)
        {
            //public static string MANAGER_FOOD = "QLFOOD";
            //public static string MANAGER_CATEGORY = "QLCATEGORY";
            //public static string MANAGER_STAFF = "QLSTAFF";
            switch (text)
            {
                case "QLFOOD":
                    food.setPanel(true);
                    setshoseedit(false);
                    break;
                case "QLCATEGORY":
                    Category.setPanel(true);
                    setshoseedit(false);
                    break;
                case "QLSTAFF":
                    staff.setPanel(true);
                    setshoseedit(false);
                    break;
            }
        }
        //close
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
                        setshoseall(true);
                        CheckClick = false;
                    break;
                case "QLCATEGORY":
                    Category.setPanel(false);
                    Category.ClearandAdd();
                    setshoseall(true);
                    CheckClick = false;
                    break;
                case "QLSTAFF":
                    staff.setPanel(false);
                    staff.ClearandAdd();
                    setshoseall(true);
                    CheckClick = false;
                    break;
            }
        }
        // save
        private void Chosesave(string text)
        {
            //public static string MANAGER_FOOD = "QLFOOD";
            //public static string MANAGER_CATEGORY = "QLCATEGORY";
            //public static string MANAGER_STAFF = "QLSTAFF";
            switch (text)
            {
                case "QLFOOD":
                    if (this.type == "add")
                    {
                        if (food.check())
                        {
                            food.Add();
                            setshoseall(true);
                            CheckClick = false;
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng Nhập Vào Đầy Đủ ô cần nhập");
                        }
                    }
                    if(this.type == "edit")
                    {

                        if (food.check())
                        {
                            food.edit();
                            setshoseall(true);
                            CheckClick = false;
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng Nhập Vào Đầy Đủ ô cần nhập");
                        }
                    }
                    break;
                case "QLCATEGORY":
                    if (this.type == "add")
                    {
                        if (Category.check())
                        {
                            Category.Add();
                            setshoseall(true);
                            CheckClick = false;
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng Nhập Vào Đầy Đủ ô cần nhập");
                        }
                    }
                    if (this.type == "edit")
                    {

                        if (Category.check())
                        {
                            Category.edit();
                            setshoseall(true);
                            CheckClick = false;
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng Nhập Vào Đầy Đủ ô cần nhập");
                        }
                    }
                    break;
                case "QLSTAFF":
                    if (this.type == "add")
                    {
                        if (staff.check())
                        {
                            staff.Add();
                            setshoseall(true);
                            CheckClick = false;
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng Nhập Vào Đầy Đủ ô cần nhập");
                        }
                    }
                    if (this.type == "edit")
                    {

                        if (staff.check())
                        {
                            staff.edit();
                            setshoseall(true);
                            CheckClick = false;
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng Nhập Vào Đầy Đủ ô cần nhập");
                        }
                    }
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
                    if (MessageBox.Show("Bạn Có Muốn Xóa Bỏ Không", "Thông Báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
                    {
                        food.delete();

                    }
                    break;
                case "QLCATEGORY":
                    if (MessageBox.Show("Bạn Có Muốn Xóa Bỏ Không ! Nếu Xóa Thì Sẽ cùng Xóa Hết Danh Sách Món Ăn Đã Theo Danh Mục Này ", "Thông Báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
                    {
                        Category.delete();

                    }
                    break;
                case "QLSTAFF":
                    if (MessageBox.Show("Bạn Có Muốn Xóa Bỏ Không", "Thông Báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
                    {
                        staff.delete();

                    }
                    break;
            }
        }
        private void btn_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(CheckClick == true)
            {
                if (MessageBox.Show("Bạn Có Muốn Lưu  Không", "Thông Báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
                {
                    Chosesave(this.Chonse);
                }
            }   
           
        }

        private void btn_close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckClick == true)
            {
                if (MessageBox.Show("Bạn Có Muốn Hủy Bỏ Không","Thông Báo",MessageBoxButtons.OKCancel) != DialogResult.Cancel)
            {
                Choseclose(this.Chonse);
             
            }
            }
        }

        private void btn_delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
 
                Chosedelete(this.Chonse);
        }

        private void btn_edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.type = "edit";
            this.CheckClick = true;
            Choseedit(this.Chonse);

        }
    }
}
