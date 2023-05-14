
namespace MRes.GUI.Revenue
{
    partial class Revenueinventory
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.SwiftPlotDiagram swiftPlotDiagram1 = new DevExpress.XtraCharts.SwiftPlotDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SwiftPlotSeriesView swiftPlotSeriesView1 = new DevExpress.XtraCharts.SwiftPlotSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SwiftPlotSeriesView swiftPlotSeriesView2 = new DevExpress.XtraCharts.SwiftPlotSeriesView();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SwiftPlotSeriesView swiftPlotSeriesView3 = new DevExpress.XtraCharts.SwiftPlotSeriesView();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SwiftPlotSeriesView swiftPlotSeriesView4 = new DevExpress.XtraCharts.SwiftPlotSeriesView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.historyinventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyinventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.BackColor = System.Drawing.Color.Black;
            this.chartControl1.DataSource = this.historyinventoryBindingSource;
            swiftPlotDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            swiftPlotDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = swiftPlotDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentDataMember = "date";
            series1.Name = "Tổng Số Lượng Đầu";
            series1.ValueDataMembersSerializable = "quantityfirst";
            series1.View = swiftPlotSeriesView1;
            series2.ArgumentDataMember = "date";
            series2.Name = "Tổng Số Lượng nhập";
            series2.ValueDataMembersSerializable = "quantityin";
            series2.View = swiftPlotSeriesView2;
            series3.ArgumentDataMember = "date";
            series3.Name = "Tổng Số lượng xuất";
            series3.ValueDataMembersSerializable = "quantityout";
            series3.View = swiftPlotSeriesView3;
            series4.ArgumentDataMember = "date";
            series4.Name = "Tổng  Số lượng Cuối";
            series4.ValueDataMembersSerializable = "quantityend";
            series4.View = swiftPlotSeriesView4;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3,
        series4};
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "date";
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "quantityfirst";
            this.chartControl1.Size = new System.Drawing.Size(1187, 630);
            this.chartControl1.TabIndex = 0;
            // 
            // historyinventoryBindingSource
            // 
            this.historyinventoryBindingSource.DataSource = typeof(MRes.Models.Inventory.Historyinventory);
            // 
            // Revenueinventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 630);
            this.Controls.Add(this.chartControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Revenueinventory";
            this.Text = "Revenueinventory";
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyinventoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource historyinventoryBindingSource;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}