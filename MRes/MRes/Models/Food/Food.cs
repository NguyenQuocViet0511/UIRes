using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRes.Models.Food
{
   public class Food
    {
        private string ID;
        private string Name;
        private double Price;
        private double Discount;
        private int Count;
        private string Image;
        private string Status;
        private string Id_category;
        private string Category_status;
        private string Category;
        private string Username;

        public Food()
        {

        }
        public Food(string id, string name, double price, double discount, int count, string images, bool status,string Status, string id_Category,string category_status, string category_name, string Created_by )
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Discount = discount;
            this.count = count;
            this.Image = images;
            this.Status = Status;
            this.Id_category = id_Category;
            this.Category_status = category_status;
            this.Category = category_name;
            this.Username = Created_by;
          
        }

        public string id { get => ID; set => ID = value; }
        public string name { get => Name; set => Name = value; }
        public double price { get => Price; set => Price = value; }
        public double discount { get => Discount; set => Discount = value; }
        public int count { get => Count; set => Count = value; }
        public string status { get => Status; set => Status = value; }
        public string image{ get => Image; set => Image = value; }
        public string id_category { get => Id_category; set => Id_category = value; }
        public string username { get => Username; set => Username = value; }
        public string category { get => Category; set => Category = value; }
        public string category_status { get => Category_status; set => Category_status = value; }
    }
}
