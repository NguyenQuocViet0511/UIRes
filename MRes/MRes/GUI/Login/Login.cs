using MRes.DAL;
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

namespace MRes.GUI.Login
{
    public partial class Login : Form
    {
        private StaffData staff;
        Main main;
        public Login()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_username.Text) || !string.IsNullOrEmpty(txt_password.Text))
            {
                CheckLogin();

            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Vào Đầy Đủ");
            }    
        }


        //get data
        private void CheckLogin()
        {
            Task  t = new Task(
                () =>
                {

                    staff = APIStaff.Instance.GetLogin(txt_username.Text,txt_password.Text);
                    if(staff.data.data.Count > 0)
                    {
                        foreach(var item in staff.data.data)
                        {
                            Const.staff = item;

                        }
                        if (Const.staff.id_role.Equals("staff") || Const.staff.id_role.Equals("user"))
                        {
                            MessageBox.Show("Bạn Không Có Quyền Đăng Nhập Vào Phần Mềm Này");
                        }  
                        else
                        {
                            MessageBox.Show("Đăng  Nhập Thành Công");
                          
                            this.Close();

                        }
                    }   
                    else
                    {
                        MessageBox.Show("Đăng Nhập Tài Khoản Sai Vui Lòng Thử Lại");

                    }


                }
                );
            t.Start();
        }
       
    }
}
