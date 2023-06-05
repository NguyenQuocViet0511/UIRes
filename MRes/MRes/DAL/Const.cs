using MRes.Models.Bill;
using MRes.Models.BillInfo;
using MRes.Models.Staff;
using MRes.Models.Table;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRes.DAL
{
    public class Const
    {
        private static Const instance;


        public static string URL = "http://192.168.1.22/API-server/server.php/api/";
        //public static string URL = "http://127.0.0.1:8000/api/";

        public static string MANAGER_FOOD = "QLFOOD";
        public static string MANAGER_CATEGORY = "QLCATEGORY";
        public static string MANAGER_STAFF = "QLSTAFF";
        public static string MANAGER_TALBE = "QLTABLE";
        public static string MANAGER_MATERIAL = "QLMATERIAL";
        public static string CHONSE = "";
        public static string LISTEN = "";
        public static Table table = new Table();
        public static Bill bill = new Bill();
        public static Staff staff = new Staff() {
        id = "US000000"
        };
        public static Table tableMove = new Table();
        public static List<BillInfo> billinfo = new List<BillInfo>();
        public static List<BillInfo> billinfoBar = new List<BillInfo>();

        public static double SumPay = 0;
        public string GetProjectLinkDirectory()
        {
            string currentLink = Directory.GetCurrentDirectory();
            string binLink = Directory.GetParent(currentLink).FullName;
            string projectLink = Directory.GetParent(binLink).FullName;
            return projectLink;
        }

        public static Const Instance
        {
            get
            {
                if (instance == null)
                    instance = new Const();
                return instance;

            }
            set => instance = value;
        }


        public void CheckExistingTab(DevComponents.DotNetBar.TabControl TabControl, string Text, Form From)
        {

            int Index = CheckTabAlready(TabControl, Text);
            if (Index >= 0)
            {
                TabControl.SelectedTab = TabControl.Tabs[Index];
                TabControl.SelectedTab.Text = Text;

            }
            else
            {


                DevComponents.DotNetBar.TabItem TabPage = TabControl.CreateTab(Text);
                From.Dock = DockStyle.Fill;
                From.TopLevel = false;
                TabPage.AttachedControl.Controls.Add(From);
                //  Form.MdiParent = this;
                From.Show();
                TabControl.SelectedTabIndex = TabControl.Tabs.Count - 1;


            }

        }
        private int CheckTabAlready(DevComponents.DotNetBar.TabControl TabControl, String TabName)
        {
            int temp = -1;
            for (int i = 0; i < TabControl.Tabs.Count; i++)
            {
                if (TabControl.Tabs[i].Text == TabName)
                {
                    temp = i;
                    break;
                }
            }
            return temp;
        }
        //end
        //remove Tab
        public void RemoveTab(DevComponents.DotNetBar.TabControl TabControlName)
        {
            for (int i = 1; i < TabControlName.Tabs.Count; i++)
            {
                TabControlName.Tabs.RemoveAt(i);
                return;
            }
        }

        public static string GetStringFromImage(Image image)
        {
            if (image != null)
            {
                ImageConverter ic = new ImageConverter();
                byte[] buffer = (byte[])ic.ConvertTo(image, typeof(byte[]));
                return Convert.ToBase64String(
                    buffer,
                    Base64FormattingOptions.InsertLineBreaks);
            }
            else
                return null;
        }
        public static Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }


    }
}
