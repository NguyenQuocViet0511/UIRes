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

        public Main()
        {
            InitializeComponent();
        }

        private void btn_food_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            QL_Food food = new QL_Food();

            CreateForm(food,null);
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
            Fm_Add fm_Add = new Fm_Add();
            fm_Add.ShowDialog();
        }

        private void btn_staff_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Fm_Staff staff = new Fm_Staff();
            CreateForm(staff, null);
        }

        private void btn_category_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Fm_category Category = new Fm_category();
            CreateForm(Category, null);
        }
    }
}
