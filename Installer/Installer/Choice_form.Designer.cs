namespace Installer
{
    partial class Choice_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choice_form));
            this.btn_controlpanel = new System.Windows.Forms.Button();
            this.btn_createnew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_controlpanel
            // 
            this.btn_controlpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_controlpanel.Location = new System.Drawing.Point(28, 32);
            this.btn_controlpanel.Name = "btn_controlpanel";
            this.btn_controlpanel.Size = new System.Drawing.Size(322, 40);
            this.btn_controlpanel.TabIndex = 0;
            this.btn_controlpanel.Text = "Go to Control Panel";
            this.btn_controlpanel.UseVisualStyleBackColor = true;
            this.btn_controlpanel.Click += new System.EventHandler(this.btn_controlpanel_Click);
            // 
            // btn_createnew
            // 
            this.btn_createnew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_createnew.Location = new System.Drawing.Point(28, 90);
            this.btn_createnew.Name = "btn_createnew";
            this.btn_createnew.Size = new System.Drawing.Size(322, 43);
            this.btn_createnew.TabIndex = 1;
            this.btn_createnew.Text = "Create new config files";
            this.btn_createnew.UseVisualStyleBackColor = true;
            this.btn_createnew.Click += new System.EventHandler(this.btn_createnew_Click);
            // 
            // Choice_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 145);
            this.Controls.Add(this.btn_createnew);
            this.Controls.Add(this.btn_controlpanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Choice_form";
            this.Text = "Choice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_controlpanel;
        private System.Windows.Forms.Button btn_createnew;
    }
}