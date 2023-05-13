using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRes.Models.MaterialBillInfo
{
   public class MaterialBillInfo
    {
        private string ID;
        private string Id_materialbill;
        private string Name;
        private int Count;
        private string Price;
        private double Sum;
        private string Status;




        public MaterialBillInfo()
        {

        }

        public MaterialBillInfo(string ID,string Id_bill, string Name,int Count,string Price,double Sum)
        {
            this.ID = ID;
            this.Id_materialbill = Id_bill;
            this.Name = Name;
            this.Count = Count;
            this.Price = Price;
            this.Sum = Sum;


        }

        public string id { get => ID; set => ID = value; }
        public string id_materialbill { get => Id_materialbill; set => Id_materialbill = value; }
        public string name { get => Name; set => Name = value; }
        public int count { get => Count; set => Count = value; }
        public string price { get => Price; set => Price = value; }
        public double sum { get => Sum; set => Sum = value; }
        public string status { get => Status; set => Status = value; }
    }
}
