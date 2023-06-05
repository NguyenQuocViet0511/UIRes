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
        private string Timeout;
        private string Status;




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
        public string timeout { get => Timeout; set => Timeout = value; }
        public string status { get => Status; set => Status = value; }
    }
}
