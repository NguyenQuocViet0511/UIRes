using MRes.DAL.API.Staff;
using MRes.Models.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRes.GUI.Manager.Staff
{
    public partial class Fm_Staff : Form
    {
        StaffData staff;
        public Fm_Staff()
        {
            InitializeComponent();
            GetData();
            init();
        }

        private void init()
        {
            panel_info.Enabled = false;
        }
        //get data
        public void GetData()
        {
            Task t = new Task(
                () =>
                {

                    staff = APIStaff.Instance.GetAll();
                    gridController.BeginInvoke((Action)delegate ()
                    {
                        gridController.DataSource = staff.data.data;
                        ClearandAdd();

                    });
                }
                );
            t.Start();
        }
        // get data role
        //public void Getrole()
        //{
        //    Task t1 = new Task(
        //     () =>
        //     {
        //         category = APICategory.Instance.GetAll();
        //         cbn_category.BeginInvoke((Action)delegate ()
        //         {
        //             cbn_category.Properties.DisplayMember = "name";
        //             cbn_category.Properties.ValueMember = "id";
        //             cbn_category.Properties.DataSource = category.data.data;

        //         });

        //     }
        //     );
        //    t1.Start();
        //}
        // clear
        private void ClearandAdd()
        {
            txt_id.DataBindings.Clear();
            txt_id.DataBindings.Add("text", staff.data.data,"id");
            //
            txt_name.DataBindings.Clear();
            txt_name.DataBindings.Add("text", staff.data.data, "name");
            //
            txt_email.DataBindings.Clear();
            txt_email.DataBindings.Add("text", staff.data.data, "email");
            //
            txt_address.DataBindings.Clear();
            txt_address.DataBindings.Add("text", staff.data.data, "address");
            //
            date.DataBindings.Clear();
            date.DataBindings.Add("text", staff.data.data, "date");
            //
            cbn_sex.DataBindings.Clear();
            cbn_sex.DataBindings.Add("text", staff.data.data, "sex");
            //
            cbn_status.DataBindings.Clear();
            cbn_status.DataBindings.Add("text", staff.data.data, "status");
            //
            cbn_role.DataBindings.Clear();
            cbn_role.DataBindings.Add("text", staff.data.data, "id_role");
            //
            txt_number.DataBindings.Clear();
            txt_number.DataBindings.Add("text", staff.data.data, "number");
        }
        private void Fm_Staff_Load(object sender, EventArgs e)
        {
          

        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            this.BindingContext[staff.data.data].Position = 0;
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            int location = this.BindingContext[staff.data.data].Count - 1;
            this.BindingContext[staff.data.data].Position = location;

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.BindingContext[staff.data.data].Position++;

        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            this.BindingContext[staff.data.data].Position--;

        }
    }
}
