
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
            this.layoutController = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // layoutController
            // 
            this.layoutController.AutoScroll = true;
            this.layoutController.AutoSize = true;
            this.layoutController.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.layoutController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutController.Location = new System.Drawing.Point(0, 0);
            this.layoutController.Name = "layoutController";
            this.layoutController.Padding = new System.Windows.Forms.Padding(10);
            this.layoutController.Size = new System.Drawing.Size(1115, 604);
            this.layoutController.TabIndex = 0;
            // 
            // QL_Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 604);
            this.Controls.Add(this.layoutController);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QL_Food";
            this.Text = "QL_Food";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layoutController;
    }
}