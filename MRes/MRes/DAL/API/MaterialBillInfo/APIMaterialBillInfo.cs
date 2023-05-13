using MRes.Models.MaterialBillInfo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRes.DAL.API.MaterialBillInfo
{
    class APIMaterialBillInfo
    {
        MaterialBillInfoData MaterialBillInfoData;
        private static APIMaterialBillInfo instance;

        public static APIMaterialBillInfo Instance
        {
            get
            {
                if (instance == null)
                    instance = new APIMaterialBillInfo();
                return instance;

            }
            set => instance = value;
        }

        bool Clickadd = true;
        bool Clickedit = true;
        public bool ClickAdd { get => Clickadd; set => Clickadd = value; }
        public bool ClickEdit { get => Clickedit; set => Clickedit = value; }




        public MaterialBillInfoData GetAll()
        {
            string Result = BaseAPI.Instance.Get(Const.URL + "materialbillinfo/list");
            if (Result == null)
            {
                return null;
            }
            MaterialBillInfoData data = JsonConvert.DeserializeObject<MaterialBillInfoData>(Result);
            return data;
        }
        public MaterialBillInfoData GetBillInfo(string id_bill)
        {
            NameValueCollection table = new NameValueCollection();
            table["id_bill"] = id_bill;
            string Result = BaseAPI.Instance.All(Const.URL + "materialbillinfo/show", table, "POST");
            if (Result == null)
            {
                return null;
            }
            MaterialBillInfoData data = JsonConvert.DeserializeObject<MaterialBillInfoData>(Result);
            return data;

        }

        public string CreateOrUpdate(string id_material, string id_material_bill, string count, string countout , string created_by)
        {
            NameValueCollection table = new NameValueCollection();
            table["id_material"] = id_material;
            table["id_material_bill"] = id_material_bill;
            table["count"] = count;
            table["countout"] = countout;
            table["id_user"] = created_by;
            string Result = BaseAPI.Instance.All(Const.URL + "materialbillinfo/CreateOrUpdate", table, "POST");
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
            string Result = BaseAPI.Instance.All(Const.URL + "materialbillinfo/update", table, "POST");
            return Result;
        }

        public string delete(string id, string id_materialbill)
        {
            NameValueCollection table = new NameValueCollection();
            table["id"] = id;
            table["id_materialbill"] = id_materialbill;
            string Result = BaseAPI.Instance.All(Const.URL + "materialbillinfo/delete", table, "POST");
            return Result;
        }
    }
}
