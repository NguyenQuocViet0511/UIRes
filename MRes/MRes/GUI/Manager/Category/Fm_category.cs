using MRes.DAL.API.Category;
using MRes.Models.Category;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRes.GUI.Manager.Category
{
    public partial class Fm_category : Form
    {
        CategoryData category;

        public Fm_category()
        {
            InitializeComponent();
            GetData();

            init();

        }


        // add intit
        private void init()
        {
            setPanel(false);
        }
        // set panel 
        public void setPanel(bool check)
        {
            panel_info.Enabled = check;
        }
        //get data
        public void GetData()
        {
            Task t = new Task(
                () =>
                {

                    category = APICategory.Instance.GetAll();
                    gridController.BeginInvoke((Action)delegate ()
                    {
                        gridController.DataSource = category.data.data;
                        ClearandAdd();

                    });
                }
                );
            t.Start();
        }
        // clear

        public void ClearandAdd()
        {
            txt_id.DataBindings.Clear();
            txt_id.DataBindings.Add("text", category.data.data, "id");
            //
            txt_name.DataBindings.Clear();
            txt_name.DataBindings.Add("text", category.data.data, "name");
            //
            txt_count.DataBindings.Clear();
            txt_count.DataBindings.Add("text", category.data.data, "count");
            //
            cbn_status.DataBindings.Clear();
            cbn_status.DataBindings.Add("text", category.data.data, "status");
            //
          
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            this.BindingContext[category.data.data].Position = 0;

        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            this.BindingContext[category.data.data].Position--;

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.BindingContext[category.data.data].Position++;

        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            int location = this.BindingContext[category.data.data].Count - 1;
            this.BindingContext[category.data.data].Position = location;
        }
        //clear
        public void Cleartext()
        {
            txt_name.Text = "";
            txt_id.Text = "mã tự động tăng";
            cbn_status.Text = "";
            //
            txt_id.DataBindings.Clear();
            //
            txt_name.DataBindings.Clear();
            //
            cbn_status.DataBindings.Clear();
            //
            txt_count.DataBindings.Clear();
            //
 

        }
        //check empty
        public bool check()
        {
       
            if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(cbn_status.Text) )
            {
                return false;

            }
            return true;
        }
        //create new 
        public void Add()
        {

            Task add = new Task(
                        () =>
                        {
                            String result = APICategory.Instance.Add(txt_name.Text, cbn_status.Text,"US000000");
                            panel_info.BeginInvoke((Action)delegate ()
                            {
                                setPanel(false);
                            });
                            GetData();
                            MessageBox.Show("" + result);
                        }
                        );
            add.Start();

        }
        //delete
        public void delete()
        {

            Task delete = new Task(
             () =>
             {
                 String result = APICategory.Instance.delete(txt_id.Text);
                 GetData();
                 MessageBox.Show("" + result);

             }
             );
            delete.Start();
        }
        //edit
        public void edit()
        {

            Task edit = new Task(
             () =>
             {
                 String result = APICategory.Instance.Edit(txt_id.Text, txt_name.Text, cbn_status.Text,txt_count.Text);
                 GetData();
                 MessageBox.Show("" + result);

             }
             );
            edit.Start();
        }
    }
}
