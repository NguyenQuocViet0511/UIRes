﻿using MRes.DAL;
using MRes.DAL.API.Category;
using MRes.DAL.API.Food;
using MRes.Models.Category;
using MRes.Models.Food;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRes.GUI.Manager.Food
{
    public partial class QL_Food : Form
    {
    
        bool enable = false;
        TextBox TextBox = new TextBox();
        FoodData food;
        CategoryData category;
        static string url = "";

        Item_Food item_food;
        public QL_Food()
        {
            InitializeComponent();
            GetData();
            GetCategory();
            init();
            //var request = WebRequest.Create("http://www.gravatar.com/avatar/6810d91caff032b202c50701dd3af745?d=identicon&r=PG");

            //using (var response = request.GetResponse())
            //using (var stream = response.GetResponseStream())
            //{
          


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
        public  void GetData()
        {
            Task t = new Task(
                () =>
                {
                    food = APIFood.Instance.GetAll();

                    gridController.BeginInvoke((Action)delegate ()
                    {
                        if(food != null)
                        {
                            gridController.DataSource = food.data.data;
                            ClearandAdd();
                        }
                     

                    });
                }
                );
            t.Start();
          
        }
        public void GetDataafter()
        {
            Task t = new Task(
                () =>
                {
                    food = APIFood.Instance.GetAll();

                    gridController.BeginInvoke((Action)delegate ()
                    {
                        if (food != null)
                        {
                            gridController.DataSource = food.data.data;
                        }


                    });
                }
                );
            t.Start();

        }
        //get category
        public void GetCategory()
        {
            Task t1 = new Task(
             () =>
             {
                 category = APICategory.Instance.GetByStatus();
                 cbn_category.BeginInvoke((Action)delegate ()
                 {
                     if(category != null)
                     {
                     cbn_category.Properties.DisplayMember = "name";
                     cbn_category.Properties.ValueMember = "id";
                     cbn_category.Properties.DataSource = category.data.data;
                     }
                     

                 });

             }
             );
            t1.Start();
        }

        //clearbingding
        public void ClearandAdd()
        {
            if(food != null)
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
                cbn_statuscategory.DataBindings.Clear();
                cbn_statuscategory.DataBindings.Add("text", food.data.data, "category_status");
                //
                this.cbn_category.DataBindings.Clear();
                this.cbn_category.DataBindings.Add("EditValue", food.data.data, "id_category");


                txt_image.DataBindings.Clear();
                txt_image.DataBindings.Add("text", food.data.data, "image");

                if (!string.IsNullOrEmpty(txt_image.Text))
                {
                    pictureEdit1.Image = Const.Base64ToImage(txt_image.Text);

                }
            }

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
        //cleartext
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

            pictureEdit1.Image = null;

        }
        //check empty
        public bool check()
        {
            if(string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_discount.Text) || string.IsNullOrEmpty(txt_price.Text) || string.IsNullOrEmpty(txt_discount.Text) || string.IsNullOrEmpty(cbn_status.Text) || string.IsNullOrEmpty(cbn_category.Text))
            {
                return false;

            }
            return true;
        }
        //create new 
        public void  Add()
        {
         
                Task add = new Task(
                            () =>
                            {
                                String result = APIFood.Instance.Add(txt_name.Text, Convert.ToDouble(txt_price.Text), txt_discount.Text.ToString(), cbn_status.Text, Const.staff.id, cbn_category.EditValue.ToString(), url);
                                panel_info.BeginInvoke((Action)delegate ()
                                {
                                    Cleartext();
                                });
                                GetDataafter();
                                url = "";
                                MessageBox.Show("" + result);
                            }
                            );
                add.Start();
          
        }
        // delete
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
        //edit
        public void edit()
        {

            Task edit = new Task(
             () =>
             {
                 
                     String result = APIFood.Instance.Edit(txt_id.Text, txt_name.Text, Convert.ToDouble(txt_price.Text), txt_discount.Text.ToString(), cbn_status.Text, Const.staff.id, cbn_category.EditValue.ToString(), url);
                     GetData();
                     url = "";
                 MessageBox.Show("" + result);
                 
             
               

             }
             );
            edit.Start();
        }


       

        private void gridController_Click(object sender, EventArgs e)
        {
            Task t = new Task(() =>
            {
                if (!string.IsNullOrEmpty(txt_image.Text))
                {
                    pictureEdit1.Image = Const.Base64ToImage(txt_image.Text);

                }
                else
                {
                    pictureEdit1.Image = null;
                }

            });
            t.Start();

        }

        private void pictureEdit1_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = openFileDialog.Filter = "JPG files (*.Jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                url = Const.GetStringFromImage(new Bitmap(openFileDialog.FileName));
                pictureEdit1.Image = new Bitmap(openFileDialog.FileName);
            }
        }
    }
}
