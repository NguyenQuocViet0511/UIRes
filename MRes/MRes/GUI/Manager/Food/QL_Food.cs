using MRes.DAL.API.Food;
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
        Item_Food item_food;
        public QL_Food()
        {
            InitializeComponent();
            GetData();


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

                    });
                }
                );
            t.Start();

        }

        private void ClearandAdd()
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
            cbn_category.DataBindings.Clear();
            cbn_category.DataBindings.Add("text", food.data.data, "category");
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
    }
}
