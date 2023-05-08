using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRes.GUI.Manager.Food
{
    public partial class Item_Food : UserControl
    {
        private string id;
        private string name;
        private string price;
        private string discount;
        private string count;
        private string name_category;
        public Item_Food()
        {
            InitializeComponent();
        }

        public string Id { get => txt_id.Text; set => txt_id.Text = value; }
        public string Name1 { get => txt_name.Text; set => txt_name.Text = value; }
        public string Price
        {
            get => txt_price.Text; 
            set
            {
                txt_price.Text = value;
            }
        }
        public string Discount { get => txt_discount.Text; set => txt_discount.Text = value; }
        public string Count { get => txt_count.Text ; set =>txt_count.Text = value; }
        public string Name_category { get => txt_namecategory.Text; set => txt_namecategory.Text = value; }
    }
}
