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
        private string Images;
        private string Status;
        private string Category;
        private string Username;

        public Food()
        {

        }
        public Food(string id, string name, double price, double discount, int count, string images, bool status,string Status, string Created_by, string category_name)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Discount = discount;
            this.count = count;
            this.images = images;
            this.Status = Status;
            this.Username = Created_by;
            this.Category = category_name;
        }

        public string id { get => ID; set => ID = value; }
        public string name { get => Name; set => Name = value; }
        public double price { get => Price; set => Price = value; }
        public double discount { get => Discount; set => Discount = value; }
        public int count { get => Count; set => Count = value; }
        public string status { get => Status; set => Status = value; }
        public string images { get => Images; set => Images = value; }
        public string username { get => Username; set => Username = value; }
        public string category { get => Category; set => Category = value; }
    }
}
