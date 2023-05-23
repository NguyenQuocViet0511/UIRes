using MRes.DAL;
using MRes.DAL.API.Role;
using MRes.DAL.API.Staff;
using MRes.Models.Role;
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
        string url = "";
        StaffData staff;
        RoleData Role;
        public Fm_Staff()
        {
            InitializeComponent();
            GetData();
            Getrole();
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

                    staff = APIStaff.Instance.GetAll();
                    if(staff != null)
                    {
                        gridController.BeginInvoke((Action)delegate ()
                        {
                            gridController.DataSource = staff.data.data;
                            ClearandAdd();

                        });
                    }    
                  
                }
                );
            t.Start();
        }
        public void GetDataater()
        {
            Task t = new Task(
                () =>
                {

                    staff = APIStaff.Instance.GetAll();
                    if (staff != null)
                    {
                        gridController.BeginInvoke((Action)delegate ()
                        {
                            gridController.DataSource = staff.data.data;

                        });
                    }

                }
                );
            t.Start();
        }
        // get data role
        public void Getrole()
        {
            Task t1 = new Task(
             () =>
             {
                 Role = APIRole.Instance.GetAll();
                 if(Role != null)
                 {
                     cbn_role.BeginInvoke((Action)delegate ()
                     {
                         cbn_role.Properties.DisplayMember = "name";
                         cbn_role.Properties.ValueMember = "id";
                         cbn_role.Properties.DataSource = Role.data.data;

                     });
                 }    
               

             }
             );
            t1.Start();
        }
        // clear
        public void ClearandAdd()
        {
            if (staff != null)
            {
                txt_id.DataBindings.Clear();
                txt_id.DataBindings.Add("text", staff.data.data, "id");
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

                txt_image.DataBindings.Clear();
                txt_image.DataBindings.Add("text", staff.data.data, "image");
                 if (!string.IsNullOrEmpty(txt_image.Text))
                {
                    pictureEdit1.Image = Const.Base64ToImage(txt_image.Text);

                }
            }    

             
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

        //cleartext
        public void Cleartext()
        {
            txt_address.Text = "";
            txt_email.Text = "";
            txt_id.Text = "mã tự động tăng";
            txt_name.Text = "";
            txt_number.Text = "";
            date.Text = "";
            txt_id.DataBindings.Clear();
            //
            txt_name.DataBindings.Clear();
            //
            txt_email.DataBindings.Clear();
            //
            txt_address.DataBindings.Clear();
            //
            txt_number.DataBindings.Clear();
            //
            cbn_role.DataBindings.Clear();
            //
            cbn_sex.DataBindings.Clear();
            //
            this.cbn_status.DataBindings.Clear();
            date.DataBindings.Clear();
            pictureEdit1.Image = null;

        }
        //check empty
        public bool check()
        {
            //if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_number.Text) || string.IsNullOrEmpty(txt_address.Text) || string.IsNullOrEmpty(txt_email.Text) || string.IsNullOrEmpty(cbn_status.Text) || string.IsNullOrEmpty(cbn_sex.Text)
            //|| string.IsNullOrEmpty(cbn_role.Text) || string.IsNullOrEmpty(date.Text) )
            //{
            if (string.IsNullOrEmpty(txt_name.Text)  ||  string.IsNullOrEmpty(cbn_status.Text) || string.IsNullOrEmpty(cbn_sex.Text)
           || string.IsNullOrEmpty(cbn_role.Text) || string.IsNullOrEmpty(date.Text))
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
                            String result = APIStaff.Instance.Add(txt_name.Text,txt_email.Text,cbn_sex.Text, cbn_status.Text, txt_number.Text, cbn_role.EditValue.ToString(),date.Text,txt_address.Text,url);
                            panel_info.BeginInvoke((Action)delegate ()
                            {
                                Cleartext();
                            });
                            GetDataater();
                            url = "";
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
                 String result = APIStaff.Instance.delete(txt_id.Text);
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
                 String result = APIStaff.Instance.Edit(txt_id.Text,txt_name.Text,txt_email.Text, cbn_sex.Text, cbn_status.Text, txt_number.Text, cbn_role.EditValue.ToString(), date.Text, txt_address.Text, url);
                 GetData();
                 url = "";
                 MessageBox.Show("" + result);

             }
             );
            edit.Start();
        }

        private void txt_number_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
         
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = openFileDialog.Filter = "JPG files (*.Jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                url = Const.GetStringFromImage(new Bitmap(openFileDialog.FileName));
                pictureEdit1.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void gridController_Click(object sender, EventArgs e)
        {
            Task t = new Task(() =>
            {
                if (!string.IsNullOrEmpty(txt_image.Text))
                {
                    pictureEdit1.Image = Const.Base64ToImage(txt_image.Text);

                }
                else
                {
                    pictureEdit1.Image = null;
                }

            });
            t.Start();

        }
    }
}
