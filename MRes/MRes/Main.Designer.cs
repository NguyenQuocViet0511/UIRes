
namespace MRes
{
    partial class Main
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_staff = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.btn_food = new DevExpress.XtraNavBar.NavBarItem();
            this.btn_category = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ManagerController = new DevExpress.XtraEditors.GroupControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_add = new DevExpress.XtraBars.BarButtonItem();
            this.btn_edit = new DevExpress.XtraBars.BarButtonItem();
            this.btn_delete = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_save = new DevExpress.XtraBars.BarButtonItem();
            this.btn_close = new DevExpress.XtraBars.BarButtonItem();
            this.btn_excel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl2 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.numbertextbox1 = new MRes.Lib.numbertextbox();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbertextbox1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // btn_staff
            // 
            this.btn_staff.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_staff.Appearance.Options.UseFont = true;
            this.btn_staff.Caption = "Nhân Viên";
            this.btn_staff.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_staff.ImageOptions.LargeImage")));
            this.btn_staff.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_staff.ImageOptions.SmallImage")));
            this.btn_staff.Name = "btn_staff";
            this.btn_staff.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btn_staff_LinkClicked);
            // 
            // navBarItem2
            // 
            this.navBarItem2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.navBarItem2.Appearance.Options.UseFont = true;
            this.navBarItem2.Caption = "Khách Hàng";
            this.navBarItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem2.ImageOptions.LargeImage")));
            this.navBarItem2.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem2.ImageOptions.SmallImage")));
            this.navBarItem2.Name = "navBarItem2";
            // 
            // btn_food
            // 
            this.btn_food.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_food.Appearance.Options.UseFont = true;
            this.btn_food.Caption = "Món Ăn";
            this.btn_food.ImageOptions.LargeImage = global::MRes.Properties.Resources.hamburger;
            this.btn_food.Name = "btn_food";
            this.btn_food.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btn_food_LinkClicked);
            // 
            // btn_category
            // 
            this.btn_category.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_category.Appearance.Options.UseFont = true;
            this.btn_category.Caption = "Nhóm Món";
            this.btn_category.ImageOptions.LargeImage = global::MRes.Properties.Resources.healthy_food;
            this.btn_category.Name = "btn_category";
            this.btn_category.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btn_category_LinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.navBarGroup1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.navBarGroup1.Appearance.BorderColor = System.Drawing.Color.Black;
            this.navBarGroup1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.navBarGroup1.Appearance.Options.UseBackColor = true;
            this.navBarGroup1.Appearance.Options.UseBorderColor = true;
            this.navBarGroup1.Appearance.Options.UseFont = true;
            this.navBarGroup1.Appearance.Options.UseTextOptions = true;
            this.navBarGroup1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.navBarGroup1.AppearanceBackground.BorderColor = System.Drawing.Color.Black;
            this.navBarGroup1.AppearanceBackground.Font = new System.Drawing.Font("Tahoma", 12F);
            this.navBarGroup1.AppearanceBackground.Options.UseBorderColor = true;
            this.navBarGroup1.AppearanceBackground.Options.UseFont = true;
            this.navBarGroup1.AppearanceHotTracked.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.navBarGroup1.AppearancePressed.Options.UseTextOptions = true;
            this.navBarGroup1.AppearancePressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.navBarGroup1.Caption = "Quản Lý";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroup1.ImageOptions.LargeImage = global::MRes.Properties.Resources.project_manager;
            this.navBarGroup1.ImageOptions.SmallImageSize = new System.Drawing.Size(20, 20);
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btn_staff),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btn_food),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btn_category),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem5
            // 
            this.navBarItem5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.navBarItem5.Appearance.Options.UseFont = true;
            this.navBarItem5.Caption = "Kho";
            this.navBarItem5.ImageOptions.LargeImage = global::MRes.Properties.Resources.warehouse;
            this.navBarItem5.Name = "navBarItem5";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.navBarGroup2.Appearance.Options.UseFont = true;
            this.navBarGroup2.Caption = "Gọi Món";
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.navBarGroup3.Appearance.Options.UseFont = true;
            this.navBarGroup3.Caption = "Thống Kê";
            this.navBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem6)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // navBarItem6
            // 
            this.navBarItem6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.navBarItem6.Appearance.Options.UseFont = true;
            this.navBarItem6.Caption = "Doanh Thu";
            this.navBarItem6.Name = "navBarItem6";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Appearance.Background.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.navBarControl1.Appearance.Background.Options.UseFont = true;
            this.navBarControl1.BackColor = System.Drawing.Color.Gray;
            this.navBarControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btn_staff,
            this.navBarItem2,
            this.btn_food,
            this.btn_category,
            this.navBarItem5,
            this.navBarItem6});
            this.navBarControl1.Location = new System.Drawing.Point(0, 157);
            this.navBarControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 268;
            this.navBarControl1.Size = new System.Drawing.Size(268, 553);
            this.navBarControl1.TabIndex = 8;
            this.navBarControl1.Text = "Nhân Viên";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Office 2010 Black");
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ManagerController
            // 
            this.ManagerController.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.ManagerController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManagerController.Location = new System.Drawing.Point(268, 157);
            this.ManagerController.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ManagerController.Name = "ManagerController";
            this.ManagerController.Size = new System.Drawing.Size(907, 553);
            this.ManagerController.TabIndex = 13;
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Lưu";
            this.barButtonItem4.Id = 5;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Hủy bỏ";
            this.barButtonItem5.Id = 6;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1";
            this.ribbonGalleryBarItem1.Id = 9;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "barHeaderItem1";
            this.barHeaderItem1.Id = 10;
            this.barHeaderItem1.ImageOptions.Image = global::MRes.Properties.Resources.logo;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 11;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup3,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_add);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_edit);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_delete);
            this.ribbonPageGroup3.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // btn_add
            // 
            this.btn_add.Caption = "Thêm";
            this.btn_add.Id = 2;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.LargeImage")));
            this.btn_add.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add.ItemAppearance.Disabled.ForeColor = System.Drawing.Color.White;
            this.btn_add.ItemAppearance.Disabled.Options.UseFont = true;
            this.btn_add.ItemAppearance.Disabled.Options.UseForeColor = true;
            this.btn_add.ItemAppearance.Disabled.Options.UseTextOptions = true;
            this.btn_add.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Black;
            this.btn_add.ItemAppearance.Hovered.Options.UseFont = true;
            this.btn_add.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btn_add.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ItemAppearance.Normal.ForeColor = System.Drawing.Color.White;
            this.btn_add.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_add.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btn_add.ItemInMenuAppearance.Hovered.BackColor = System.Drawing.Color.Gray;
            this.btn_add.ItemInMenuAppearance.Hovered.Options.UseBackColor = true;
            this.btn_add.LargeWidth = 70;
            this.btn_add.Name = "btn_add";
            this.btn_add.SmallWithoutTextWidth = 200;
            this.btn_add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_add_ItemClick);
            // 
            // btn_edit
            // 
            this.btn_edit.Caption = "Sửa";
            this.btn_edit.Id = 3;
            this.btn_edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.btn_edit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.btn_edit.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_edit.ItemAppearance.Hovered.Options.UseFont = true;
            this.btn_edit.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btn_edit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ItemAppearance.Normal.ForeColor = System.Drawing.Color.White;
            this.btn_edit.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_edit.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btn_edit.LargeWidth = 70;
            this.btn_edit.Name = "btn_edit";
            // 
            // btn_delete
            // 
            this.btn_delete.Caption = "Xóa";
            this.btn_delete.Id = 4;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.btn_delete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.btn_delete.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btn_delete.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btn_delete.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ItemAppearance.Normal.ForeColor = System.Drawing.Color.White;
            this.btn_delete.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_delete.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btn_delete.LargeWidth = 70;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_delete_ItemClick);
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_save);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_close);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_excel);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // btn_save
            // 
            this.btn_save.Caption = "Lưu";
            this.btn_save.Id = 8;
            this.btn_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.btn_save.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.LargeImage")));
            this.btn_save.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Black;
            this.btn_save.ItemAppearance.Hovered.Options.UseFont = true;
            this.btn_save.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btn_save.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ItemAppearance.Normal.ForeColor = System.Drawing.Color.White;
            this.btn_save.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_save.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btn_save.LargeWidth = 70;
            this.btn_save.Name = "btn_save";
            this.btn_save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_save_ItemClick);
            // 
            // btn_close
            // 
            this.btn_close.Caption = "Hủy bỏ";
            this.btn_close.Id = 7;
            this.btn_close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.btn_close.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.btn_close.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btn_close.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btn_close.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ItemAppearance.Normal.ForeColor = System.Drawing.Color.White;
            this.btn_close.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_close.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btn_close.LargeWidth = 70;
            this.btn_close.Name = "btn_close";
            this.btn_close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_close_ItemClick);
            // 
            // btn_excel
            // 
            this.btn_excel.Caption = "Xuất Excel";
            this.btn_excel.Id = 13;
            this.btn_excel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_excel.ImageOptions.Image")));
            this.btn_excel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_excel.ImageOptions.LargeImage")));
            this.btn_excel.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excel.ItemAppearance.Disabled.ForeColor = System.Drawing.Color.White;
            this.btn_excel.ItemAppearance.Disabled.Options.UseFont = true;
            this.btn_excel.ItemAppearance.Disabled.Options.UseForeColor = true;
            this.btn_excel.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Black;
            this.btn_excel.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btn_excel.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excel.ItemAppearance.Normal.ForeColor = System.Drawing.Color.White;
            this.btn_excel.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_excel.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btn_excel.Name = "btn_excel";
            // 
            // ribbonControl2
            // 
            this.ribbonControl2.BackColor = System.Drawing.Color.White;
            this.ribbonControl2.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Purple;
            this.ribbonControl2.ExpandCollapseItem.Id = 0;
            this.ribbonControl2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ribbonControl2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl2.ExpandCollapseItem,
            this.ribbonControl2.SearchEditItem,
            this.btn_add,
            this.btn_edit,
            this.btn_delete,
            this.btn_close,
            this.btn_save,
            this.barSubItem1,
            this.btn_excel});
            this.ribbonControl2.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl2.MaxItemId = 14;
            this.ribbonControl2.Name = "ribbonControl2";
            this.ribbonControl2.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl2.Size = new System.Drawing.Size(1175, 157);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Id = 12;
            this.barSubItem1.LargeWidth = 200;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // numbertextbox1
            // 
            this.numbertextbox1.Location = new System.Drawing.Point(639, 101);
            this.numbertextbox1.MenuManager = this.ribbonControl2;
            this.numbertextbox1.Name = "numbertextbox1";
            this.numbertextbox1.Size = new System.Drawing.Size(185, 22);
            this.numbertextbox1.TabIndex = 15;
            // 
            // Main
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 710);
            this.Controls.Add(this.numbertextbox1);
            this.Controls.Add(this.ManagerController);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.ribbonControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Ribbon = this.ribbonControl2;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbertextbox1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraNavBar.NavBarItem btn_staff;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem btn_food;
        private DevExpress.XtraNavBar.NavBarItem btn_category;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.GroupControl ManagerController;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btn_add;
        private DevExpress.XtraBars.BarButtonItem btn_edit;
        private DevExpress.XtraBars.BarButtonItem btn_delete;
        private DevExpress.XtraBars.BarButtonItem btn_close;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_save;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btn_excel;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private Lib.numbertextbox numbertextbox1;
    }
}