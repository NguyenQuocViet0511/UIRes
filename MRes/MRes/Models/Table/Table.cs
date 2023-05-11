using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRes.Models.Table
{
   public class Table
    {
        private string ID;
        private string Name;
        private string Status;
        private string Id_bill;
        private string Created_by;


        public Table()
        {

        }
        public Table(string id, string Name, string Status, string Id_bill, string Created_by )
        {
            this.ID = id;
            this.Name = Name;
            this.Status = Status;
            this.Id_bill = Id_bill;
            this.Status = Status;
            this.Created_by = Created_by;



        }

        public string id { get => ID; set => ID = value; }
        public string name { get => Name; set => Name = value; }
        public string status { get => Status; set => Status = value; }
        public string id_bill { get => Id_bill; set => Id_bill = value; }
        public string created_by { get => Created_by; set => Created_by = value; }

    }
}
