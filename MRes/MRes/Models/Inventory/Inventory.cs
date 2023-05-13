using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRes.Models.Inventory
{
    public class Inventory
    {
        private string ID;
        private string Name;
        private double Quantity;



        public Inventory()
        {

        }
        public Inventory(string id,  string name, double Quantity)
        {
            this.ID = id;
            this.Name = name;
            this.Quantity = Quantity;
   



        }

        public string id { get => ID; set => ID = value; }
        public string name { get => Name; set => Name = value; }
        public double quantity { get => Quantity; set => Quantity = value; }
    }
}
