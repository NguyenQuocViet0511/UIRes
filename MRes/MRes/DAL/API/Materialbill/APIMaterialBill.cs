using MRes.Models.MaterialBill;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRes.DAL.API.Materialbill
{
    class APIMaterialBill
    {
        MaterialBillData MaterialBillData;
        private static APIMaterialBill instance;

        public static APIMaterialBill Instance
        {
            get
            {
                if (instance == null)
                    instance = new APIMaterialBill();
                return instance;

            }
            set => instance = value;
        }

        bool Clickadd = true;
        bool Clickedit = true;
        public bool ClickAdd { get => Clickadd; set => Clickadd = value; }
        public bool ClickEdit { get => Clickedit; set => Clickedit = value; }




        public MaterialBillData GetAll()
        {
            string Result = BaseAPI.Instance.Get(Const.URL + "materialbill/list");
            if (Result == null)
            {
                return null;
            }
            MaterialBillData data = JsonConvert.DeserializeObject<MaterialBillData>(Result);
            return data;
        }
        public MaterialBillData GetByStatus()
        {
            string Result = BaseAPI.Instance.Get(Const.URL + "materialbill/Show");
            if (Result == null)
            {
                return null;
            }
            MaterialBillData data = JsonConvert.DeserializeObject<MaterialBillData>(Result);
            return data;
        }

        public string Add(string status, string created_by)
        {
            NameValueCollection table = new NameValueCollection();
            table["status"] = status;
            table["id_user"] = created_by;
            string Result = BaseAPI.Instance.All(Const.URL + "materialbill/create", table, "POST");
            return Result;
        }
        public string update(string id, string name, double price, string unit, string status)
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
