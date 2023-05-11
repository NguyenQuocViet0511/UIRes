﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRes.DAL.API.Bill
{
    class APIBill
    {
        private static APIBill instance;

        public static APIBill Instance
        {
            get
            {
                if (instance == null)
                    instance = new APIBill();
                return instance;

            }
            set => instance = value;
        }

        bool Clickadd = true;
        bool Clickedit = true;
        public bool ClickAdd { get => Clickadd; set => Clickadd = value; }
        public bool ClickEdit { get => Clickedit; set => Clickedit = value; }




        public APIBill GetAll()
        {
            string Result = BaseAPI.Instance.Get(Const.URL + "food/list");
            if (Result == null)
            {
                return null;
            }
            APIBill data = JsonConvert.DeserializeObject<APIBill>(Result);
            return data;
        }
        public string Add(string name, double price, string discount, string status, string created_by, string id_category)
        {
            NameValueCollection table = new NameValueCollection();
            table["name"] = name;
            table["price"] = price.ToString();
            table["discount"] = discount;
            table["status"] = status;
            table["created_by"] = created_by;
            table["id_category"] = id_category;
            string Result = BaseAPI.Instance.All(Const.URL + "food/create", table, "POST");
            return Result;
        }
        public String Edit(string id, string name, double price, string discount, string status, string created_by, string id_category)
        {
            NameValueCollection table = new NameValueCollection();
            table["id"] = id;
            table["name"] = name;
            table["price"] = price.ToString();
            table["discount"] = discount;
            table["status"] = status;
            table["created_by"] = created_by;
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