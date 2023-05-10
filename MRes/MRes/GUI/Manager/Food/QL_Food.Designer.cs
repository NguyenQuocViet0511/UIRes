
namespace MRes.GUI.Manager.Food
{
    partial class QL_Food
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
            this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatuscategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcategoryname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_next = new DevExpress.XtraEditors.SimpleButton();
            this.btn_prev = new DevExpress.XtraEditors.SimpleButton();
            this.btn_last = new DevExpress.XtraEditors.SimpleButton();
            this.btn_first = new DevExpress.XtraEditors.SimpleButton();
            this.panel_info = new DevExpress.XtraEditors.PanelControl();
            this.txt_price = new DevExpress.XtraEditors.TextEdit();
            this.cbn_category = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txt_count = new MRes.Lib.numbertextbox();
            this.txt_discount = new MRes.Lib.numbertextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_created_by = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbn_status = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.cbn_statuscategory = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GidController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_info)).BeginInit();
            this.panel_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_price.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbn_category.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_count.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_discount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_created_by.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbn_status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbn_statuscategory.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridController
            // 
            this.gridController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridController.Location = new System.Drawing.Point(0, 149);
            this.gridController.MainView = this.GidController;
            this.gridController.Name = "gridController";
            this.gridController.Size = new System.Drawing.Size(1376, 401);
            this.gridController.TabIndex = 6;
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
            this.colcount,
            this.colstatus,
            this.colcategory,
            this.colusername,
            this.colstatuscategory,
            this.colcategoryname});
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
            // colstatus
            // 
            this.colstatus.Caption = "Trạng Thái";
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            this.colstatus.Visible = true;
            this.colstatus.VisibleIndex = 9;
            // 
            // colcategory
            // 
            this.colcategory.Caption = "Mã Nhóm Món";
            this.colcategory.FieldName = "id_category";
            this.colcategory.Name = "colcategory";
            this.colcategory.Visible = true;
            this.colcategory.VisibleIndex = 5;
            // 
            // colusername
            // 
            this.colusername.Caption = "Tạo Bởi";
            this.colusername.FieldName = "username";
            this.colusername.Name = "colusername";
            this.colusername.Visible = true;
            this.colusername.VisibleIndex = 8;
            // 
            // colstatuscategory
            // 
            this.colstatuscategory.Caption = "Trạng Thái Nhóm Món";
            this.colstatuscategory.FieldName = "category_status";
            this.colstatuscategory.Name = "colstatuscategory";
            this.colstatuscategory.Visible = true;
            this.colstatuscategory.VisibleIndex = 7;
            // 
            // colcategoryname
            // 
            this.colcategoryname.Caption = "Tên Nhóm Món";
            this.colcategoryname.FieldName = "category";
            this.colcategoryname.Name = "colcategoryname";
            this.colcategoryname.Visible = true;
            this.colcategoryname.VisibleIndex = 6;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_next);
            this.panelControl2.Controls.Add(this.btn_prev);
            this.panelControl2.Controls.Add(this.btn_last);
            this.panelControl2.Controls.Add(this.btn_first);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 550);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1376, 54);
            this.panelControl2.TabIndex = 5;
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
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
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
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
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
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
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
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // panel_info
            // 
            this.panel_info.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panel_info.Appearance.Options.UseBackColor = true;
            this.panel_info.Controls.Add(this.cbn_statuscategory);
            this.panel_info.Controls.Add(this.label9);
            this.panel_info.Controls.Add(this.txt_price);
            this.panel_info.Controls.Add(this.cbn_category);
            this.panel_info.Controls.Add(this.txt_count);
            this.panel_info.Controls.Add(this.txt_discount);
            this.panel_info.Controls.Add(this.label4);
            this.panel_info.Controls.Add(this.txt_created_by);
            this.panel_info.Controls.Add(this.pictureEdit1);
            this.panel_info.Controls.Add(this.label8);
            this.panel_info.Controls.Add(this.label7);
            this.panel_info.Controls.Add(this.cbn_status);
            this.panel_info.Controls.Add(this.label6);
            this.panel_info.Controls.Add(this.label5);
            this.panel_info.Controls.Add(this.txt_name);
            this.panel_info.Controls.Add(this.label3);
            this.panel_info.Controls.Add(this.label2);
            this.panel_info.Controls.Add(this.label1);
            this.panel_info.Controls.Add(this.txt_id);
            this.panel_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_info.Location = new System.Drawing.Point(0, 0);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(1376, 149);
            this.panel_info.TabIndex = 4;
            // 
            // txt_price
            // 
            this.txt_price.EditValue = 0D;
            this.txt_price.Location = new System.Drawing.Point(91, 62);
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
            this.txt_price.Size = new System.Drawing.Size(228, 24);
            this.txt_price.TabIndex = 25;
            // 
            // cbn_category
            // 
            this.cbn_category.EditValue = "";
            this.cbn_category.Location = new System.Drawing.Point(91, 105);
            this.cbn_category.Name = "cbn_category";
            this.cbn_category.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbn_category.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.cbn_category.Properties.Appearance.Options.UseFont = true;
            this.cbn_category.Properties.Appearance.Options.UseForeColor = true;
            this.cbn_category.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.cbn_category.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbn_category.Properties.PopupView = this.gridLookUpEdit1View;
            this.cbn_category.Size = new System.Drawing.Size(228, 24);
            this.cbn_category.TabIndex = 7;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txt_count
            // 
            this.txt_count.Enabled = false;
            this.txt_count.Location = new System.Drawing.Point(830, 66);
            this.txt_count.Name = "txt_count";
            this.txt_count.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_count.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txt_count.Properties.Appearance.Options.UseFont = true;
            this.txt_count.Properties.Appearance.Options.UseForeColor = true;
            this.txt_count.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txt_count.Size = new System.Drawing.Size(265, 24);
            this.txt_count.TabIndex = 24;
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(424, 62);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discount.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txt_discount.Properties.Appearance.Options.UseFont = true;
            this.txt_discount.Properties.Appearance.Options.UseForeColor = true;
            this.txt_discount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txt_discount.Size = new System.Drawing.Size(278, 24);
            this.txt_discount.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(732, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Số lượng bán";
            // 
            // txt_created_by
            // 
            this.txt_created_by.Enabled = false;
            this.txt_created_by.Location = new System.Drawing.Point(830, 20);
            this.txt_created_by.Name = "txt_created_by";
            this.txt_created_by.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_created_by.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txt_created_by.Properties.Appearance.Options.UseFont = true;
            this.txt_created_by.Properties.Appearance.Options.UseForeColor = true;
            this.txt_created_by.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txt_created_by.Size = new System.Drawing.Size(265, 24);
            this.txt_created_by.TabIndex = 19;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit1.Location = new System.Drawing.Point(1134, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(230, 121);
            this.pictureEdit1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gray;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(16, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nhóm Món";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(732, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tạo Bởi ";
            // 
            // cbn_status
            // 
            this.cbn_status.EditValue = "Chọn trạng thái";
            this.cbn_status.Location = new System.Drawing.Point(830, 109);
            this.cbn_status.Name = "cbn_status";
            this.cbn_status.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbn_status.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.cbn_status.Properties.Appearance.Options.UseFont = true;
            this.cbn_status.Properties.Appearance.Options.UseForeColor = true;
            this.cbn_status.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.cbn_status.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbn_status.Properties.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbn_status.Size = new System.Drawing.Size(265, 24);
            this.cbn_status.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(336, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Trạng Thái Nhóm Món";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(336, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giảm Giá";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(424, 21);
            this.txt_name.Name = "txt_name";
            this.txt_name.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txt_name.Properties.Appearance.Options.UseFont = true;
            this.txt_name.Properties.Appearance.Options.UseForeColor = true;
            this.txt_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txt_name.Size = new System.Drawing.Size(278, 24);
            this.txt_name.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giá Bán";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(336, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Món";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Món";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(91, 21);
            this.txt_id.Name = "txt_id";
            this.txt_id.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txt_id.Properties.Appearance.Options.UseFont = true;
            this.txt_id.Properties.Appearance.Options.UseForeColor = true;
            this.txt_id.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txt_id.Size = new System.Drawing.Size(228, 24);
            this.txt_id.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(732, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Trạng Thái";
            // 
            // cbn_statuscategory
            // 
            this.cbn_statuscategory.EditValue = "Chọn trạng thái";
            this.cbn_statuscategory.Enabled = false;
            this.cbn_statuscategory.Location = new System.Drawing.Point(487, 105);
            this.cbn_statuscategory.Name = "cbn_statuscategory";
            this.cbn_statuscategory.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbn_statuscategory.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.cbn_statuscategory.Properties.Appearance.Options.UseFont = true;
            this.cbn_statuscategory.Properties.Appearance.Options.UseForeColor = true;
            this.cbn_statuscategory.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.cbn_statuscategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbn_statuscategory.Properties.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbn_statuscategory.Size = new System.Drawing.Size(215, 24);
            this.cbn_statuscategory.TabIndex = 27;
            // 
            // QL_Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 604);
            this.Controls.Add(this.gridController);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panel_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QL_Food";
            this.Text = "QL_Food";
            this.Load += new System.EventHandler(this.QL_Food_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GidController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_info)).EndInit();
            this.panel_info.ResumeLayout(false);
            this.panel_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_price.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbn_category.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_count.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_discount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_created_by.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbn_status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbn_statuscategory.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridController;
        private DevExpress.XtraGrid.Views.Grid.GridView GidController;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colprice;
        private DevExpress.XtraGrid.Columns.GridColumn coldiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colcount;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_next;
        private DevExpress.XtraEditors.SimpleButton btn_prev;
        private DevExpress.XtraEditors.SimpleButton btn_last;
        private DevExpress.XtraEditors.SimpleButton btn_first;
        private DevExpress.XtraEditors.PanelControl panel_info;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ComboBoxEdit cbn_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_id;
        private DevExpress.XtraGrid.Columns.GridColumn colcategory;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txt_created_by;
        private Lib.numbertextbox txt_discount;
        private Lib.numbertextbox txt_count;
        private DevExpress.XtraEditors.GridLookUpEdit cbn_category;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txt_price;
        private DevExpress.XtraGrid.Columns.GridColumn colstatuscategory;
        private DevExpress.XtraGrid.Columns.GridColumn colcategoryname;
        private DevExpress.XtraEditors.ComboBoxEdit cbn_statuscategory;
        private System.Windows.Forms.Label label9;
    }
}