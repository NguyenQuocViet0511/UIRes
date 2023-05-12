using MRes.Models.BillInfo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRes.DAL.API.BillInfo
{
    class APIBillInfo
    {
        private static APIBillInfo instance;

        public static APIBillInfo Instance
        {
            get
            {
                if (instance == null)
                    instance = new APIBillInfo();
                return instance;

            }
            set => instance = value;
        }

        bool Clickadd = true;
        bool Clickedit = true;
        public bool ClickAdd { get => Clickadd; set => Clickadd = value; }
        public bool ClickEdit { get => Clickedit; set => Clickedit = value; }




        public APIBillInfo GetAll()
        {
            string Result = BaseAPI.Instance.Get(Const.URL + "BillInfo/list");
            if (Result == null)
            {
                return null;
            }
            APIBillInfo data = JsonConvert.DeserializeObject<APIBillInfo>(Result);
            return data;
        }
        public string CreateOrUpdate(string id,string idtalbe ,string id_bill, int count,string note,string id_user)
        {
            NameValueCollection table = new NameValueCollection();
            table["id"] = id;
            table["id_bill"] = id_bill;
            table["idTable"] = idtalbe;
            table["count"] = count.ToString();
            table["id_user"] = id_user;
            table["note"] = note;
            string Result = BaseAPI.Instance.All(Const.URL + "BillInfo/CreateOrUpdate", table, "POST");
            return Result;
        }
        public BillInfoData GetBillInfo(string id_bill,string id_table)
        {
            NameValueCollection table = new NameValueCollection();
            table["id_bill"] = id_bill;
            table["id_table"] = id_table;

            string Result = BaseAPI.Instance.All(Const.URL + "BillInfo/show", table, "POST");
            if (Result == null)
            {
                return null;
            }
            BillInfoData data = JsonConvert.DeserializeObject<BillInfoData>(Result);
            return data;

        }

        public string delete(string id, string id_bill,string id_table)
        {
            NameValueCollection table = new NameValueCollection();
            table["id"] = id;
            table["id_bill"] = id_bill;
            table["id_table"] = id_table;
            string Result = BaseAPI.Instance.All(Const.URL + "BillInfo/delete", table, "POST");
            return Result;
        }

        public string SendCook(string id, string id_bill, string id_table)
        {
            NameValueCollection table = new NameValueCollection();
            table["id"] = id;
            table["id_bill"] = id_bill;
            table["id_table"] = id_table;
            string Result = BaseAPI.Instance.All(Const.URL + "BillInfo/update", table, "POST");
            return Result;
        }
    }
}
