using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRes.Models.Inventory
{
   public class Historyinventory
    {
        private string Date;
        private string Id_material;
        private string Name;
        private int Quantityfirst;
        private int Quantityin;
        private int Quantityout;
        private int Quantityend;


        public Historyinventory()
        {

        }
        public Historyinventory(string Date, string id_material, string name, int Quantityfirst, int Quantityin, int Quantityout, int Quantityend)
        {
            this.Date = Date;
            this.Id_material = id_material;
            this.Name = name;
            this.Quantityfirst = Quantityfirst;
            this.Quantityin = Quantityin;
            this.Quantityout = Quantityout;
            this.Quantityend = Quantityend;



        }

        public string date { get => Date; set => Date = value; }
        public string id_material { get => Id_material; set => Id_material = value; }
        public string name { get => Name; set => Name = value; }
        public int quantityfirst { get => Quantityfirst; set => Quantityfirst = value; }
        public int quantityin { get => Quantityin; set => Quantityin = value; }
        public int quantityout { get => Quantityout; set => Quantityout = value; }
        public int quantityend { get => Quantityend; set => Quantityend = value; }

    }
}
