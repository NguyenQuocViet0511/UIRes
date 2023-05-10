using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRes.Models.Role
{
    public class Role
    {
        private string ID;
        private string Name;
        private string Status;
      

        public Role()
        {

        }
        public Role(string id, string name,string Status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = Status;
      
        }

        public string id { get => ID; set => ID = value; }
        public string name { get => Name; set => Name = value; }
        public string status { get => Status; set => Status = value; }
  
    }
}
