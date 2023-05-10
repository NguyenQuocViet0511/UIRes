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
        public CategoryData GetByStatus()
        {
            string Result = BaseAPI.Instance.Get(Const.URL + "category/GetByStatus");
            if (Result == null)
            {
                return null;
            }
            CategoryData data = JsonConvert.DeserializeObject<CategoryData>(Result);
            return data;
        }
        public String Add(string name, string status,string created_by)
        {
            NameValueCollection table = new NameValueCollection();
            table["name"] = name;        
            table["status"] = status;
            table["created_by"] = created_by;
            string Result = BaseAPI.Instance.All(Const.URL + "category/create", table, "POST");
            return Result;
        }
        public String Edit(string id, string name, string status, string count)
        {
            NameValueCollection table = new NameValueCollection();
            table["id"] = id;
            table["name"] = name;
            table["status"] = status;
            table["count"] = count;
            string Result = BaseAPI.Instance.All(Const.URL + "category/update", table, "POST");
            return Result;
        }
        public string delete(string id)
        {
            NameValueCollection table = new NameValueCollection();
            table["id"] = id;
            string Result = BaseAPI.Instance.All(Const.URL + "category/delete", table, "POST");
            return Result;
        }
    }
}
