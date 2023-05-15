
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesTemplate seriesTemplate1 = new DevExpress.XtraCharts.SeriesTemplate();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.historyinventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyinventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.AutoLayout = false;
            this.chartControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.CrosshairOptions.ContentShowMode = DevExpress.XtraCharts.CrosshairContentShowMode.Label;
            this.chartControl1.DataSource = this.historyinventoryBindingSource;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentDataMember = "name";
            series1.Name = "Ban Đầu";
            series1.ValueDataMembersSerializable = "quantityfirst";
            series2.ArgumentDataMember = "name";
            series2.Name = "Nhập";
            series2.ValueDataMembersSerializable = "quantityfirst";
            series3.ArgumentDataMember = "name";
            series3.Name = "Xuất";
            series3.ValueDataMembersSerializable = "quantityout";
            series4.ArgumentDataMember = "name";
            series4.Name = "Tổng Cuối";
            series4.ValueDataMembersSerializable = "quantityend";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3,
        series4};
            seriesTemplate1.ArgumentDataMember = "name";
            seriesTemplate1.ColorDataMember = "quantityin";
            seriesTemplate1.ValueDataMembersSerializable = "quantityfirst";
            this.chartControl1.SeriesTemplate.ArgumentDrillTemplate = seriesTemplate1;
            this.chartControl1.SeriesTemplate.ToolTipPointPattern = "{S}{V}";
            this.chartControl1.SeriesTemplate.ToolTipSeriesPattern = "";
            lineSeriesView1.LineMarkerOptions.Size = 8;
            this.chartControl1.SeriesTemplate.View = lineSeriesView1;
            this.chartControl1.Size = new System.Drawing.Size(1187, 630);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.ToolTipOptions.ShowForSeries = true;
            this.chartControl1.Click += new System.EventHandler(this.chartControl1_Click);
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
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyinventoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource historyinventoryBindingSource;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}