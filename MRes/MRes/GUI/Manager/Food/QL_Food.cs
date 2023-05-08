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
        DataTable dt;
        ThreadStart ts;
        Thread th;
        Item_Food item_food;
        public QL_Food()
        {
            InitializeComponent();

            //ts = new ThreadStart(GetData);
            //th = new Thread(ts);
            //th.Start();
            GetData();
        }
    
      



   


        private void GetData()
        { 
            layoutController.Controls.Clear();
            food =  APIFood.Instance.GetAll();
            foreach (var item in food.data.data)
            {
                item_food = new Item_Food();
                item_food.Width = 220;
                item_food.Height = 270;
                item_food.Id = item.id;
                item_food.Name = item.name;
                item_food.Price = string.Format("{0:0,0}", item.price);
                item_food.Discount = item.discount.ToString();
                item_food.Count = item.count.ToString();
                item_food.Name_category = item.Category_name;
                layoutController.Controls.Add(item_food);
            }
        
        }

    }
}
