using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRes.Models.Material
{
   public class Material
    {
        private string ID;
        private string Name;
        private double Price;
        private string Unit;
        private string Status;
        private string Created_by;


        public Material()
        {

        }
        public Material(string id, string name, double price, string unit,string Status, string Created_by )
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Unit = unit;
            this.Status = Status;
            this.Created_by = Created_by;



        }

        public string id { get => ID; set => ID = value; }
        public string name { get => Name; set => Name = value; }
        public double price { get => Price; set => Price = value; }
        public string unit { get => Unit; set => Unit = value; }
        public string status { get => Status; set => Status = value; }
        public string created_by { get => Created_by; set => Created_by = value; }

    }
}
