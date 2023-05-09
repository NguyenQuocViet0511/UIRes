using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRes.Models.Staff
{
   public class Staff
    {
        private string ID;
        private string Name;
        private string Username;
        private string Email;
        private string Date;
        private string Sex;
        private string Number;
        private string Address;
        private string Status;
        private string Id_role;

        public Staff()
        {

        }
        public Staff(string id, string name, string username, string email, string date,string sex, string number, string address, string status, string id_role)
        {
            this.ID = id;
            this.Name = name;
            this.Username = username;
            this.Email = email;
            this.Date = date;
            this.Sex = sex;
            this.Number = number;
            this.Address = address;
            this.Status = status;
            this.Id_role = id_role;
       
        }

        public string id { get => ID; set => ID = value; }
        public string name { get => Name; set => Name = value; }
        public string username { get => Username; set => Username = value; }
        public string email { get => Email; set => Email = value; }
        public string date { get => Date; set => Date = value; }
        public string sex { get => Sex; set => Sex = value; }
        public string number { get => Number; set => Number = value; }
        public string address { get => Address; set => Address = value; }
        public string status { get => Status; set => Status = value; }
        public string id_role { get => Id_role; set => Id_role = value; }
    }
}
