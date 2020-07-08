namespace Installer
{
    partial class Tower_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tower_form));
            this.lbl_networkname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_totalnetworks = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtone_latitude = new Installer.WaterMarkTextBox();
            this.txttwo_latitude = new Installer.WaterMarkTextBox();
            this.txttwo_longitude = new Installer.WaterMarkTextBox();
            this.txtone_longitude = new Installer.WaterMarkTextBox();
            this.txttwo_range = new Installer.WaterMarkTextBox();
            this.txtone_range = new Installer.WaterMarkTextBox();
            this.txttwo_phcellid = new Installer.WaterMarkTextBox();
            this.txtone_phcellid = new Installer.WaterMarkTextBox();
            this.btn_goback = new System.Windows.Forms.Button();
            this.btn_proceed = new System.Windows.Forms.Button();
            this.lbl_latone = new System.Windows.Forms.Label();
            this.lbl_lattwo = new System.Windows.Forms.Label();
            this.lbl_lonone = new System.Windows.Forms.Label();
            this.lbl_lontwo = new System.Windows.Forms.Label();
            this.lbl_pcione = new System.Windows.Forms.Label();
            this.lbl_pcitwo = new System.Windows.Forms.Label();
            this.lbl_rangeone = new System.Windows.Forms.Label();
            this.lbl_rangetwo = new System.Windows.Forms.Label();
            this.lbl_lactwo = new System.Windows.Forms.Label();
            this.lbl_lacone = new System.Windows.Forms.Label();
            this.txttwo_tac = new Installer.WaterMarkTextBox();
            this.txtone_tac = new Installer.WaterMarkTextBox();
            this.btn_skip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_networkname
            // 
            this.lbl_networkname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_networkname.AutoSize = true;
            this.lbl_networkname.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_networkname.Location = new System.Drawing.Point(310, 29);
            this.lbl_networkname.Name = "lbl_networkname";
            this.lbl_networkname.Size = new System.Drawing.Size(100, 23);
            this.lbl_networkname.TabIndex = 3;
            this.lbl_networkname.Text = "network n";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter details for surrounding towers for network:";
            // 
            // lbl_totalnetworks
            // 
            this.lbl_totalnetworks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_totalnetworks.AutoSize = true;
            this.lbl_totalnetworks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalnetworks.Location = new System.Drawing.Point(403, 416);
            this.lbl_totalnetworks.Name = "lbl_totalnetworks";
            this.lbl_totalnetworks.Size = new System.Drawing.Size(87, 13);
            this.lbl_totalnetworks.TabIndex = 10;
            this.lbl_totalnetworks.Text = "total networks";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total networks to do:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tower 1:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tower 2:";
            // 
            // txtone_latitude
            // 
            this.txtone_latitude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtone_latitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtone_latitude.Location = new System.Drawing.Point(58, 118);
            this.txtone_latitude.Name = "txtone_latitude";
            this.txtone_latitude.Size = new System.Drawing.Size(199, 20);
            this.txtone_latitude.TabIndex = 13;
            this.txtone_latitude.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtone_latitude.WaterMarkText = "Latitude of tower 1";
            // 
            // txttwo_latitude
            // 
            this.txttwo_latitude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttwo_latitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txttwo_latitude.Location = new System.Drawing.Point(295, 118);
            this.txttwo_latitude.Name = "txttwo_latitude";
            this.txttwo_latitude.Size = new System.Drawing.Size(195, 20);
            this.txttwo_latitude.TabIndex = 14;
            this.txttwo_latitude.WaterMarkColor = System.Drawing.Color.Gray;
            this.txttwo_latitude.WaterMarkText = "Latitude of tower 2";
            // 
            // txttwo_longitude
            // 
            this.txttwo_longitude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttwo_longitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txttwo_longitude.Location = new System.Drawing.Point(295, 173);
            this.txttwo_longitude.Name = "txttwo_longitude";
            this.txttwo_longitude.Size = new System.Drawing.Size(195, 20);
            this.txttwo_longitude.TabIndex = 16;
            this.txttwo_longitude.WaterMarkColor = System.Drawing.Color.Gray;
            this.txttwo_longitude.WaterMarkText = "Longitude of tower 2";
            // 
            // txtone_longitude
            // 
            this.txtone_longitude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtone_longitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtone_longitude.Location = new System.Drawing.Point(58, 173);
            this.txtone_longitude.Name = "txtone_longitude";
            this.txtone_longitude.Size = new System.Drawing.Size(199, 20);
            this.txtone_longitude.TabIndex = 15;
            this.txtone_longitude.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtone_longitude.WaterMarkText = "Longitude of tower 1";
            // 
            // txttwo_range
            // 
            this.txttwo_range.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttwo_range.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txttwo_range.Location = new System.Drawing.Point(295, 382);
            this.txttwo_range.Name = "txttwo_range";
            this.txttwo_range.Size = new System.Drawing.Size(195, 20);
            this.txttwo_range.TabIndex = 20;
            this.txttwo_range.WaterMarkColor = System.Drawing.Color.Gray;
            this.txttwo_range.WaterMarkText = "Range of signal in meters of tower 2";
            // 
            // txtone_range
            // 
            this.txtone_range.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtone_range.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtone_range.Location = new System.Drawing.Point(58, 382);
            this.txtone_range.Name = "txtone_range";
            this.txtone_range.Size = new System.Drawing.Size(199, 20);
            this.txtone_range.TabIndex = 19;
            this.txtone_range.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtone_range.WaterMarkText = "Range of signal in meters of tower 1";
            // 
            // txttwo_phcellid
            // 
            this.txttwo_phcellid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttwo_phcellid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txttwo_phcellid.Location = new System.Drawing.Point(295, 316);
            this.txttwo_phcellid.Name = "txttwo_phcellid";
            this.txttwo_phcellid.Size = new System.Drawing.Size(195, 20);
            this.txttwo_phcellid.TabIndex = 18;
            this.txttwo_phcellid.WaterMarkColor = System.Drawing.Color.Gray;
            this.txttwo_phcellid.WaterMarkText = "Physical Cell ID of tower 2";
            // 
            // txtone_phcellid
            // 
            this.txtone_phcellid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtone_phcellid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtone_phcellid.Location = new System.Drawing.Point(58, 316);
            this.txtone_phcellid.Name = "txtone_phcellid";
            this.txtone_phcellid.Size = new System.Drawing.Size(199, 20);
            this.txtone_phcellid.TabIndex = 17;
            this.txtone_phcellid.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtone_phcellid.WaterMarkText = "Physical Cell ID of tower 1";
            // 
            // btn_goback
            // 
            this.btn_goback.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_goback.Location = new System.Drawing.Point(58, 449);
            this.btn_goback.Name = "btn_goback";
            this.btn_goback.Size = new System.Drawing.Size(75, 23);
            this.btn_goback.TabIndex = 21;
            this.btn_goback.Text = "<<go back";
            this.btn_goback.UseVisualStyleBackColor = true;
            this.btn_goback.Click += new System.EventHandler(this.btn_goback_Click);
            // 
            // btn_proceed
            // 
            this.btn_proceed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_proceed.Location = new System.Drawing.Point(415, 449);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(75, 23);
            this.btn_proceed.TabIndex = 22;
            this.btn_proceed.Text = "proceed";
            this.btn_proceed.UseVisualStyleBackColor = true;
            this.btn_proceed.Click += new System.EventHandler(this.btn_proceed_Click);
            // 
            // lbl_latone
            // 
            this.lbl_latone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_latone.AutoSize = true;
            this.lbl_latone.Location = new System.Drawing.Point(55, 102);
            this.lbl_latone.Name = "lbl_latone";
            this.lbl_latone.Size = new System.Drawing.Size(95, 13);
            this.lbl_latone.TabIndex = 23;
            this.lbl_latone.Text = "Latitude of tower 1";
            // 
            // lbl_lattwo
            // 
            this.lbl_lattwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_lattwo.AutoSize = true;
            this.lbl_lattwo.Location = new System.Drawing.Point(292, 102);
            this.lbl_lattwo.Name = "lbl_lattwo";
            this.lbl_lattwo.Size = new System.Drawing.Size(95, 13);
            this.lbl_lattwo.TabIndex = 24;
            this.lbl_lattwo.Text = "Latitude of tower 2";
            // 
            // lbl_lonone
            // 
            this.lbl_lonone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_lonone.AutoSize = true;
            this.lbl_lonone.Location = new System.Drawing.Point(55, 157);
            this.lbl_lonone.Name = "lbl_lonone";
            this.lbl_lonone.Size = new System.Drawing.Size(104, 13);
            this.lbl_lonone.TabIndex = 25;
            this.lbl_lonone.Text = "Longitude of tower 1";
            // 
            // lbl_lontwo
            // 
            this.lbl_lontwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_lontwo.AutoSize = true;
            this.lbl_lontwo.Location = new System.Drawing.Point(292, 157);
            this.lbl_lontwo.Name = "lbl_lontwo";
            this.lbl_lontwo.Size = new System.Drawing.Size(104, 13);
            this.lbl_lontwo.TabIndex = 26;
            this.lbl_lontwo.Text = "Longitude of tower 2";
            // 
            // lbl_pcione
            // 
            this.lbl_pcione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_pcione.AutoSize = true;
            this.lbl_pcione.Location = new System.Drawing.Point(55, 300);
            this.lbl_pcione.Name = "lbl_pcione";
            this.lbl_pcione.Size = new System.Drawing.Size(130, 13);
            this.lbl_pcione.TabIndex = 27;
            this.lbl_pcione.Text = "Physical Cell ID of tower 1";
            // 
            // lbl_pcitwo
            // 
            this.lbl_pcitwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_pcitwo.AutoSize = true;
            this.lbl_pcitwo.Location = new System.Drawing.Point(292, 300);
            this.lbl_pcitwo.Name = "lbl_pcitwo";
            this.lbl_pcitwo.Size = new System.Drawing.Size(130, 13);
            this.lbl_pcitwo.TabIndex = 28;
            this.lbl_pcitwo.Text = "Physical Cell ID of tower 2";
            // 
            // lbl_rangeone
            // 
            this.lbl_rangeone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_rangeone.AutoSize = true;
            this.lbl_rangeone.Location = new System.Drawing.Point(55, 366);
            this.lbl_rangeone.Name = "lbl_rangeone";
            this.lbl_rangeone.Size = new System.Drawing.Size(176, 13);
            this.lbl_rangeone.TabIndex = 29;
            this.lbl_rangeone.Text = "Range of signal in meters of tower 1";
            // 
            // lbl_rangetwo
            // 
            this.lbl_rangetwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_rangetwo.AutoSize = true;
            this.lbl_rangetwo.Location = new System.Drawing.Point(292, 366);
            this.lbl_rangetwo.Name = "lbl_rangetwo";
            this.lbl_rangetwo.Size = new System.Drawing.Size(176, 13);
            this.lbl_rangetwo.TabIndex = 30;
            this.lbl_rangetwo.Text = "Range of signal in meters of tower 2";
            // 
            // lbl_lactwo
            // 
            this.lbl_lactwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_lactwo.AutoSize = true;
            this.lbl_lactwo.Location = new System.Drawing.Point(291, 234);
            this.lbl_lactwo.Name = "lbl_lactwo";
            this.lbl_lactwo.Size = new System.Drawing.Size(103, 13);
            this.lbl_lactwo.TabIndex = 34;
            this.lbl_lactwo.Text = "TAC/LAC of tower 2";
            // 
            // lbl_lacone
            // 
            this.lbl_lacone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_lacone.AutoSize = true;
            this.lbl_lacone.Location = new System.Drawing.Point(54, 234);
            this.lbl_lacone.Name = "lbl_lacone";
            this.lbl_lacone.Size = new System.Drawing.Size(103, 13);
            this.lbl_lacone.TabIndex = 33;
            this.lbl_lacone.Text = "TAC/LAC of tower 1";
            // 
            // txttwo_tac
            // 
            this.txttwo_tac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttwo_tac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txttwo_tac.Location = new System.Drawing.Point(294, 250);
            this.txttwo_tac.Name = "txttwo_tac";
            this.txttwo_tac.Size = new System.Drawing.Size(195, 20);
            this.txttwo_tac.TabIndex = 32;
            this.txttwo_tac.WaterMarkColor = System.Drawing.Color.Gray;
            this.txttwo_tac.WaterMarkText = "Physical Cell ID of tower 2";
            // 
            // txtone_tac
            // 
            this.txtone_tac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtone_tac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtone_tac.Location = new System.Drawing.Point(57, 250);
            this.txtone_tac.Name = "txtone_tac";
            this.txtone_tac.Size = new System.Drawing.Size(199, 20);
            this.txtone_tac.TabIndex = 31;
            this.txtone_tac.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtone_tac.WaterMarkText = "Physical Cell ID of tower 1";
            // 
            // btn_skip
            // 
            this.btn_skip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_skip.Location = new System.Drawing.Point(219, 449);
            this.btn_skip.Name = "btn_skip";
            this.btn_skip.Size = new System.Drawing.Size(100, 23);
            this.btn_skip.TabIndex = 35;
            this.btn_skip.Text = "skip network>>";
            this.btn_skip.UseVisualStyleBackColor = true;
            this.btn_skip.Click += new System.EventHandler(this.btn_skip_Click);
            // 
            // Tower_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 504);
            this.Controls.Add(this.btn_skip);
            this.Controls.Add(this.lbl_lactwo);
            this.Controls.Add(this.lbl_lacone);
            this.Controls.Add(this.txttwo_tac);
            this.Controls.Add(this.txtone_tac);
            this.Controls.Add(this.lbl_rangetwo);
            this.Controls.Add(this.lbl_rangeone);
            this.Controls.Add(this.lbl_pcitwo);
            this.Controls.Add(this.lbl_pcione);
            this.Controls.Add(this.lbl_lontwo);
            this.Controls.Add(this.lbl_lonone);
            this.Controls.Add(this.lbl_lattwo);
            this.Controls.Add(this.lbl_latone);
            this.Controls.Add(this.btn_proceed);
            this.Controls.Add(this.btn_goback);
            this.Controls.Add(this.txttwo_range);
            this.Controls.Add(this.txtone_range);
            this.Controls.Add(this.txttwo_phcellid);
            this.Controls.Add(this.txtone_phcellid);
            this.Controls.Add(this.txttwo_longitude);
            this.Controls.Add(this.txtone_longitude);
            this.Controls.Add(this.txttwo_latitude);
            this.Controls.Add(this.txtone_latitude);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_totalnetworks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_networkname);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tower_form";
            this.Text = "Tower Details";
            this.Load += new System.EventHandler(this.frm_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_networkname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_totalnetworks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private WaterMarkTextBox txtone_latitude;
        private WaterMarkTextBox txttwo_latitude;
        private WaterMarkTextBox txttwo_longitude;
        private WaterMarkTextBox txtone_longitude;
        private WaterMarkTextBox txttwo_range;
        private WaterMarkTextBox txtone_range;
        private WaterMarkTextBox txttwo_phcellid;
        private WaterMarkTextBox txtone_phcellid;
        private System.Windows.Forms.Button btn_goback;
        private System.Windows.Forms.Button btn_proceed;
        private System.Windows.Forms.Label lbl_latone;
        private System.Windows.Forms.Label lbl_lattwo;
        private System.Windows.Forms.Label lbl_lonone;
        private System.Windows.Forms.Label lbl_lontwo;
        private System.Windows.Forms.Label lbl_pcione;
        private System.Windows.Forms.Label lbl_pcitwo;
        private System.Windows.Forms.Label lbl_rangeone;
        private System.Windows.Forms.Label lbl_rangetwo;
        private System.Windows.Forms.Label lbl_lactwo;
        private System.Windows.Forms.Label lbl_lacone;
        private WaterMarkTextBox txttwo_tac;
        private WaterMarkTextBox txtone_tac;
        private System.Windows.Forms.Button btn_skip;
    }
}