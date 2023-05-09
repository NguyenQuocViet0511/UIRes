using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRes.Models.Category
{
    public class Category
    {
        private string ID;
        private string Name;
        private int Count;
        private string Status;
 

        public Category()
        {

        }
        public Category(string id, string name, int count, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Count = count;
            this.Status = status;
   
        }

        public string id { get => ID; set => ID = value; }
        public string name { get => Name; set => Name = value; }
        public int count { get => Count; set => Count = value; }
        public string status { get => Status; set => Status = value; }
    }
}
