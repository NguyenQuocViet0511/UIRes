
namespace MRes.GUI.Login
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_username = new DevExpress.XtraEditors.TextEdit();
            this.txt_password = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_login = new DevExpress.XtraEditors.SimpleButton();
            this.btn_out = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(777, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài Khoản ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(777, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật Khẩu ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(782, 256);
            this.txt_username.Name = "txt_username";
            this.txt_username.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txt_username.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Properties.Appearance.Options.UseBackColor = true;
            this.txt_username.Properties.Appearance.Options.UseFont = true;
            this.txt_username.Properties.Appearance.Options.UseImage = true;
            this.txt_username.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_username.Properties.ContextImageOptions.Image = global::MRes.Properties.Resources.programmer;
            this.txt_username.Size = new System.Drawing.Size(295, 34);
            this.txt_username.TabIndex = 4;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(782, 365);
            this.txt_password.Name = "txt_password";
            this.txt_password.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txt_password.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Properties.Appearance.Options.UseBackColor = true;
            this.txt_password.Properties.Appearance.Options.UseBorderColor = true;
            this.txt_password.Properties.Appearance.Options.UseFont = true;
            this.txt_password.Properties.Appearance.Options.UseImage = true;
            this.txt_password.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_password.Properties.ContextImageOptions.Image = global::MRes.Properties.Resources.key;
            this.txt_password.Properties.UseSystemPasswordChar = true;
            this.txt_password.Size = new System.Drawing.Size(295, 34);
            this.txt_password.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MRes.Properties.Resources.ten;
            this.pictureBox2.Location = new System.Drawing.Point(815, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(224, 99);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::MRes.Properties.Resources.Untitled;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(724, 629);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(782, 400);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(295, 2);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(782, 296);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(295, 2);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // btn_login
            // 
            this.btn_login.Appearance.Options.UseBorderColor = true;
            this.btn_login.Location = new System.Drawing.Point(783, 440);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(295, 54);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Đăng Nhập";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_out
            // 
            this.btn_out.Location = new System.Drawing.Point(783, 513);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(295, 54);
            this.btn_out.TabIndex = 9;
            this.btn_out.Text = "Thoát";
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1120, 629);
            this.Controls.Add(this.btn_out);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.txt_username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txt_username;
        private DevExpress.XtraEditors.TextEdit txt_password;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private DevExpress.XtraEditors.SimpleButton btn_login;
        private DevExpress.XtraEditors.SimpleButton btn_out;
    }
}