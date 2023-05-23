using DevExpress.Skins;
using DevExpress.UserSkins;
using MRes.DAL;
using MRes.GUI.Login;
using MRes.GUI.Manager.Category;
using MRes.GUI.Manager.Food;
using MRes.GUI.Manager.Inventory;
using MRes.GUI.Manager.Staff;
using MRes.GUI.Manager.Table;
using MRes.GUI.Oder.Table;
using MRes.GUI.Revenue;
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
        Fm_Table table;
        Fm_Material Material;
        QL_Food food;
        public Main()
        {
            InitializeComponent();
            Server.Instance.Connect();


        }

        private void btn_food_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            if (CheckClick)
            {
                MessageBox.Show("Bạn  Vẫn Đang Hành Động Trong Form Này");
            }
            else
            {
                food = new QL_Food();
                CreateForm(food, null);
                this.Chonse = Const.MANAGER_FOOD;
            }
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
            showlogin();

        }

        private void btn_add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChoseAdd(this.Chonse);
            this.type = "add";
            this.CheckClick = true;
           
        }

        private void btn_staff_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if(CheckClick)
            {
                MessageBox.Show("Bạn  Vẫn Đang Hành Động Trong Form Này");
            }  
            else
            {
                staff = new Fm_Staff();
                CreateForm(staff, null);
                this.Chonse = Const.MANAGER_STAFF;
            }    
           

        }

        private void btn_category_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (CheckClick)
            {
                MessageBox.Show("Bạn  Vẫn Đang Hành Động Trong Form Này");
            }
            else
            {
                Category = new Fm_category();
                CreateForm(Category, null);
                this.Chonse = Const.MANAGER_CATEGORY;
            }
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
                case "QLTABLE":
                    table.setPanel(true);
                    table.Cleartext(); 
                    setshoseadd(false);
                    break;
                case "QLMATERIAL":
                    Material.setPanel(true);
                    Material.Cleartext(); 
                    setshoseadd(false);
                    break;
                    CheckClick = false;

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
                case "QLTABLE":
                    table.setPanel(true);
                    setshoseedit(false);
                    break;
                case "QLMATERIAL":
                    Material.setPanel(true);
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
                case "QLTABLE":
                    table.setPanel(false);
                    table.ClearandAdd();
                    setshoseall(true);
                    CheckClick = false;
                    break;
                case "QLMATERIAL":
                    Material.setPanel(false);
                    Material.ClearandAdd();
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
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng Nhập Vào Đầy Đủ ô cần nhập");
                        }
                    }
                    break;
                case "QLTABLE":
                    if (this.type == "add")
                    {
                        if (table.check())
                        {
                            table.Add();
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng Nhập Vào Đầy Đủ ô cần nhập");
                        }
                    }
                    if (this.type == "edit")
                    {

                        if (table.check())
                        {
                            table.edit();
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng Nhập Vào Đầy Đủ ô cần nhập");
                        }
                    }
                    break;
                case "QLMATERIAL":
                    if (this.type == "add")
                    {
                        if (Material.check())
                        {
                            Material.Add();
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng Nhập Vào Đầy Đủ ô cần nhập");
                        }
                    }
                    if (this.type == "edit")
                    {

                        if (Material.check())
                        {
                            Material.edit();
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
                case "QLTABLE":
                    if (MessageBox.Show("Bạn Có Muốn Xóa Bỏ Không", "Thông Báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
                    {
                        table.delete();

                    }
                    break;
                case "QLMATERIAL":
                    if (MessageBox.Show("Bạn Có Muốn Xóa Bỏ Không", "Thông Báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
                    {
                        Material.delete();

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

        private void btn_input_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (CheckClick)
            {
                MessageBox.Show("Bạn  Vẫn Đang Hành Động Trong Form Này");
            }
            else
            {
                Fm_Inventory inventory = new Fm_Inventory();
                CreateForm(inventory, null);
            }
        }

        private void btn_material_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (CheckClick)
            {
                MessageBox.Show("Bạn  Vẫn Đang Hành Động Trong Form Này");
            }
            else
            {
                Material = new Fm_Material();
                CreateForm(Material, null);
                this.Chonse = Const.MANAGER_MATERIAL;
            }
        }

        private void btn_table_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (CheckClick)
            {
                MessageBox.Show("Bạn  Vẫn Đang Hành Động Trong Form Này");
            }
            else
            {
                Fm_Talbeoder tableoder = new Fm_Talbeoder();
                CreateForm(tableoder, null);
            }
        }

        private void btn_sum_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (CheckClick)
            {
                MessageBox.Show("Bạn  Vẫn Đang Hành Động Trong Form Này");
            }
            else
            {
                Fm_Inventory_out Inventory_out = new Fm_Inventory_out();
                CreateForm(Inventory_out, null);
            }
        }

        private void btn_tb_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (CheckClick)
            {
                MessageBox.Show("Bạn  Vẫn Đang Hành Động Trong Form Này");
            }
            else
            {
                table = new Fm_Table();
                CreateForm(table, null);
                this.Chonse = Const.MANAGER_TALBE;
            }

        }

        private void btn_Revenue_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (CheckClick)
            {
                MessageBox.Show("Bạn  Vẫn Đang Hành Động Trong Form Này");
            }
            else
            {
                Revenue revenue = new Revenue();
                CreateForm(revenue, null);
            }
        }

        private void btn_history_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (CheckClick)
            {
                MessageBox.Show("Bạn  Vẫn Đang Hành Động Trong Form Này");
            }
            else
            {
                Revenueinventory Revenueinventory = new Revenueinventory();
                CreateForm(Revenueinventory, null);
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult diaglog = (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Quản Lý", MessageBoxButtons.OKCancel, MessageBoxIcon.Question));
            if(diaglog == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;

            }

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            

        }
        private void showlogin()
        {
            Login login = new Login();
            Revenue revenue = new Revenue();
            CreateForm(revenue, null);
            login.ShowDialog();
        }
        private void btn_logout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bạn Có Muốn Đăng Xuất Không","Thông Báo Cho Người Dùng",MessageBoxButtons.OKCancel) != DialogResult.Cancel)
            {
                if (CheckClick)
                {
                    MessageBox.Show("Bạn  Vẫn Đang Hành Động Trong Form Này");
                }
                else
                {
                    showlogin();
                }
              
            }
        }
    }
}
