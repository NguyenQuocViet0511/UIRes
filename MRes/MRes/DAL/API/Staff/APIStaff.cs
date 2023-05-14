using MRes.Models.Staff;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRes.DAL.API.Staff
{
    class APIStaff
    {
        private static APIStaff instance;

        public static APIStaff Instance
        {
            get
            {
                if (instance == null)
                    instance = new APIStaff();
                return instance;

            }
            set => instance = value;
        }

        bool Clickadd = true;
        bool Clickedit = true;
        public bool ClickAdd { get => Clickadd; set => Clickadd = value; }
        public bool ClickEdit { get => Clickedit; set => Clickedit = value; }




        public StaffData GetAll()
        {
            string Result = BaseAPI.Instance.Get(Const.URL + "users/list");
            if (Result == null)
            {
                return null;
            }
            StaffData data = JsonConvert.DeserializeObject<StaffData>(Result);
            return data;
        }
        public StaffData GetLogin(string username, string password)
        {
            NameValueCollection table = new NameValueCollection();
            table["username"] = username;
            table["password"] = password;
            string Result = BaseAPI.Instance.All(Const.URL + "users/login", table, "POST");
            StaffData data = JsonConvert.DeserializeObject<StaffData>(Result);
            return data;
        }
        public String Add(string name, string email,string sex, string status, string number, string id_role, string date,string address,string image)
        {
            NameValueCollection table = new NameValueCollection();
            table["name"] = name;
            table["email"] = email;
            table["sex"] = sex;
            table["status"] = status;
            table["number"] = number;
            table["image"] = image;
            table["address"] = address;
            table["id_role"] = id_role;
            table["date"] = date;
            string Result = BaseAPI.Instance.All(Const.URL + "users/create", table, "POST");
            return Result;
        }
        public String Edit(string id, string name,string email, string sex, string status, string number,string id_role,string date, string address, string image)
        {
            if(string.IsNullOrEmpty(image))
            {
                NameValueCollection table = new NameValueCollection();
                table["id"] = id;
                table["name"] = name;
                table["email"] = email;
                table["sex"] = sex;
                table["status"] = status;
                table["number"] = number;
                table["id_role"] = id_role;
                table["address"] = address;
                table["date"] = date;
                string Result = BaseAPI.Instance.All(Const.URL + "users/update", table, "POST");
                return Result;
            }  
            else
            {
                NameValueCollection table = new NameValueCollection();
                table["id"] = id;
                table["name"] = name;
                table["email"] = email;
                table["sex"] = sex;
                table["image"] = image;
                table["status"] = status;
                table["number"] = number;
                table["id_role"] = id_role;
                table["address"] = address;
                table["date"] = date;
                string Result = BaseAPI.Instance.All(Const.URL + "users/update", table, "POST");
                return Result;
            }    
           
        }
        public string delete(string id)
        {
            NameValueCollection table = new NameValueCollection();
            table["id"] = id;
            string Result = BaseAPI.Instance.All(Const.URL + "users/delete", table, "POST");
            return Result;
        }
    }
}
