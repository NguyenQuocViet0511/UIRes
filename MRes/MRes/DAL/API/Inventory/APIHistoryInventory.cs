using MRes.Models.Inventory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRes.DAL.API.Inventory
{

    class APIHistoryInventory
    {

        private static APIHistoryInventory instance;

        public static APIHistoryInventory Instance
        {
            get
            {
                if (instance == null)
                    instance = new APIHistoryInventory();
                return instance;

            }
            set => instance = value;
        }

        bool Clickadd = true;
        bool Clickedit = true;
        public bool ClickAdd { get => Clickadd; set => Clickadd = value; }
        public bool ClickEdit { get => Clickedit; set => Clickedit = value; }




        public HistoryinventoryData GetAll()
        {
            string Result = BaseAPI.Instance.Get(Const.URL + "historyinventory/list");
            if (Result == null)
            {
                return null;
            }
            HistoryinventoryData data = JsonConvert.DeserializeObject<HistoryinventoryData>(Result);
            return data;
        }
    }
}
