namespace Installer
{
    partial class Login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_form));
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_uniqueboxid = new System.Windows.Forms.Label();
            this.txt_uniqueboxid = new Installer.WaterMarkTextBox();
            this.txt_password = new Installer.WaterMarkTextBox();
            this.txt_username = new Installer.WaterMarkTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login.Location = new System.Drawing.Point(92, 256);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(235, 23);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(89, 152);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(96, 13);
            this.lbl_username.TabIndex = 6;
            this.lbl_username.Text = "Opaque Username";
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(89, 202);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 7;
            this.lbl_password.Text = "Password";
            // 
            // lbl_uniqueboxid
            // 
            this.lbl_uniqueboxid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_uniqueboxid.AutoSize = true;
            this.lbl_uniqueboxid.Location = new System.Drawing.Point(89, 101);
            this.lbl_uniqueboxid.Name = "lbl_uniqueboxid";
            this.lbl_uniqueboxid.Size = new System.Drawing.Size(117, 13);
            this.lbl_uniqueboxid.TabIndex = 9;
            this.lbl_uniqueboxid.Text = "Opaque Unique Box ID";
            // 
            // txt_uniqueboxid
            // 
            this.txt_uniqueboxid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_uniqueboxid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_uniqueboxid.Location = new System.Drawing.Point(92, 117);
            this.txt_uniqueboxid.Name = "txt_uniqueboxid";
            this.txt_uniqueboxid.Size = new System.Drawing.Size(235, 20);
            this.txt_uniqueboxid.TabIndex = 8;
            this.txt_uniqueboxid.WaterMarkColor = System.Drawing.Color.Gray;
            this.txt_uniqueboxid.WaterMarkText = "Username/Opaque Unique Box ID";
            // 
            // txt_password
            // 
            this.txt_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_password.Location = new System.Drawing.Point(92, 218);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(235, 20);
            this.txt_password.TabIndex = 2;
            this.txt_password.WaterMarkColor = System.Drawing.Color.Gray;
            this.txt_password.WaterMarkText = "Password";
            // 
            // txt_username
            // 
            this.txt_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_username.Location = new System.Drawing.Point(92, 168);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(235, 20);
            this.txt_username.TabIndex = 1;
            this.txt_username.WaterMarkColor = System.Drawing.Color.Gray;
            this.txt_username.WaterMarkText = "Username/Opaque Unique Box ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.lbl_uniqueboxid);
            this.groupBox1.Controls.Add(this.txt_uniqueboxid);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.lbl_username);
            this.groupBox1.Controls.Add(this.lbl_password);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Location = new System.Drawing.Point(23, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 378);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 434);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_form";
            this.Text = "Opaque Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private WaterMarkTextBox txt_username;
        private WaterMarkTextBox txt_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_uniqueboxid;
        private WaterMarkTextBox txt_uniqueboxid;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

