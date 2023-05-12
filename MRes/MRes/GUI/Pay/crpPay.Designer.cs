
namespace MRes.GUI.Pay
{
    partial class crpPay
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
            this.crp = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crp
            // 
            this.crp.ActiveViewIndex = -1;
            this.crp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crp.Cursor = System.Windows.Forms.Cursors.Default;
            this.crp.DisplayStatusBar = false;
            this.crp.DisplayToolbar = false;
            this.crp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crp.Location = new System.Drawing.Point(0, 0);
            this.crp.Name = "crp";
            this.crp.Size = new System.Drawing.Size(537, 637);
            this.crp.TabIndex = 0;
            this.crp.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // crpPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 637);
            this.Controls.Add(this.crp);
            this.Name = "crpPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crp;
    }
}