using MRes.Models.Inventory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRes.DAL.API.Inventory
{
    class APIInventory
    {
        private static APIInventory instance;

        public static APIInventory Instance
        {
            get
            {
                if (instance == null)
                    instance = new APIInventory();
                return instance;

            }
            set => instance = value;
        }

        bool Clickadd = true;
        bool Clickedit = true;
        public bool ClickAdd { get => Clickadd; set => Clickadd = value; }
        public bool ClickEdit { get => Clickedit; set => Clickedit = value; }




        public InventoryData GetAll()
        {
            string Result = BaseAPI.Instance.Get(Const.URL + "inventory/list");
            if (Result == null)
            {
                return null;
            }
            InventoryData data = JsonConvert.DeserializeObject<InventoryData>(Result);
            return data;
        }
        public string update(string id_material,string count, string countout)
        {
            NameValueCollection table = new NameValueCollection();
            table["id_material"] = id_material;
            table["count"] = count;
            table["countout"] = countout;
            string Result = BaseAPI.Instance.All(Const.URL + "inventory/update", table, "POST");
            return Result;
        }
}
}
