using MRes.Models.Table;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRes.DAL.API.Table
{
    class APITable
    {
        private static APITable instance;

        public static APITable Instance
        {
            get
            {
                if (instance == null)
                    instance = new APITable();
                return instance;

            }
            set => instance = value;
        }

        bool Clickadd = true;
        bool Clickedit = true;
        public bool ClickAdd { get => Clickadd; set => Clickadd = value; }
        public bool ClickEdit { get => Clickedit; set => Clickedit = value; }




        public TableData GetAll()
        {
            string Result = BaseAPI.Instance.Get(Const.URL + "tables/list");
            if (Result == null)
            {
                return null;
            }
            TableData data = JsonConvert.DeserializeObject<TableData>(Result);
            return data;
        }
        public TableData GetStatus()
        {
            string Result = BaseAPI.Instance.Get(Const.URL + "tables/show");
            if (Result == null)
            {
                return null;
            }
            TableData data = JsonConvert.DeserializeObject<TableData>(Result);
            return data;
        }
        public String Add(string name ,string id_users)
        {
            NameValueCollection table = new NameValueCollection();
            table["name"] = name;
            table["created_by"] = id_users;
            string Result = BaseAPI.Instance.All(Const.URL + "tables/create", table, "POST");
            return Result;
        }
        public String update(string id,string name, string status)
        {
            NameValueCollection table = new NameValueCollection();
            table["id"] = id;
            table["name"] = name;
            table["status"] = status;
            string Result = BaseAPI.Instance.All(Const.URL + "tables/update", table, "POST");
            return Result;
        }
        public String Move(string id_tablePresent, string id_tableUpdate, string id_bill)
        {
            NameValueCollection table = new NameValueCollection();
            table["id_tablePresent"] = id_tablePresent;
            table["id_tableUpdate"] = id_tableUpdate;
            table["id_bill"] = id_bill;
           
            string Result = BaseAPI.Instance.All(Const.URL + "tables/updateMoveTable", table, "POST");
            return Result;
        }
        public string delete(string id)
        {
            NameValueCollection table = new NameValueCollection();
            table["id"] = id;
            string Result = BaseAPI.Instance.All(Const.URL + "tables/delete", table, "POST");
            return Result;
        }
    }
}
