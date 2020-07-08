namespace Installer
{
    partial class Country_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Country_form));
            this.lbl_selectcountry = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_goback = new System.Windows.Forms.Button();
            this.btn_proceed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_selectcountry
            // 
            this.lbl_selectcountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_selectcountry.AutoSize = true;
            this.lbl_selectcountry.Location = new System.Drawing.Point(24, 32);
            this.lbl_selectcountry.Name = "lbl_selectcountry";
            this.lbl_selectcountry.Size = new System.Drawing.Size(126, 13);
            this.lbl_selectcountry.TabIndex = 0;
            this.lbl_selectcountry.Text = "Please select the country";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(156, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btn_goback
            // 
            this.btn_goback.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_goback.Location = new System.Drawing.Point(30, 97);
            this.btn_goback.Name = "btn_goback";
            this.btn_goback.Size = new System.Drawing.Size(120, 23);
            this.btn_goback.TabIndex = 2;
            this.btn_goback.Text = "<<go back";
            this.btn_goback.UseVisualStyleBackColor = true;
            this.btn_goback.Click += new System.EventHandler(this.btn_goback_Click);
            // 
            // btn_proceed
            // 
            this.btn_proceed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_proceed.Location = new System.Drawing.Point(259, 97);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(120, 23);
            this.btn_proceed.TabIndex = 3;
            this.btn_proceed.Text = "proceed";
            this.btn_proceed.UseVisualStyleBackColor = true;
            this.btn_proceed.Click += new System.EventHandler(this.btn_proceed_Click);
            // 
            // Country_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 132);
            this.Controls.Add(this.btn_proceed);
            this.Controls.Add(this.btn_goback);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_selectcountry);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Country_form";
            this.Text = "Country";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_selectcountry;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_goback;
        private System.Windows.Forms.Button btn_proceed;
    }
}