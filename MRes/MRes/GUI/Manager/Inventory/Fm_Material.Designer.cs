﻿
namespace MRes.GUI.Manager.Inventory
{
    partial class Fm_Material
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
            this.gridController = new DevExpress.XtraGrid.GridControl();
            this.GidController = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coliduser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_next = new DevExpress.XtraEditors.SimpleButton();
            this.btn_prev = new DevExpress.XtraEditors.SimpleButton();
            this.btn_last = new DevExpress.XtraEditors.SimpleButton();
            this.btn_first = new DevExpress.XtraEditors.SimpleButton();
            this.panel_info = new DevExpress.XtraEditors.PanelControl();
            this.txt_unit = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_created_by = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_price = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.cbn_status = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GidController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_info)).BeginInit();
            this.panel_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_unit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_created_by.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_price.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbn_status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridController
            // 
            this.gridController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridController.Location = new System.Drawing.Point(0, 149);
            this.gridController.MainView = this.GidController;
            this.gridController.Name = "gridController";
            this.gridController.Size = new System.Drawing.Size(1163, 298);
            this.gridController.TabIndex = 9;
            this.gridController.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GidController});
            // 
            // GidController
            // 
            this.GidController.Appearance.EvenRow.BackColor = System.Drawing.Color.Gray;
            this.GidController.Appearance.EvenRow.Options.UseBackColor = true;
            this.GidController.Appearance.FocusedRow.BackColor = System.Drawing.Color.Gray;
            this.GidController.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GidController.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.GidController.Appearance.GroupRow.Options.UseBackColor = true;
            this.GidController.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.GidController.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.GidController.Appearance.HotTrackedRow.BackColor = System.Drawing.Color.Gray;
            this.GidController.Appearance.HotTrackedRow.Options.UseBackColor = true;
            this.GidController.Appearance.SelectedRow.BackColor = System.Drawing.Color.Silver;
            this.GidController.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GidController.Appearance.SelectedRow.Options.UseBackColor = true;
            this.GidController.Appearance.SelectedRow.Options.UseForeColor = true;
            this.GidController.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname,
            this.colusername,
            this.status,
            this.coliduser});
            this.GidController.GridControl = this.gridController;
            this.GidController.Name = "GidController";
            this.GidController.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Cancel;
            this.GidController.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.GidController.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.False;
            this.GidController.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.False;
            this.GidController.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.False;
            this.GidController.OptionsFind.AlwaysVisible = true;
            this.GidController.OptionsFind.FindNullPrompt = "Nhập Vào Tên / hoặc từ gì cần tìm";
            this.GidController.OptionsFind.ShowFindButton = false;
            this.GidController.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.Caption = "Mã Nguyên liệu";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colname
            // 
            this.colname.Caption = "Tên Nguyên liệu";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsColumn.AllowEdit = false;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            // 
            // colusername
            // 
            this.colusername.Caption = "giá";
            this.colusername.DisplayFormat.FormatString = "#,#";
            this.colusername.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colusername.FieldName = "price";
            this.colusername.Name = "colusername";
            this.colusername.OptionsColumn.AllowEdit = false;
            this.colusername.Visible = true;
            this.colusername.VisibleIndex = 2;
            // 
            // status
            // 
            this.status.Caption = "Trạng Thái";
            this.status.FieldName = "status";
            this.status.Name = "status";
            this.status.Visible = true;
            this.status.VisibleIndex = 3;
            // 
            // coliduser
            // 
            this.coliduser.Caption = "Tạo Bởi";
            this.coliduser.FieldName = "created_by";
            this.coliduser.Name = "coliduser";
            this.coliduser.Visible = true;
            this.coliduser.VisibleIndex = 4;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_next);
            this.panelControl2.Controls.Add(this.btn_prev);
            this.panelControl2.Controls.Add(this.btn_last);
            this.panelControl2.Controls.Add(this.btn_first);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 447);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1163, 54);
            this.panelControl2.TabIndex = 8;
            // 
            // btn_next
            // 
            this.btn_next.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_next.Appearance.Options.UseFont = true;
            this.btn_next.Appearance.Options.UseForeColor = true;
            this.btn_next.Location = new System.Drawing.Point(121, 7);
            this.btn_next.Name = "btn_next";
            this.btn_next.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btn_next.Size = new System.Drawing.Size(35, 35);
            this.btn_next.TabIndex = 3;
            this.btn_next.Text = ">";
            // 
            // btn_prev
            // 
            this.btn_prev.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prev.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_prev.Appearance.Options.UseFont = true;
            this.btn_prev.Appearance.Options.UseForeColor = true;
            this.btn_prev.Location = new System.Drawing.Point(65, 7);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btn_prev.Size = new System.Drawing.Size(35, 35);
            this.btn_prev.TabIndex = 2;
            this.btn_prev.Text = "<";
            // 
            // btn_last
            // 
            this.btn_last.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_last.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_last.Appearance.Options.UseFont = true;
            this.btn_last.Appearance.Options.UseForeColor = true;
            this.btn_last.Location = new System.Drawing.Point(178, 7);
            this.btn_last.Name = "btn_last";
            this.btn_last.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btn_last.Size = new System.Drawing.Size(35, 35);
            this.btn_last.TabIndex = 1;
            this.btn_last.Text = ">>";
            // 
            // btn_first
            // 
            this.btn_first.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_first.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_first.Appearance.Options.UseFont = true;
            this.btn_first.Appearance.Options.UseForeColor = true;
            this.btn_first.Location = new System.Drawing.Point(12, 7);
            this.btn_first.Name = "btn_first";
            this.btn_first.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btn_first.Size = new System.Drawing.Size(35, 35);
            this.btn_first.TabIndex = 0;
            this.btn_first.Text = "<<";
            // 
            // panel_info
            // 
            this.panel_info.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panel_info.Appearance.Options.UseBackColor = true;
            this.panel_info.Controls.Add(this.txt_unit);
            this.panel_info.Controls.Add(this.label5);
            this.panel_info.Controls.Add(this.txt_created_by);
            this.panel_info.Controls.Add(this.label7);
            this.panel_info.Controls.Add(this.txt_price);
            this.panel_info.Controls.Add(this.label4);
            this.panel_info.Controls.Add(this.cbn_status);
            this.panel_info.Controls.Add(this.label2);
            this.panel_info.Controls.Add(this.txt_name);
            this.panel_info.Controls.Add(this.label3);
            this.panel_info.Controls.Add(this.label1);
            this.panel_info.Controls.Add(this.txt_id);
            this.panel_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_info.Location = new System.Drawing.Point(0, 0);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(1163, 149);
            this.panel_info.TabIndex = 7;
            // 
            // txt_unit
            // 
            this.txt_unit.Location = new System.Drawing.Point(469, 62);
            this.txt_unit.Name = "txt_unit";
            this.txt_unit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unit.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txt_unit.Properties.Appearance.Options.UseFont = true;
            this.txt_unit.Properties.Appearance.Options.UseForeColor = true;
            this.txt_unit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txt_unit.Size = new System.Drawing.Size(278, 24);
            this.txt_unit.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(405, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Đơn vị";
            // 
            // txt_created_by
            // 
            this.txt_created_by.Enabled = false;
            this.txt_created_by.Location = new System.Drawing.Point(469, 102);
            this.txt_created_by.Name = "txt_created_by";
            this.txt_created_by.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_created_by.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txt_created_by.Properties.Appearance.Options.UseFont = true;
            this.txt_created_by.Properties.Appearance.Options.UseForeColor = true;
            this.txt_created_by.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txt_created_by.Size = new System.Drawing.Size(278, 24);
            this.txt_created_by.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(405, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tạo Bởi ";
            // 
            // txt_price
            // 
            this.txt_price.EditValue = 0D;
            this.txt_price.Location = new System.Drawing.Point(130, 102);
            this.txt_price.Name = "txt_price";
            this.txt_price.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txt_price.Properties.Appearance.Options.UseFont = true;
            this.txt_price.Properties.Appearance.Options.UseForeColor = true;
            this.txt_price.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txt_price.Properties.DisplayFormat.FormatString = "#,#";
            this.txt_price.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_price.Properties.EditFormat.FormatString = "#,#";
            this.txt_price.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_price.Properties.Mask.EditMask = "n0";
            this.txt_price.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_price.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_price.Size = new System.Drawing.Size(231, 24);
            this.txt_price.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(62, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Giá Bán";
            // 
            // cbn_status
            // 
            this.cbn_status.EditValue = "Chọn trạng Thái";
            this.cbn_status.Location = new System.Drawing.Point(469, 20);
            this.cbn_status.Name = "cbn_status";
            this.cbn_status.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.cbn_status.Properties.Appearance.Options.UseForeColor = true;
            this.cbn_status.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.cbn_status.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbn_status.Properties.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbn_status.Size = new System.Drawing.Size(278, 24);
            this.cbn_status.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(388, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Trạng Thái";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(130, 62);
            this.txt_name.Name = "txt_name";
            this.txt_name.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txt_name.Properties.Appearance.Options.UseForeColor = true;
            this.txt_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txt_name.Size = new System.Drawing.Size(231, 24);
            this.txt_name.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Nguyên liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Nguyên Liệu";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(133, 20);
            this.txt_id.Name = "txt_id";
            this.txt_id.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txt_id.Properties.Appearance.Options.UseForeColor = true;
            this.txt_id.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txt_id.Size = new System.Drawing.Size(228, 24);
            this.txt_id.TabIndex = 0;
            // 
            // Fm_Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 501);
            this.Controls.Add(this.gridController);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panel_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fm_Material";
            this.Text = "Fm_Material";
            ((System.ComponentModel.ISupportInitialize)(this.gridController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GidController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_info)).EndInit();
            this.panel_info.ResumeLayout(false);
            this.panel_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_unit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_created_by.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_price.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbn_status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridController;
        private DevExpress.XtraGrid.Views.Grid.GridView GidController;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private DevExpress.XtraGrid.Columns.GridColumn status;
        private DevExpress.XtraGrid.Columns.GridColumn coliduser;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_next;
        private DevExpress.XtraEditors.SimpleButton btn_prev;
        private DevExpress.XtraEditors.SimpleButton btn_last;
        private DevExpress.XtraEditors.SimpleButton btn_first;
        private DevExpress.XtraEditors.PanelControl panel_info;
        private DevExpress.XtraEditors.ComboBoxEdit cbn_status;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_id;
        private DevExpress.XtraEditors.TextEdit txt_price;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txt_created_by;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txt_unit;
        private System.Windows.Forms.Label label5;
    }
}