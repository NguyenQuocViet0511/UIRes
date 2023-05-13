using DevExpress.XtraGrid.Views.Grid;
using MRes.DAL;
using MRes.DAL.API.Material;
using MRes.DAL.API.Materialbill;
using MRes.DAL.API.MaterialBillInfo;
using MRes.Models.Material;
using MRes.Models.MaterialBill;
using MRes.Models.MaterialBillInfo;
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
    public partial class Fm_Inventory : Form
    {
        MaterialData material;
        MaterialBillData materialBill;
        MaterialBillInfoData MaterialBillinfo;
        bool Click = false;
        bool ClickBill = false;

        public Fm_Inventory()
        {
            InitializeComponent();
            Getmaterial();
            GetmaterialBill();
            CheckForIllegalCrossThreadCalls = false;
        }


        // get data role
        public void Getmaterial()
        {
            Task t1 = new Task(
             () =>
             {
                 material = APIMaterial.Instance.GetAll();
                 if (material != null)
                 {
                     cbn_material.BeginInvoke((Action)delegate ()
                     {
                         cbn_material.Properties.DisplayMember = "name";
                         cbn_material.Properties.ValueMember = "id";
                         cbn_material.Properties.DataSource = material.data.data;

                     });
                 }


             }
             );
            t1.Start();
        }
        public void ClearandAdd()
        {
            if(MaterialBillinfo != null)
            {
                txt_id.DataBindings.Clear();
                txt_id.DataBindings.Add("text", MaterialBillinfo.data.data, "id_materialbill");
                //
                txt_number.DataBindings.Clear();
                txt_number.DataBindings.Add("text", MaterialBillinfo.data.data, "count");
                //
    
                //
                cbn_material.DataBindings.Clear();
                cbn_material.DataBindings.Add("text", MaterialBillinfo.data.data, "id");
            }    
      

            //

        }

        public void GetmaterialBill()
        {
            Task t1 = new Task(
             () =>
             {
             materialBill = APIMaterialBill.Instance.GetAll();
                 if (materialBill != null)
                 {
                 
                    
                        gird_materialBill.DataSource = materialBill.data.data;
                 }
              


             }
             );
            t1.Start();
        }

        private void gird_materialBill_Click(object sender, EventArgs e)
        {
           
            LoadDataBill(((GridView)gird_materialBill.MainView).GetFocusedRowCellValue("id").ToString());
            txt_id.Text = ((GridView)gird_materialBill.MainView).GetFocusedRowCellValue("id").ToString();
            ClickBill = true;
        }
        private void LoadDataBill(string id)
        {


            Task t = new Task(
                () =>
                {

                    MaterialBillinfo = APIMaterialBillInfo.Instance.GetBillInfo(id);
                    if (MaterialBillinfo.data.data.Count  >  0)
                    {
                        grid_materialBillinfo.BeginInvoke((Action)delegate ()
                        {
                            grid_materialBillinfo.DataSource = null;
                            grid_materialBillinfo.DataSource = MaterialBillinfo.data.data;
                            ClearandAdd();

                        });
                    }
                    else
                    {

                        grid_materialBillinfo.DataSource = null;
                        Cleartext();

                    }

                }
                );
            t.Start();
        }
    
    private void LoadDataBillAdd(string id)
    {


        Task t = new Task(
            () =>
            {

                MaterialBillinfo = APIMaterialBillInfo.Instance.GetBillInfo(id);
                if (MaterialBillinfo.data.data.Count > 0)
                {
                    grid_materialBillinfo.BeginInvoke((Action)delegate ()
                    {
                        grid_materialBillinfo.DataSource = null;
                        grid_materialBillinfo.DataSource = MaterialBillinfo.data.data;
                        Cleartext();

                    });
                }
                else
                {


                    Cleartext();

                }

            }
            );
        t.Start();
    }
    private void btn_add_Click(object sender, EventArgs e)
        {
            if(Click)
            {
                if(txt_number.Value <= 0 || string.IsNullOrEmpty(cbn_material.Text))
                {
                    MessageBox.Show("Không Được Để Trống");
                }    
                else
                {
                    AddBilinfolNeworupdate(cbn_material.EditValue.ToString(), txt_id.Text, Convert.ToInt32(txt_number.Value), Const.staff.id);

                }
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn Thêm ");
            }    
        }

        private void btn_AddMore_Click(object sender, EventArgs e)
        {
            if(ClickBill)
            {
                Cleartext();
                Click = true;
                panel_controller.Enabled = true;
                btn_delete.Enabled = false;
                btn_add.Enabled = true;
            }
            else
            {
                MessageBox.Show("Chưa Chọn Hóa Đơn Không Thể Thêm");
            }    
           
        }
        //clear
        public void Cleartext()
        {
            txt_number.Value = 0;
            //
            cbn_material.Text = "";
            
            
            txt_id.DataBindings.Clear();
            //
            cbn_material.DataBindings.Clear();
            //
            //
            txt_number.DataBindings.Clear();
            //


        }
        //check empty
        public bool check()
        {

            if (string.IsNullOrEmpty(txt_number.Text))
            {
                return false;

            }
            return true;
        }

        private void btn_created_Click(object sender, EventArgs e)
        {
         
                AddBillNew("Nhập Kho", Const.staff.id.ToString());

        }

        private void AddBillNew(string status,string created_by)
        {
            Task t1 = new Task(
             () =>
             {
                 string result = APIMaterialBill.Instance.Add(status, created_by);
                 MessageBox.Show(result);
                 GetmaterialBill();

             }
             );
            t1.Start();
        }

        private void AddBilinfolNeworupdate(string id_material, string id_material_bill,int count,string id_user)
        {
            Task t1 = new Task(
             () =>
             {
                 string result = APIMaterialBillInfo.Instance.CreateOrUpdate(id_material, id_material_bill, count.ToString(),"0",id_user);
                 MessageBox.Show(result);
                 LoadDataBillAdd(id_material_bill);
                 GetmaterialBill();

             }
             );
            t1.Start();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            if(ClickBill)
            {
                if (MessageBox.Show("Bạn Có Muốn Hủy Bỏ Không", "Cảnh Báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
                {
                    Click = false;
                    panel_controller.Enabled = false;
                    grid_materialBillinfo.DataSource = null;
                    txt_id.Text = "";
                    Cleartext();
                    btn_delete.Enabled = true;
                    ClickBill = false;
                }
            }    
          

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Xóa Bỏ Không", "Cảnh Báo", MessageBoxButtons.OKCancel) != DialogResult.Cancel)
            {
                delete(cbn_material.EditValue.ToString(), txt_id.Text);

            }
        }
        private void delete(string id_material, string id_material_bill)
        {
            Task t1 = new Task(
             () =>
             {
                 string result = APIMaterialBillInfo.Instance.delete(id_material, id_material_bill);
                 MessageBox.Show(result);
                 LoadDataBill(id_material_bill);
                 GetmaterialBill();

             }
             );
            t1.Start();
        }
    }
}
