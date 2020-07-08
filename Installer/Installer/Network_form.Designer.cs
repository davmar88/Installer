namespace Installer
{
    partial class Network_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Network_form));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_networkname = new System.Windows.Forms.Label();
            this.btn_goback = new System.Windows.Forms.Button();
            this.btn_proceed = new System.Windows.Forms.Button();
            this.lbl_totalnetworks = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_lac = new System.Windows.Forms.Label();
            this.lbl_dlearfcn = new System.Windows.Forms.Label();
            this.lbl_ulearfcn = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_pcellid = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_LAC = new System.Windows.Forms.ComboBox();
            this.cb_pcellid = new System.Windows.Forms.ComboBox();
            this.txt_pcellid = new Installer.WaterMarkTextBox();
            this.txt_ulearfcn = new Installer.WaterMarkTextBox();
            this.txt_dlearfcn = new Installer.WaterMarkTextBox();
            this.txt_lac = new Installer.WaterMarkTextBox();
            this.btn_skip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter details for network ";
            // 
            // lbl_networkname
            // 
            this.lbl_networkname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_networkname.AutoSize = true;
            this.lbl_networkname.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_networkname.Location = new System.Drawing.Point(182, 13);
            this.lbl_networkname.Name = "lbl_networkname";
            this.lbl_networkname.Size = new System.Drawing.Size(100, 23);
            this.lbl_networkname.TabIndex = 1;
            this.lbl_networkname.Text = "network n";
            // 
            // btn_goback
            // 
            this.btn_goback.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_goback.Location = new System.Drawing.Point(34, 522);
            this.btn_goback.Name = "btn_goback";
            this.btn_goback.Size = new System.Drawing.Size(75, 23);
            this.btn_goback.TabIndex = 5;
            this.btn_goback.Text = "<< go back";
            this.btn_goback.UseVisualStyleBackColor = true;
            this.btn_goback.Click += new System.EventHandler(this.btn_goback_Click);
            // 
            // btn_proceed
            // 
            this.btn_proceed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_proceed.Location = new System.Drawing.Point(289, 522);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(75, 23);
            this.btn_proceed.TabIndex = 6;
            this.btn_proceed.Text = "proceed";
            this.btn_proceed.UseVisualStyleBackColor = true;
            this.btn_proceed.Click += new System.EventHandler(this.btn_proceed_Click);
            // 
            // lbl_totalnetworks
            // 
            this.lbl_totalnetworks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_totalnetworks.AutoSize = true;
            this.lbl_totalnetworks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalnetworks.Location = new System.Drawing.Point(245, 498);
            this.lbl_totalnetworks.Name = "lbl_totalnetworks";
            this.lbl_totalnetworks.Size = new System.Drawing.Size(109, 13);
            this.lbl_totalnetworks.TabIndex = 8;
            this.lbl_totalnetworks.Text = "total networks left";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total networks to do:";
            // 
            // lbl_lac
            // 
            this.lbl_lac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_lac.AutoSize = true;
            this.lbl_lac.Location = new System.Drawing.Point(31, 60);
            this.lbl_lac.Name = "lbl_lac";
            this.lbl_lac.Size = new System.Drawing.Size(309, 13);
            this.lbl_lac.TabIndex = 9;
            this.lbl_lac.Text = "Current Location Area Code (LAC/TAC) of the specified network";
            // 
            // lbl_dlearfcn
            // 
            this.lbl_dlearfcn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_dlearfcn.AutoSize = true;
            this.lbl_dlearfcn.Location = new System.Drawing.Point(31, 388);
            this.lbl_dlearfcn.Name = "lbl_dlearfcn";
            this.lbl_dlearfcn.Size = new System.Drawing.Size(307, 13);
            this.lbl_dlearfcn.TabIndex = 10;
            this.lbl_dlearfcn.Text = "Downlink EARFCN of specified network example: 1862.6 (MHz) Max: 1880";
            // 
            // lbl_ulearfcn
            // 
            this.lbl_ulearfcn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ulearfcn.AutoSize = true;
            this.lbl_ulearfcn.Location = new System.Drawing.Point(31, 441);
            this.lbl_ulearfcn.Name = "lbl_ulearfcn";
            this.lbl_ulearfcn.Size = new System.Drawing.Size(293, 13);
            this.lbl_ulearfcn.TabIndex = 11;
            this.lbl_ulearfcn.Text = "Uplink EARFCN of specified network example: 1762.6 (MHz) Max: 1785";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(298, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Increment or Decrement TAC/LAC, example of value: 1 or -1. ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(335, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "This is not mandatory, but this will be here in case the tower struggles ";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(313, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "to pick up phones in the surrounding environment. This is just for ";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "calibration purposes. Values can be between 5 and -5:";
            // 
            // lbl_pcellid
            // 
            this.lbl_pcellid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_pcellid.AutoSize = true;
            this.lbl_pcellid.Location = new System.Drawing.Point(31, 217);
            this.lbl_pcellid.Name = "lbl_pcellid";
            this.lbl_pcellid.Size = new System.Drawing.Size(192, 13);
            this.lbl_pcellid.TabIndex = 17;
            this.lbl_pcellid.Text = "Current Physical Cellid (Max 3 numbers)";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(264, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "calibration purposes. Values can be between 5 and -5:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 300);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(313, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "to pick up phones in the surrounding environment. This is just for ";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(335, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "This is not mandatory, but this will be here in case the tower struggles ";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 274);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(319, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Increment or Decrement Physical Cellid, example of value: 1 or -1. ";
            // 
            // cb_LAC
            // 
            this.cb_LAC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_LAC.FormattingEnabled = true;
            this.cb_LAC.Items.AddRange(new object[] {
            "",
            "-5",
            "-4",
            "-3",
            "-2",
            "-1",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_LAC.Location = new System.Drawing.Point(34, 171);
            this.cb_LAC.Name = "cb_LAC";
            this.cb_LAC.Size = new System.Drawing.Size(85, 21);
            this.cb_LAC.TabIndex = 23;
            // 
            // cb_pcellid
            // 
            this.cb_pcellid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_pcellid.FormattingEnabled = true;
            this.cb_pcellid.Items.AddRange(new object[] {
            "",
            "-5",
            "-4",
            "-3",
            "-2",
            "-1",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_pcellid.Location = new System.Drawing.Point(32, 333);
            this.cb_pcellid.Name = "cb_pcellid";
            this.cb_pcellid.Size = new System.Drawing.Size(85, 21);
            this.cb_pcellid.TabIndex = 24;
            // 
            // txt_pcellid
            // 
            this.txt_pcellid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_pcellid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_pcellid.Location = new System.Drawing.Point(32, 233);
            this.txt_pcellid.Name = "txt_pcellid";
            this.txt_pcellid.Size = new System.Drawing.Size(330, 20);
            this.txt_pcellid.TabIndex = 16;
            this.txt_pcellid.WaterMarkColor = System.Drawing.Color.Gray;
            this.txt_pcellid.WaterMarkText = "Downlink EARFCN of specified network example: 1862.6  (MHz)";
            // 
            // txt_ulearfcn
            // 
            this.txt_ulearfcn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ulearfcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_ulearfcn.Location = new System.Drawing.Point(34, 454);
            this.txt_ulearfcn.Name = "txt_ulearfcn";
            this.txt_ulearfcn.Size = new System.Drawing.Size(330, 20);
            this.txt_ulearfcn.TabIndex = 4;
            this.txt_ulearfcn.WaterMarkColor = System.Drawing.Color.Gray;
            this.txt_ulearfcn.WaterMarkText = "Uplink EARFCN of specified network example: 1762.6  (MHz)";
            // 
            // txt_dlearfcn
            // 
            this.txt_dlearfcn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_dlearfcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_dlearfcn.Location = new System.Drawing.Point(34, 404);
            this.txt_dlearfcn.Name = "txt_dlearfcn";
            this.txt_dlearfcn.Size = new System.Drawing.Size(330, 20);
            this.txt_dlearfcn.TabIndex = 3;
            this.txt_dlearfcn.WaterMarkColor = System.Drawing.Color.Gray;
            this.txt_dlearfcn.WaterMarkText = "Downlink EARFCN of specified network example: 1862.6  (MHz)";
            // 
            // txt_lac
            // 
            this.txt_lac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_lac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_lac.Location = new System.Drawing.Point(34, 76);
            this.txt_lac.Name = "txt_lac";
            this.txt_lac.Size = new System.Drawing.Size(330, 20);
            this.txt_lac.TabIndex = 2;
            this.txt_lac.WaterMarkColor = System.Drawing.Color.Gray;
            this.txt_lac.WaterMarkText = "Current Area Location Code (LAC /TAC) of the specified network";
            // 
            // btn_skip
            // 
            this.btn_skip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_skip.Location = new System.Drawing.Point(149, 522);
            this.btn_skip.Name = "btn_skip";
            this.btn_skip.Size = new System.Drawing.Size(100, 23);
            this.btn_skip.TabIndex = 25;
            this.btn_skip.Text = "skip network>>";
            this.btn_skip.UseVisualStyleBackColor = true;
            this.btn_skip.Click += new System.EventHandler(this.btn_skip_Click);
            // 
            // Network_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 578);
            this.Controls.Add(this.btn_skip);
            this.Controls.Add(this.cb_pcellid);
            this.Controls.Add(this.cb_LAC);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbl_pcellid);
            this.Controls.Add(this.txt_pcellid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_ulearfcn);
            this.Controls.Add(this.lbl_dlearfcn);
            this.Controls.Add(this.lbl_lac);
            this.Controls.Add(this.lbl_totalnetworks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_proceed);
            this.Controls.Add(this.btn_goback);
            this.Controls.Add(this.txt_ulearfcn);
            this.Controls.Add(this.txt_dlearfcn);
            this.Controls.Add(this.txt_lac);
            this.Controls.Add(this.lbl_networkname);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Network_form";
            this.Text = "Network Details";
            this.Load += new System.EventHandler(this.frm_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_networkname;
        private WaterMarkTextBox txt_lac;
        private WaterMarkTextBox txt_dlearfcn;
        private WaterMarkTextBox txt_ulearfcn;
        private System.Windows.Forms.Button btn_goback;
        private System.Windows.Forms.Button btn_proceed;
        private System.Windows.Forms.Label lbl_totalnetworks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_lac;
        private System.Windows.Forms.Label lbl_dlearfcn;
        private System.Windows.Forms.Label lbl_ulearfcn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_pcellid;
        private WaterMarkTextBox txt_pcellid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cb_LAC;
        private System.Windows.Forms.ComboBox cb_pcellid;
        private System.Windows.Forms.Button btn_skip;
    }
}