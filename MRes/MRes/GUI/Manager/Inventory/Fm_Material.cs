using MRes.DAL;
using MRes.DAL.API.Material;
using MRes.Models.Material;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRes.GUI.Manager.Inventory
{
    public partial class Fm_Material : Form
    {
        MaterialData Material;
        public Fm_Material()
        {
            InitializeComponent();
            GetData();
            init();
        }
        // add intit
        private void init()
        {
            setPanel(false);
        }
        // set panel 
        public void setPanel(bool check)
        {
            panel_info.Enabled = check;
        }
        //get data
        public void GetData()
        {
            Task t = new Task(
                () =>
                {

                    Material = APIMaterial.Instance.GetAll();
                    if (Material != null)
                    {
                        gridController.BeginInvoke((Action)delegate ()
                        {
                            gridController.DataSource = Material.data.data;
                            ClearandAdd();

                        });
                    }

                }
                );
            t.Start();
        }
        public void GetDataafter()
        {
            Task t = new Task(
                () =>
                {

                    Material = APIMaterial.Instance.GetAll();
                    if (Material != null)
                    {
                        gridController.BeginInvoke((Action)delegate ()
                        {
                            gridController.DataSource = Material.data.data;
                            Cleartext();
                        });
                    }

                }
                );
            t.Start();
        }
        // clear

        public void ClearandAdd()
        {
            txt_id.DataBindings.Clear();
            txt_id.DataBindings.Add("text", Material.data.data, "id");
            //
            txt_name.DataBindings.Clear();
            txt_name.DataBindings.Add("text", Material.data.data, "name");
            //
            txt_unit.DataBindings.Clear();
            txt_unit.DataBindings.Add("text", Material.data.data, "unit");
            //
            cbn_status.DataBindings.Clear();
            cbn_status.DataBindings.Add("text", Material.data.data, "status");
            txt_price.DataBindings.Clear();
            txt_price.DataBindings.Add("text", Material.data.data, "price");

            txt_created_by.DataBindings.Clear();
            txt_created_by.DataBindings.Add("text", Material.data.data, "created_by");
            //

        }

        //clear
        //cleartext
        public void Cleartext()
        {
            txt_unit.Text = "";
            txt_id.Text = "mã tự động tăng";
            txt_name.Text = "";
            txt_price.Text = "";
            txt_created_by.Text = "";
            txt_id.DataBindings.Clear();
            //
            txt_name.DataBindings.Clear();
            //
            txt_unit.DataBindings.Clear();
            //
            txt_created_by.DataBindings.Clear();
            //
            //
            txt_price.DataBindings.Clear();
            //
            cbn_status.DataBindings.Clear();
            //

        }
        //check empty
        public bool check()
        {
            if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_unit.Text) || string.IsNullOrEmpty(txt_price.Text) || string.IsNullOrEmpty(cbn_status.Text) )
            {
                return false;

            }
            return true;
        }
        //create new 
        public void Add()
        {

            Task add = new Task(
                        () =>
                        {
                            String result = APIMaterial.Instance.Add(txt_name.Text, Convert.ToDouble(txt_price.Text), txt_unit.Text.ToString(), cbn_status.Text, Const.staff.id);
                            panel_info.BeginInvoke((Action)delegate ()
                            {
                                Cleartext();
                            });
                            GetDataafter();
                            MessageBox.Show("" + result);
                        }
                        );
            add.Start();

        }
        // delete
        public void delete()
        {

            Task delete = new Task(
             () =>
             {
                 String result = APIMaterial.Instance.delete(txt_id.Text);
                 GetData();
                 MessageBox.Show("" + result);

             }
             );
            delete.Start();
        }
        //edit
        public void edit()
        {

            Task edit = new Task(
             () =>
             {
                 String result = APIMaterial.Instance.update(txt_id.Text, txt_name.Text, Convert.ToDouble(txt_price.Text), txt_unit.Text.ToString(), cbn_status.Text);
                 GetData();
                 MessageBox.Show("" + result);

             }
             );
            edit.Start();
        }
    }
}
