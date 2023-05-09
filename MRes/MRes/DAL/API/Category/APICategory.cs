using MRes.Models.Category;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRes.DAL.API.Category
{
    class APICategory
    {
        private static APICategory instance;

        public static APICategory Instance
        {
            get
            {
                if (instance == null)
                    instance = new APICategory();
                return instance;

            }
            set => instance = value;
        }

        bool Clickadd = true;
        bool Clickedit = true;
        public bool ClickAdd { get => Clickadd; set => Clickadd = value; }
        public bool ClickEdit { get => Clickedit; set => Clickedit = value; }




        public CategoryData GetAll()
        {
            string Result = BaseAPI.Instance.Get(Const.URL + "category/list");
            if (Result == null)
            {
                return null;
            }
            CategoryData data = JsonConvert.DeserializeObject<CategoryData>(Result);
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
