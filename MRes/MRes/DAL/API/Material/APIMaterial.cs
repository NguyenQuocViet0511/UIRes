using MRes.Models.Material;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRes.DAL.API.Material
{
    class APIMaterial
    {
        private static APIMaterial instance;

        public static APIMaterial Instance
        {
            get
            {
                if (instance == null)
                    instance = new APIMaterial();
                return instance;

            }
            set => instance = value;
        }

        bool Clickadd = true;
        bool Clickedit = true;
        public bool ClickAdd { get => Clickadd; set => Clickadd = value; }
        public bool ClickEdit { get => Clickedit; set => Clickedit = value; }




        public MaterialData GetAll()
        {
            string Result = BaseAPI.Instance.Get(Const.URL + "material/list");
            if (Result == null)
            {
                return null;
            }
            MaterialData data = JsonConvert.DeserializeObject<MaterialData>(Result);
            return data;
        }
        public MaterialData GetByStatus()
        {
            string Result = BaseAPI.Instance.Get(Const.URL + "material/GetByStatus");
            if (Result == null)
            {
                return null;
            }
            MaterialData data = JsonConvert.DeserializeObject<MaterialData>(Result);
            return data;
        }
    
        public string Add(string name, double price, string unit, string status, string created_by)
        {
            NameValueCollection table = new NameValueCollection();
            table["name"] = name;
            table["price"] = price.ToString();
            table["unit"] = unit;
            table["status"] = status;
            table["created_by"] = created_by;
            string Result = BaseAPI.Instance.All(Const.URL + "material/create", table, "POST");
                return Result;
            }
        public string update(string id,string name, double price, string unit, string status)
        {
            NameValueCollection table = new NameValueCollection();
            table["id"] = id;
            table["name"] = name;
            table["price"] = price.ToString();
            table["unit"] = unit;
            table["status"] = status;
            string Result = BaseAPI.Instance.All(Const.URL + "material/update", table, "POST");
            return Result;
        }
        public string delete(string id)
        {
            NameValueCollection table = new NameValueCollection();
            table["id"] = id;
            string Result = BaseAPI.Instance.All(Const.URL + "material/delete", table, "POST");
            return Result;
        }
    }
}
