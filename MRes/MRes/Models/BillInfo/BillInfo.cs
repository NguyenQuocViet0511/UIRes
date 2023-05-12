using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRes.Models.BillInfo
{
   public class BillInfo
    {
        private string ID;
        private string Id_Bill;
        private int Count;
        private double Sum;
        private string Note;
        private string Status;
        private string Billstatus;
        private string Foodname;
        private string Foodprice;
        private string Timein;
        private double Sumpay;


        public BillInfo()
        {

        }
        public BillInfo(string id, string id_bill, int count, double sum, string note, string billstatus, string foodname,string foodprice ,string status,string timein)
        {
            this.ID = id;
            this.Id_Bill = id_bill;
            this.count = count;
            this.Sum = sum;
            this.Note = note;
            this.Billstatus = billstatus;
            this.Foodname = foodname;
            this.Foodprice = foodprice;
            this.Status = status;
            this.Timein = timein;






        }

        public string id { get => ID; set => ID = value; }
        public string id_bill { get => Id_Bill; set => Id_Bill = value; }
        public int count { get => Count; set => Count = value; }
        public double sum { get => Sum; set => Sum = value; }
        public string note { get => Note; set => Note = value; }
        public string billstatus { get => Billstatus; set => Billstatus = value; }
        public string foodname { get => Foodname; set => Foodname = value; }
        public string foodprice { get => Foodprice; set => Foodprice = value; }
        public string status { get => Status; set => Status = value; }
        public string timein { get => Timein; set => Timein = value; }
        public double sumpay { get => Sumpay; set => Sumpay = value; }
    }
}
