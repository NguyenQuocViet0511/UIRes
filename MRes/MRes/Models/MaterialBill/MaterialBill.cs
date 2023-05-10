using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRes.Models.MaterialBill
{
   public class MaterialBill
    {
        private string ID;
        private string Timein;
        private string Timeout;
        private double Sum;
        private string Status;
        private string Created_by;


        public MaterialBill()
        {

        }
        public MaterialBill(string id, string tiemin, string timeout, double sum, string Status, string Created_by )
        {
            this.ID = id;
            this.Timein = tiemin;
            this.Timeout = timeout;
            this.Sum = sum;
            this.Status = Status;
            this.Created_by = Created_by;



        }

        public string id { get => ID; set => ID = value; }
        public string timein { get => Timein; set => Timein = value; }
        public string tiemout { get => Timeout; set => Timeout = value; }
        public double sum { get => Sum; set => Sum = value; }
        public string status { get => Status; set => Status = value; }
        public string created_by { get => Created_by; set => Created_by = value; }

    }
}
