using MRes.DAL.API.Category;
using MRes.DAL.API.Food;
using MRes.Models.Category;
using MRes.Models.Food;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRes.GUI.Manager.Food
{
    public partial class QL_Food : Form
    {    
        FoodData food;
        CategoryData category;
        Item_Food item_food;
        public QL_Food()
        {
            InitializeComponent();
            GetData();
            GetCategory();
            init();


        }

        private void init()
        {
            setPanel(false);
        }

        public void setPanel(bool check)
        {
            if(check == false)
            {
                panel_info.Enabled = false;
            }
            if(check == true)
            {
                panel_info.Enabled = true;

            }
        }
        public  void GetData()
        {
            Task t = new Task(
                () =>
                {
                    food = APIFood.Instance.GetAll();

                    gridController.BeginInvoke((Action)delegate ()
                    {
                        gridController.DataSource = food.data.data;
                        ClearandAdd();
                        setPanel(false);

                    });
                }
                );
            t.Start();
          
        }
        public void GetCategory()
        {
            Task t1 = new Task(
             () =>
             {
                 category = APICategory.Instance.GetAll();
                 cbn_category.BeginInvoke((Action)delegate ()
                 {
                     cbn_category.Properties.DisplayMember = "name";
                     cbn_category.Properties.ValueMember = "id";
                     cbn_category.Properties.DataSource = category.data.data;

                 });

             }
             );
            t1.Start();
        }

        public void ClearandAdd()
        {
            txt_id.DataBindings.Clear();
            txt_id.DataBindings.Add("text", food.data.data, "id");
            //
            txt_name.DataBindings.Clear();
            txt_name.DataBindings.Add("text", food.data.data, "name");
            //
            txt_count.DataBindings.Clear();
            txt_count.DataBindings.Add("text", food.data.data, "count");
            //
            txt_created_by.DataBindings.Clear();
            txt_created_by.DataBindings.Add("text", food.data.data, "username");
            //
            txt_discount.DataBindings.Clear();
            txt_discount.DataBindings.Add("text", food.data.data, "discount");
            //
            txt_price.DataBindings.Clear();
            txt_price.DataBindings.Add("text", food.data.data, "price");
            //
            cbn_status.DataBindings.Clear();
            cbn_status.DataBindings.Add("text", food.data.data, "status");
            //
            this.cbn_category.DataBindings.Clear();
            this.cbn_category.DataBindings.Add("EditValue", food.data.data, "id_category");
            //

        }
        private void QL_Food_Load(object sender, EventArgs e)
        {
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            this.BindingContext[food.data.data].Position = 0;
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            this.BindingContext[food.data.data].Position--;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.BindingContext[food.data.data].Position++;
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            int location = this.BindingContext[food.data.data].Count - 1;
            this.BindingContext[food.data.data].Position = location;
        }

        public void Cleartext()
        {
            txt_count.Text = "";
            txt_discount.Text = "";
            txt_id.Text = "mã tự động tăng";
            txt_name.Text = "";
            txt_price.Text = "";
            txt_created_by.Text = "";
            txt_id.DataBindings.Clear();
            //
            txt_name.DataBindings.Clear();
            //
            txt_count.DataBindings.Clear();
            //
            txt_created_by.DataBindings.Clear();
            //
            txt_discount.DataBindings.Clear();
            //
            txt_price.DataBindings.Clear();
            //
            cbn_status.DataBindings.Clear();
            //
            this.cbn_category.DataBindings.Clear();

        }
        public void Add()
        {

            Task add = new Task(
             () =>
             {
                 String result = APIFood.Instance.Add(txt_name.Text, Convert.ToDouble(txt_price.Text), txt_discount.Text.ToString(), cbn_status.Text, "US000000", cbn_category.EditValue.ToString());
                 setPanel(false);
                 GetData();
                 MessageBox.Show("" + result);
             }
             );
            add.Start();
        }
        public void delete()
        {

            Task delete = new Task(
             () =>
             {
                 String result = APIFood.Instance.delete(txt_id.Text);
                 GetData();
                 MessageBox.Show("" + result);

             }
             );
            delete.Start();
        }
    }
}
