
namespace MRes.GUI.Revenue
{
    partial class statistical
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dateend = new DevExpress.XtraEditors.DateEdit();
            this.datestart = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_statistical = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.grid_data = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblMoney = new DevExpress.XtraEditors.TextEdit();
            this.ckn_today = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateend.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateend.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datestart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datestart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMoney.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.ckn_today);
            this.panelControl2.Controls.Add(this.lblMoney);
            this.panelControl2.Controls.Add(this.dateend);
            this.panelControl2.Controls.Add(this.datestart);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.btn_statistical);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1061, 78);
            this.panelControl2.TabIndex = 1;
            // 
            // dateend
            // 
            this.dateend.EditValue = null;
            this.dateend.Location = new System.Drawing.Point(255, 15);
            this.dateend.Name = "dateend";
            this.dateend.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateend.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.dateend.Properties.Appearance.Options.UseFont = true;
            this.dateend.Properties.Appearance.Options.UseForeColor = true;
            this.dateend.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.dateend.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateend.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateend.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateend.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateend.Properties.TodayDate = new System.DateTime(2023, 6, 7, 0, 0, 0, 0);
            this.dateend.Size = new System.Drawing.Size(228, 24);
            this.dateend.TabIndex = 21;
            // 
            // datestart
            // 
            this.datestart.EditValue = null;
            this.datestart.Location = new System.Drawing.Point(12, 15);
            this.datestart.Name = "datestart";
            this.datestart.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datestart.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.datestart.Properties.Appearance.Options.UseFont = true;
            this.datestart.Properties.Appearance.Options.UseForeColor = true;
            this.datestart.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.datestart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datestart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datestart.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.datestart.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.datestart.Properties.TodayDate = new System.DateTime(2023, 5, 10, 0, 0, 0, 0);
            this.datestart.Size = new System.Drawing.Size(228, 24);
            this.datestart.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(687, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tổng Doanh Thu :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_statistical
            // 
            this.btn_statistical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_statistical.Location = new System.Drawing.Point(489, 16);
            this.btn_statistical.Name = "btn_statistical";
            this.btn_statistical.Size = new System.Drawing.Size(105, 23);
            this.btn_statistical.TabIndex = 2;
            this.btn_statistical.Text = "Thống Kê";
            this.btn_statistical.Click += new System.EventHandler(this.btn_statistical_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.grid_data);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 78);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1061, 508);
            this.panelControl1.TabIndex = 2;
            // 
            // grid_data
            // 
            this.grid_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_data.Location = new System.Drawing.Point(2, 2);
            this.grid_data.MainView = this.gridView1;
            this.grid_data.Name = "grid_data";
            this.grid_data.Size = new System.Drawing.Size(1057, 504);
            this.grid_data.TabIndex = 0;
            this.grid_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.grid_data;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Phiếu";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Thời Gian Vào";
            this.gridColumn2.FieldName = "timein";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Thời Gian Ra";
            this.gridColumn3.FieldName = "timeout";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tổng Số Tiền";
            this.gridColumn4.FieldName = "sum";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Trạng Thái Tính Tiền";
            this.gridColumn5.FieldName = "status";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // lblMoney
            // 
            this.lblMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMoney.EditValue = "0";
            this.lblMoney.Location = new System.Drawing.Point(864, 15);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.lblMoney.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblMoney.Properties.Appearance.Options.UseBackColor = true;
            this.lblMoney.Properties.Appearance.Options.UseFont = true;
            this.lblMoney.Properties.Appearance.Options.UseForeColor = true;
            this.lblMoney.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblMoney.Properties.DisplayFormat.FormatString = "#,#";
            this.lblMoney.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.lblMoney.Properties.EditFormat.FormatString = "#,#";
            this.lblMoney.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.lblMoney.Properties.Mask.EditMask = "n0";
            this.lblMoney.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.lblMoney.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.lblMoney.Size = new System.Drawing.Size(185, 24);
            this.lblMoney.TabIndex = 31;
            // 
            // ckn_today
            // 
            this.ckn_today.AutoSize = true;
            this.ckn_today.ForeColor = System.Drawing.Color.White;
            this.ckn_today.Location = new System.Drawing.Point(12, 52);
            this.ckn_today.Name = "ckn_today";
            this.ckn_today.Size = new System.Drawing.Size(164, 20);
            this.ckn_today.TabIndex = 32;
            this.ckn_today.Text = "Thống kê ngày hôm nay";
            this.ckn_today.UseVisualStyleBackColor = true;
            this.ckn_today.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // statistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 586);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "statistical";
            this.Text = "statistical";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateend.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateend.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datestart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datestart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMoney.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_statistical;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl grid_data;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateEdit dateend;
        private DevExpress.XtraEditors.DateEdit datestart;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.TextEdit lblMoney;
        private System.Windows.Forms.CheckBox ckn_today;
    }
}