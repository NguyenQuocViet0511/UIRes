using MRes.DAL.API.Table;
using MRes.Models.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRes.GUI.Manager.Table
{
    public partial class Fm_Table : Form
    {
        TableData table;
        public Fm_Table()
        {
            InitializeComponent();
            GetData();
            init();
            CheckForIllegalCrossThreadCalls = false;
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
            cbn_status.Enabled = true;
        }
        //get data
        public void GetData()
        {
            Task t = new Task(
                () =>
                {

                    table = APITable.Instance.GetAll();
                    if (table != null)
                    {
                        gridController.BeginInvoke((Action)delegate ()
                        {
                            gridController.DataSource = table.data.data;
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

                    table = APITable.Instance.GetAll();
                    if (table != null)
                    {
                        gridController.BeginInvoke((Action)delegate ()
                        {
                            gridController.DataSource = table.data.data;
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
            if(table != null)
            {
                txt_id.DataBindings.Clear();
                txt_id.DataBindings.Add("text", table.data.data, "id");
                //
                txt_name.DataBindings.Clear();
                txt_name.DataBindings.Add("text", table.data.data, "name");
                //
                txt_bill.DataBindings.Clear();
                txt_bill.DataBindings.Add("text", table.data.data, "id_bill");
                //
                cbn_status.DataBindings.Clear();
                cbn_status.DataBindings.Add("text", table.data.data, "status");
            }

            //

        }
        public void Cleartext()
        {
            txt_name.Text = "";
            txt_id.Text = "mã tự động tăng";
            cbn_status.Text = "tự động gán trạng thái";
            cbn_status.Enabled = false;

            //
            txt_id.DataBindings.Clear();
            //
            txt_name.DataBindings.Clear();
            //
            cbn_status.DataBindings.Clear();
            //
            txt_bill.DataBindings.Clear();
            //


        }
        //check empty
        public bool check()
        {

            if (string.IsNullOrEmpty(txt_name.Text) ||  string.IsNullOrEmpty(cbn_status.Text))
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
                            String result = APITable.Instance.Add(txt_name.Text, "US000000");
                            panel_info.BeginInvoke((Action)delegate ()
                            {
                                GetDataafter();
                            });
                            MessageBox.Show("" + result);

                        }
                        );
            add.Start();

        }
        //delete
        public void delete()
        {

            Task delete = new Task(
             () =>
             {
                 String result = APITable.Instance.delete(txt_id.Text);
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
                 String result = APITable.Instance.update(txt_id.Text, txt_name.Text, cbn_status.Text);
                 GetData();
                 MessageBox.Show("" + result);

             }
             );
            edit.Start();
        }
    }
}
