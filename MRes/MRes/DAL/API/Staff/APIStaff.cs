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
        public async Task<string> Add(string name, string price, string discount, string id_category)
        {
            NameValueCollection table = new NameValueCollection();
            table["name"] = name;
            table["price"] = price;
            table["discount"] = discount;
            table["count"] = "0";
            table["id_category"] = id_category;
            string Result = BaseAPI.Instance.All(Const.URL + "food/create", table, "POST");
            return Result;
        }
        public String Edit(string id, string name, string price, string discount, string id_category)
        {
            NameValueCollection table = new NameValueCollection();
            table["id"] = id;
            table["name"] = name;
            table["price"] = price;
            table["discount"] = discount;
            table["id_category"] = id_category;
            string Result = BaseAPI.Instance.All(Const.URL + "food/update", table, "POST");
            return Result;
        }
        public string delete(string id)
        {
            NameValueCollection table = new NameValueCollection();
            table["id"] = id;
            string Result = BaseAPI.Instance.All(Const.URL + "food/delete", table, "POST");
            return Result;
        }
    }
}
