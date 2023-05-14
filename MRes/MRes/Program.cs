using DevExpress.Skins;
using DevExpress.UserSkins;
using MRes.GUI.Login;
using MRes.GUI.Manager.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRes
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            DevExpress.Skins.SkinManager.EnableFormSkins();
            BonusSkins.Register();
     
            Application.Run(new Main());
        }
    }
}
