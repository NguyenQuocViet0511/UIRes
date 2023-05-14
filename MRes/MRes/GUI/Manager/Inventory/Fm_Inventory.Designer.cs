
namespace MRes.GUI.Manager.Inventory
{
    partial class Fm_Inventory
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gird_materialBill = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbillid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.grid_materialBillinfo = new DevExpress.XtraGrid.GridControl();
            this.GidController = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.panel_controller = new DevExpress.XtraEditors.PanelControl();
            this.txt_number = new System.Windows.Forms.NumericUpDown();
            this.txt_id = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbn_material = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btn_created = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_AddMore = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gird_materialBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_materialBillinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GidController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_controller)).BeginInit();
            this.panel_controller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbn_material.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gird_materialBill);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(572, 585);
            this.panelControl1.TabIndex = 9;
            // 
            // gird_materialBill
            // 
            this.gird_materialBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gird_materialBill.Location = new System.Drawing.Point(2, 63);
            this.gird_materialBill.MainView = this.gridView1;
            this.gird_materialBill.Name = "gird_materialBill";
            this.gird_materialBill.Size = new System.Drawing.Size(568, 520);
            this.gird_materialBill.TabIndex = 10;
            this.gird_materialBill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gird_materialBill.Click += new System.EventHandler(this.gird_materialBill_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colbillid,
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.GridControl = this.gird_materialBill;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Nhập Vào Tên / hoặc từ gì đó để tìm kiếm";
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colbillid
            // 
            this.colbillid.Caption = "Mã Hóa Đơn";
            this.colbillid.FieldName = "id";
            this.colbillid.Name = "colbillid";
            this.colbillid.OptionsColumn.AllowEdit = false;
            this.colbillid.Visible = true;
            this.colbillid.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Thời Gian Nhập";
            this.gridColumn1.FieldName = "timein";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tổng Tiền";
            this.gridColumn3.FieldName = "sum";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Trạng Thái";
            this.gridColumn4.FieldName = "status";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 61);
            this.label1.TabIndex = 9;
            this.label1.Text = "Danh Sách Phiếu Nhập ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.grid_materialBillinfo);
            this.panelControl3.Controls.Add(this.panelControl5);
            this.panelControl3.Controls.Add(this.panel_controller);
            this.panelControl3.Controls.Add(this.label2);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(872, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(565, 585);
            this.panelControl3.TabIndex = 10;
            // 
            // grid_materialBillinfo
            // 
            this.grid_materialBillinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.grid_materialBillinfo.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grid_materialBillinfo.Location = new System.Drawing.Point(2, 231);
            this.grid_materialBillinfo.MainView = this.GidController;
            this.grid_materialBillinfo.Name = "grid_materialBillinfo";
            this.grid_materialBillinfo.Size = new System.Drawing.Size(561, 352);
            this.grid_materialBillinfo.TabIndex = 37;
            this.grid_materialBillinfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn10,
            this.gridColumn9});
            this.GidController.GridControl = this.grid_materialBillinfo;
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
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Mã nguyên Liệu";
            this.gridColumn5.FieldName = "id";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Mã Hóa Đơn";
            this.gridColumn6.FieldName = "id_materialbill";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "số lượng";
            this.gridColumn7.FieldName = "count";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Tổng Tiền";
            this.gridColumn8.FieldName = "sum";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 5;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Giá ";
            this.gridColumn10.FieldName = "price";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Tên nguyên Liệu";
            this.gridColumn9.FieldName = "name";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.btn_delete);
            this.panelControl5.Controls.Add(this.btn_add);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl5.Location = new System.Drawing.Point(2, 193);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(561, 38);
            this.panelControl5.TabIndex = 36;
            // 
            // btn_delete
            // 
            this.btn_delete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.btn_delete.Appearance.Options.UseBackColor = true;
            this.btn_delete.Location = new System.Drawing.Point(251, 9);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 33;
            this.btn_delete.Text = "Xóa Bỏ";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.btn_add.Appearance.Options.UseBackColor = true;
            this.btn_add.Location = new System.Drawing.Point(152, 9);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 29;
            this.btn_add.Text = "thêm vào";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel_controller
            // 
            this.panel_controller.Controls.Add(this.txt_number);
            this.panel_controller.Controls.Add(this.txt_id);
            this.panel_controller.Controls.Add(this.label5);
            this.panel_controller.Controls.Add(this.label9);
            this.panel_controller.Controls.Add(this.cbn_material);
            this.panel_controller.Controls.Add(this.label3);
            this.panel_controller.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_controller.Enabled = false;
            this.panel_controller.Location = new System.Drawing.Point(2, 63);
            this.panel_controller.Name = "panel_controller";
            this.panel_controller.Size = new System.Drawing.Size(561, 130);
            this.panel_controller.TabIndex = 11;
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(150, 90);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(120, 23);
            this.txt_number.TabIndex = 35;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            // 
            // 
            // 
            this.txt_id.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_id.Border.BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_id.Border.BorderBottomWidth = 3;
            this.txt_id.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.txt_id.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txt_id.Border.BorderRightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_id.Border.BorderRightWidth = 3;
            this.txt_id.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.txt_id.Border.Class = "TextBoxBorder";
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(149, 15);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(344, 24);
            this.txt_id.TabIndex = 34;
            this.txt_id.WatermarkText = "Mã tạo tự động nếu chưa có";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(41, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Mã Phiếu nhập";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(79, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Số lượng";
            // 
            // cbn_material
            // 
            this.cbn_material.EditValue = "";
            this.cbn_material.Location = new System.Drawing.Point(149, 49);
            this.cbn_material.Name = "cbn_material";
            this.cbn_material.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbn_material.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.cbn_material.Properties.Appearance.Options.UseFont = true;
            this.cbn_material.Properties.Appearance.Options.UseForeColor = true;
            this.cbn_material.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.cbn_material.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbn_material.Properties.PopupView = this.gridLookUpEdit1View;
            this.cbn_material.Size = new System.Drawing.Size(344, 24);
            this.cbn_material.TabIndex = 22;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(34, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tên Nguyên liêu";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(561, 61);
            this.label2.TabIndex = 10;
            this.label2.Text = "Chi Tiết Phiếu Nhập";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Controls.Add(this.simpleButton3);
            this.panelControl2.Controls.Add(this.btn_AddMore);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(572, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(300, 585);
            this.panelControl2.TabIndex = 11;
            // 
            // panelControl4
            // 
            this.panelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl4.Controls.Add(this.btn_created);
            this.panelControl4.Location = new System.Drawing.Point(0, 275);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(300, 72);
            this.panelControl4.TabIndex = 34;
            // 
            // btn_created
            // 
            this.btn_created.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.btn_created.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_created.Appearance.Options.UseBackColor = true;
            this.btn_created.Appearance.Options.UseFont = true;
            this.btn_created.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_created.Location = new System.Drawing.Point(2, 2);
            this.btn_created.Name = "btn_created";
            this.btn_created.Size = new System.Drawing.Size(296, 68);
            this.btn_created.TabIndex = 35;
            this.btn_created.Text = "Tạo HD";
            this.btn_created.Click += new System.EventHandler(this.btn_created_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Location = new System.Drawing.Point(0, 391);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(300, 60);
            this.simpleButton3.TabIndex = 32;
            this.simpleButton3.Text = "Hủy";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btn_AddMore
            // 
            this.btn_AddMore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddMore.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.btn_AddMore.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddMore.Appearance.Options.UseBackColor = true;
            this.btn_AddMore.Appearance.Options.UseFont = true;
            this.btn_AddMore.Location = new System.Drawing.Point(0, 173);
            this.btn_AddMore.Name = "btn_AddMore";
            this.btn_AddMore.Size = new System.Drawing.Size(300, 60);
            this.btn_AddMore.TabIndex = 31;
            this.btn_AddMore.Text = "Thêm";
            this.btn_AddMore.Click += new System.EventHandler(this.btn_AddMore_Click);
            // 
            // Fm_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 585);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fm_Inventory";
            this.Text = "Fm_Inventory";
            this.Load += new System.EventHandler(this.Fm_Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gird_materialBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_materialBillinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GidController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_controller)).EndInit();
            this.panel_controller.ResumeLayout(false);
            this.panel_controller.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbn_material.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gird_materialBill;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colbillid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.PanelControl panel_controller;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.GridLookUpEdit cbn_material;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btn_AddMore;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_id;
        private System.Windows.Forms.NumericUpDown txt_number;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton btn_created;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraGrid.GridControl grid_materialBillinfo;
        private DevExpress.XtraGrid.Views.Grid.GridView GidController;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.PanelControl panelControl5;
    }
}