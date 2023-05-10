using MRes.Models.Role;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRes.DAL.API.Role
{
    class APIRole
    {
        private static APIRole instance;

        public static APIRole Instance
        {
            get
            {
                if (instance == null)
                    instance = new APIRole();
                return instance;

            }
            set => instance = value;
        }

        bool Clickadd = true;
        bool Clickedit = true;
        public bool ClickAdd { get => Clickadd; set => Clickadd = value; }
        public bool ClickEdit { get => Clickedit; set => Clickedit = value; }




        public RoleData GetAll()
        {
            string Result = BaseAPI.Instance.Get(Const.URL + "role/list");
            if (Result == null)
            {
                return null;
            }
            RoleData data = JsonConvert.DeserializeObject<RoleData>(Result);
            return data;
        }
    }
}
