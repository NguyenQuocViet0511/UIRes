using MRes.Models.Bill;
using Newtonsoft.Json;
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




        public BillData GetAll()
        {
            string Result = BaseAPI.Instance.Get(Const.URL + "bill/list");
            if (Result == null)
            {
                return null;
            }
            BillData data = JsonConvert.DeserializeObject<BillData>(Result);
            return data;
        }
        public BillData GetBillOut()
        {
            string Result = BaseAPI.Instance.Get(Const.URL + "bill/GetBillOut");
            if (Result == null)
            {
                return null;
            }
            BillData data = JsonConvert.DeserializeObject<BillData>(Result);
            return data;
        }
        public string Add(string created_by)
        {
            NameValueCollection table = new NameValueCollection();
            table["id_user"] = created_by;
            string Result = BaseAPI.Instance.All(Const.URL + "bill/create", table, "POST");
            return Result;
        }
        public String update(string id_table,string id_bill,double sum)
        {
            NameValueCollection table = new NameValueCollection();
            table["id_table"] = id_table;
            table["id_bill"] = id_bill;
            table["sum"] = sum.ToString();
            string Result = BaseAPI.Instance.All(Const.URL + "bill/update", table, "POST");
            return Result;
        }
        public string delete(string id)
        {
            NameValueCollection table = new NameValueCollection();
            table["id"] = id;
            string Result = BaseAPI.Instance.All(Const.URL + "bill/delete", table, "POST");
            return Result;
        }
        public BillData GetBill(string start, string end)
        {
            NameValueCollection table = new NameValueCollection();
            table["start"] = start;
            table["end"] = end;
            string Result = BaseAPI.Instance.All(Const.URL + "bill/GetStartAndEnd", table, "POST");
            if (Result == null)
            {
                return null;
            }
            BillData data = JsonConvert.DeserializeObject<BillData>(Result);
            return data;

        }
        public BillData GetBillByDate(string today)
        {
            NameValueCollection table = new NameValueCollection();
            table["today"] = today;
            string Result = BaseAPI.Instance.All(Const.URL + "bill/GetBillByDate", table, "POST");
            if (Result == null)
            {
                return null;
            }
            BillData data = JsonConvert.DeserializeObject<BillData>(Result);
            return data;

        }

    }
}
