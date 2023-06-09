﻿using MRes.Models.Food;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRes.DAL.API.Food
{
    class APIFood
    {
        private static APIFood instance;

        public static APIFood Instance
        {
            get
            {
                if (instance == null)
                    instance = new APIFood();
                return instance;

            }
            set => instance = value;
        }

        bool Clickadd = true;
        bool Clickedit = true;
        public bool ClickAdd { get => Clickadd; set => Clickadd = value; }
        public bool ClickEdit { get => Clickedit; set => Clickedit = value; }




        public  FoodData GetAll()
        {
            string Result = BaseAPI.Instance.Get(Const.URL + "food/list");
            if (Result == null)
            {
                return null;
            }
            FoodData data = JsonConvert.DeserializeObject<FoodData>(Result);
            return data;
        }
        public string Add(string name, double price, string discount,string status,string created_by, string id_category,string image)
        {
            NameValueCollection table = new NameValueCollection();
            table["name"] = name;
            table["price"] = price.ToString();
            table["discount"] = discount;
            table["status"] = status;
            table["image"] = image;
            table["created_by"] = created_by;
            table["id_category"] = id_category;
            string Result = BaseAPI.Instance.All(Const.URL + "food/create", table, "POST");
            return Result;
        }
        public String Edit(string id, string name, double price, string discount, string status, string created_by, string id_category, string image)
        {
            if(string.IsNullOrEmpty(image))
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
            else
            {
                NameValueCollection table = new NameValueCollection();
                table["id"] = id;
                table["name"] = name;
                table["image"] = image;
                table["price"] = price.ToString();
                table["discount"] = discount;
                table["status"] = status;
                table["created_by"] = created_by;
                table["id_category"] = id_category;
                string Result = BaseAPI.Instance.All(Const.URL + "food/update", table, "POST");
                return Result;
            }
     
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

