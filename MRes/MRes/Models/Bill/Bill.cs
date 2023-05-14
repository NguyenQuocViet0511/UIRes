using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRes.Models.Bill
{
   public class Bill
    {
        private string ID;
        private double Sum;
        private string Timein;



        public Bill()
        {

        }
        public Bill(string id, double sum,string timein)
        {
            this.ID = id;
            this.Sum = sum;
            this.Timein = timein;






        }

        public string id { get => ID; set => ID = value; }
        public double sum { get => Sum; set => Sum = value; }
        public string  timein { get => Timein; set => Timein = value; }


    }
}
