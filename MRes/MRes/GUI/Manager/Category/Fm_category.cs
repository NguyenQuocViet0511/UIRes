using MRes.DAL.API.Category;
using MRes.Models.Category;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRes.GUI.Manager.Category
{
    public partial class Fm_category : Form
    {
        CategoryData category;

        public Fm_category()
        {
            InitializeComponent();
            GetData();

            init();

        }

        private void init()
        {
            panel_info.Enabled = false;
        }

        public void GetData()
        {
            Task t = new Task(
                () =>
                {

                    category = APICategory.Instance.GetAll();
                    gridController.BeginInvoke((Action)delegate ()
                    {
                        gridController.DataSource = category.data.data;
                        ClearandAdd();

                    });
                }
                );
            t.Start();
        }
        private void ClearandAdd()
        {
            txt_id.DataBindings.Clear();
            txt_id.DataBindings.Add("text", category.data.data, "id");
            //
            txt_name.DataBindings.Clear();
            txt_name.DataBindings.Add("text", category.data.data, "name");
            //
            txt_count.DataBindings.Clear();
            txt_count.DataBindings.Add("text", category.data.data, "count");
            //
            cbn_status.DataBindings.Clear();
            cbn_status.DataBindings.Add("text", category.data.data, "status");
            //
          
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            this.BindingContext[category.data.data].Position = 0;

        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            this.BindingContext[category.data.data].Position--;

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.BindingContext[category.data.data].Position++;

        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            int location = this.BindingContext[category.data.data].Count - 1;
            this.BindingContext[category.data.data].Position = location;
        }
    }
}
