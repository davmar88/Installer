namespace Installer
{
    partial class Controlpanel_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controlpanel_form));
            this.btn_changecountry = new System.Windows.Forms.Button();
            this.btn_changelocation = new System.Windows.Forms.Button();
            this.btn_changeLAC = new System.Windows.Forms.Button();
            this.btn_changetowerinfo = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_goback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_changecountry
            // 
            this.btn_changecountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_changecountry.Location = new System.Drawing.Point(47, 26);
            this.btn_changecountry.Name = "btn_changecountry";
            this.btn_changecountry.Size = new System.Drawing.Size(302, 53);
            this.btn_changecountry.TabIndex = 0;
            this.btn_changecountry.Text = "Change the country";
            this.btn_changecountry.UseVisualStyleBackColor = true;
            this.btn_changecountry.Click += new System.EventHandler(this.btn_changecountry_Click);
            // 
            // btn_changelocation
            // 
            this.btn_changelocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_changelocation.Location = new System.Drawing.Point(47, 100);
            this.btn_changelocation.Name = "btn_changelocation";
            this.btn_changelocation.Size = new System.Drawing.Size(302, 53);
            this.btn_changelocation.TabIndex = 1;
            this.btn_changelocation.Text = "Change Longitude and Latitude of the box";
            this.btn_changelocation.UseVisualStyleBackColor = true;
            this.btn_changelocation.Click += new System.EventHandler(this.btn_changelocation_Click);
            // 
            // btn_changeLAC
            // 
            this.btn_changeLAC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_changeLAC.Location = new System.Drawing.Point(47, 176);
            this.btn_changeLAC.Name = "btn_changeLAC";
            this.btn_changeLAC.Size = new System.Drawing.Size(302, 53);
            this.btn_changeLAC.TabIndex = 2;
            this.btn_changeLAC.Text = "Change Location Area Code/DL_EARFCN/UL_EARFCN";
            this.btn_changeLAC.UseVisualStyleBackColor = true;
            this.btn_changeLAC.Click += new System.EventHandler(this.btn_changeLAC_Click);
            // 
            // btn_changetowerinfo
            // 
            this.btn_changetowerinfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_changetowerinfo.Location = new System.Drawing.Point(47, 250);
            this.btn_changetowerinfo.Name = "btn_changetowerinfo";
            this.btn_changetowerinfo.Size = new System.Drawing.Size(302, 53);
            this.btn_changetowerinfo.TabIndex = 3;
            this.btn_changetowerinfo.Text = "Change surrounding tower info of each network";
            this.btn_changetowerinfo.UseVisualStyleBackColor = true;
            this.btn_changetowerinfo.Click += new System.EventHandler(this.btn_changetowerinfo_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_logout.Location = new System.Drawing.Point(190, 343);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(159, 27);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Text = "Close and start Observer";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_goback
            // 
            this.btn_goback.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_goback.Location = new System.Drawing.Point(47, 343);
            this.btn_goback.Name = "btn_goback";
            this.btn_goback.Size = new System.Drawing.Size(107, 27);
            this.btn_goback.TabIndex = 5;
            this.btn_goback.Text = "<<go back";
            this.btn_goback.UseVisualStyleBackColor = true;
            this.btn_goback.Click += new System.EventHandler(this.btn_goback_Click);
            // 
            // Controlpanel_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 408);
            this.Controls.Add(this.btn_goback);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_changetowerinfo);
            this.Controls.Add(this.btn_changeLAC);
            this.Controls.Add(this.btn_changelocation);
            this.Controls.Add(this.btn_changecountry);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Controlpanel_form";
            this.Text = "Controlpanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_changecountry;
        private System.Windows.Forms.Button btn_changelocation;
        private System.Windows.Forms.Button btn_changeLAC;
        private System.Windows.Forms.Button btn_changetowerinfo;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_goback;
    }
}