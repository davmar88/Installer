namespace Installer
{
    partial class Location_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Location_form));
            this.btn_goback = new System.Windows.Forms.Button();
            this.btn_proceed = new System.Windows.Forms.Button();
            this.lbl_latitude = new System.Windows.Forms.Label();
            this.lbl_longitude = new System.Windows.Forms.Label();
            this.txt_latitude = new System.Windows.Forms.MaskedTextBox();
            this.txt_longitude = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btn_goback
            // 
            this.btn_goback.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_goback.Location = new System.Drawing.Point(28, 269);
            this.btn_goback.Name = "btn_goback";
            this.btn_goback.Size = new System.Drawing.Size(75, 23);
            this.btn_goback.TabIndex = 0;
            this.btn_goback.Text = "<<go back";
            this.btn_goback.UseVisualStyleBackColor = true;
            this.btn_goback.Click += new System.EventHandler(this.btn_goback_Click);
            // 
            // btn_proceed
            // 
            this.btn_proceed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_proceed.Location = new System.Drawing.Point(281, 269);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(75, 23);
            this.btn_proceed.TabIndex = 1;
            this.btn_proceed.Text = "proceed";
            this.btn_proceed.UseVisualStyleBackColor = true;
            this.btn_proceed.Click += new System.EventHandler(this.btn_proceed_Click);
            // 
            // lbl_latitude
            // 
            this.lbl_latitude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_latitude.AutoSize = true;
            this.lbl_latitude.Location = new System.Drawing.Point(25, 149);
            this.lbl_latitude.Name = "lbl_latitude";
            this.lbl_latitude.Size = new System.Drawing.Size(151, 13);
            this.lbl_latitude.TabIndex = 4;
            this.lbl_latitude.Text = "Opaque radio\'s current latitude example: -25.7241602";
            // 
            // lbl_longitude
            // 
            this.lbl_longitude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_longitude.AutoSize = true;
            this.lbl_longitude.Location = new System.Drawing.Point(25, 197);
            this.lbl_longitude.Name = "lbl_longitude";
            this.lbl_longitude.Size = new System.Drawing.Size(160, 13);
            this.lbl_longitude.TabIndex = 5;
            this.lbl_longitude.Text = "Opaque radio\'s current longitude example: +28.2005790";
            // 
            // txt_latitude
            // 
            this.txt_latitude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_latitude.Location = new System.Drawing.Point(28, 165);
            this.txt_latitude.Name = "txt_latitude";
            this.txt_latitude.Size = new System.Drawing.Size(328, 20);
            this.txt_latitude.TabIndex = 6;
            // 
            // txt_longitude
            // 
            this.txt_longitude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_longitude.Location = new System.Drawing.Point(28, 213);
            this.txt_longitude.Name = "txt_longitude";
            this.txt_longitude.Size = new System.Drawing.Size(328, 20);
            this.txt_longitude.TabIndex = 7;
            // 
            // Location_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 432);
            this.Controls.Add(this.txt_longitude);
            this.Controls.Add(this.txt_latitude);
            this.Controls.Add(this.lbl_longitude);
            this.Controls.Add(this.lbl_latitude);
            this.Controls.Add(this.btn_proceed);
            this.Controls.Add(this.btn_goback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Location_form";
            this.Text = "Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_goback;
        private System.Windows.Forms.Button btn_proceed;
        private System.Windows.Forms.Label lbl_latitude;
        private System.Windows.Forms.Label lbl_longitude;
        private System.Windows.Forms.MaskedTextBox txt_latitude;
        private System.Windows.Forms.MaskedTextBox txt_longitude;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}