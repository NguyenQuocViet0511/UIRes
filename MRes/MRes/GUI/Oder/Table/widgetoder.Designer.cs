
namespace MRes.GUI.Oder.Table
{
    partial class widgetoder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.gridController = new DevExpress.XtraGrid.GridControl();
            this.GidController = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.txt_note = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.NumericUpDown();
            this.txt_name = new DevExpress.XtraEditors.TextEdit();
            this.txt_price = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GidController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_note.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_price.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 49);
            this.label1.TabIndex = 35;
            this.label1.Text = "Chi Tiết Thêm Món";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridController
            // 
            this.gridController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridController.Location = new System.Drawing.Point(0, 337);
            this.gridController.MainView = this.GidController;
            this.gridController.Name = "gridController";
            this.gridController.Size = new System.Drawing.Size(442, 266);
            this.gridController.TabIndex = 37;
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
            this.colprice,
            this.coldiscount,
            this.colcount});
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
            this.colid.Caption = "Mã Món";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colname
            // 
            this.colname.Caption = "Tên Món";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsColumn.AllowEdit = false;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            // 
            // colprice
            // 
            this.colprice.Caption = "Giá ";
            this.colprice.DisplayFormat.FormatString = "#,#";
            this.colprice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colprice.FieldName = "price";
            this.colprice.Name = "colprice";
            this.colprice.OptionsColumn.AllowEdit = false;
            this.colprice.Visible = true;
            this.colprice.VisibleIndex = 2;
            // 
            // coldiscount
            // 
            this.coldiscount.Caption = "Giảm Giá";
            this.coldiscount.FieldName = "discount";
            this.coldiscount.Name = "coldiscount";
            this.coldiscount.Visible = true;
            this.coldiscount.VisibleIndex = 3;
            // 
            // colcount
            // 
            this.colcount.Caption = "số lượng đã bán";
            this.colcount.FieldName = "count";
            this.colcount.Name = "colcount";
            this.colcount.OptionsColumn.AllowEdit = false;
            this.colcount.Visible = true;
            this.colcount.VisibleIndex = 4;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.txt_note);
            this.panelControl5.Controls.Add(this.label6);
            this.panelControl5.Controls.Add(this.btn_add);
            this.panelControl5.Controls.Add(this.label5);
            this.panelControl5.Controls.Add(this.txt_number);
            this.panelControl5.Controls.Add(this.txt_name);
            this.panelControl5.Controls.Add(this.txt_price);
            this.panelControl5.Controls.Add(this.label4);
            this.panelControl5.Controls.Add(this.label2);
            this.panelControl5.Controls.Add(this.label3);
            this.panelControl5.Controls.Add(this.txt_id);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl5.Location = new System.Drawing.Point(0, 49);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(442, 288);
            this.panelControl5.TabIndex = 36;
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(93, 187);
            this.txt_note.Name = "txt_note";
            this.txt_note.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_note.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txt_note.Properties.Appearance.Options.UseFont = true;
            this.txt_note.Properties.Appearance.Options.UseForeColor = true;
            this.txt_note.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txt_note.Size = new System.Drawing.Size(294, 24);
            this.txt_note.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(25, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Ghi Chú";
            // 
            // btn_add
            // 
            this.btn_add.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.btn_add.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseBackColor = true;
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_add.Location = new System.Drawing.Point(2, 257);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(438, 29);
            this.btn_add.TabIndex = 34;
            this.btn_add.Text = "Thêm";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Số lượng";
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(95, 151);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(120, 23);
            this.txt_number.TabIndex = 29;
            // 
            // txt_name
            // 
            this.txt_name.Enabled = false;
            this.txt_name.Location = new System.Drawing.Point(93, 59);
            this.txt_name.Name = "txt_name";
            this.txt_name.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txt_name.Properties.Appearance.Options.UseFont = true;
            this.txt_name.Properties.Appearance.Options.UseForeColor = true;
            this.txt_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txt_name.Size = new System.Drawing.Size(294, 24);
            this.txt_name.TabIndex = 28;
            // 
            // txt_price
            // 
            this.txt_price.EditValue = 0D;
            this.txt_price.Enabled = false;
            this.txt_price.Location = new System.Drawing.Point(93, 105);
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
            this.txt_price.Size = new System.Drawing.Size(294, 24);
            this.txt_price.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Giá Bán";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Món";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã Món";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(93, 16);
            this.txt_id.Name = "txt_id";
            this.txt_id.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txt_id.Properties.Appearance.Options.UseFont = true;
            this.txt_id.Properties.Appearance.Options.UseForeColor = true;
            this.txt_id.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txt_id.Size = new System.Drawing.Size(294, 24);
            this.txt_id.TabIndex = 4;
            // 
            // widgetoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridController);
            this.Controls.Add(this.panelControl5);
            this.Controls.Add(this.label1);
            this.Name = "widgetoder";
            this.Size = new System.Drawing.Size(442, 603);
            ((System.ComponentModel.ISupportInitialize)(this.gridController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GidController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_note.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_price.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridController;
        private DevExpress.XtraGrid.Views.Grid.GridView GidController;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colprice;
        private DevExpress.XtraGrid.Columns.GridColumn coldiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colcount;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txt_number;
        private DevExpress.XtraEditors.TextEdit txt_name;
        private DevExpress.XtraEditors.TextEdit txt_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txt_id;
        private DevExpress.XtraEditors.TextEdit txt_note;
        private System.Windows.Forms.Label label6;
    }
}
