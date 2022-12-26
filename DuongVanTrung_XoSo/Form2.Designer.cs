namespace DuongVanTrung_XoSo
{
    partial class Form2
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
            this.radio_btn_auto = new System.Windows.Forms.RadioButton();
            this.radio_btn_manual = new System.Windows.Forms.RadioButton();
            this.gr_box_manual = new System.Windows.Forms.GroupBox();
            this.cb_HCM = new System.Windows.Forms.CheckBox();
            this.cb_DaN = new System.Windows.Forms.CheckBox();
            this.cb_HN = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.time_auto = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gr_box_auto = new System.Windows.Forms.GroupBox();
            this.gr_box_manual.SuspendLayout();
            this.gr_box_auto.SuspendLayout();
            this.SuspendLayout();
            // 
            // radio_btn_auto
            // 
            this.radio_btn_auto.AutoSize = true;
            this.radio_btn_auto.BackColor = System.Drawing.Color.Transparent;
            this.radio_btn_auto.Checked = true;
            this.radio_btn_auto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radio_btn_auto.Location = new System.Drawing.Point(248, 92);
            this.radio_btn_auto.Name = "radio_btn_auto";
            this.radio_btn_auto.Size = new System.Drawing.Size(107, 20);
            this.radio_btn_auto.TabIndex = 0;
            this.radio_btn_auto.TabStop = true;
            this.radio_btn_auto.Text = "Quay tự động";
            this.radio_btn_auto.UseVisualStyleBackColor = false;
            this.radio_btn_auto.CheckedChanged += new System.EventHandler(this.radio_btn_auto_CheckedChanged);
            // 
            // radio_btn_manual
            // 
            this.radio_btn_manual.AutoSize = true;
            this.radio_btn_manual.Location = new System.Drawing.Point(413, 92);
            this.radio_btn_manual.Name = "radio_btn_manual";
            this.radio_btn_manual.Size = new System.Drawing.Size(113, 20);
            this.radio_btn_manual.TabIndex = 1;
            this.radio_btn_manual.Text = "Quay thủ công";
            this.radio_btn_manual.UseVisualStyleBackColor = true;
            this.radio_btn_manual.CheckedChanged += new System.EventHandler(this.radio_btn_manual_CheckedChanged);
            // 
            // gr_box_manual
            // 
            this.gr_box_manual.BackColor = System.Drawing.Color.Transparent;
            this.gr_box_manual.Controls.Add(this.cb_HCM);
            this.gr_box_manual.Controls.Add(this.cb_DaN);
            this.gr_box_manual.Controls.Add(this.cb_HN);
            this.gr_box_manual.Controls.Add(this.label2);
            this.gr_box_manual.Location = new System.Drawing.Point(274, 154);
            this.gr_box_manual.Name = "gr_box_manual";
            this.gr_box_manual.Size = new System.Drawing.Size(258, 170);
            this.gr_box_manual.TabIndex = 4;
            this.gr_box_manual.TabStop = false;
            this.gr_box_manual.Text = "Quay thủ công";
            this.gr_box_manual.Visible = false;
            // 
            // cb_HCM
            // 
            this.cb_HCM.AutoSize = true;
            this.cb_HCM.Location = new System.Drawing.Point(84, 119);
            this.cb_HCM.Name = "cb_HCM";
            this.cb_HCM.Size = new System.Drawing.Size(80, 20);
            this.cb_HCM.TabIndex = 5;
            this.cb_HCM.Text = "TP.HCM";
            this.cb_HCM.UseVisualStyleBackColor = true;
            // 
            // cb_DaN
            // 
            this.cb_DaN.AutoSize = true;
            this.cb_DaN.Location = new System.Drawing.Point(84, 93);
            this.cb_DaN.Name = "cb_DaN";
            this.cb_DaN.Size = new System.Drawing.Size(82, 20);
            this.cb_DaN.TabIndex = 5;
            this.cb_DaN.Text = "Đà Nẵng";
            this.cb_DaN.UseVisualStyleBackColor = true;
            // 
            // cb_HN
            // 
            this.cb_HN.AutoSize = true;
            this.cb_HN.Location = new System.Drawing.Point(84, 67);
            this.cb_HN.Name = "cb_HN";
            this.cb_HN.Size = new System.Drawing.Size(71, 20);
            this.cb_HN.TabIndex = 2;
            this.cb_HN.Text = "Hà Nội";
            this.cb_HN.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn đài";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(331, 354);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(98, 37);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // time_auto
            // 
            this.time_auto.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time_auto.Location = new System.Drawing.Point(107, 58);
            this.time_auto.Name = "time_auto";
            this.time_auto.ShowUpDown = true;
            this.time_auto.Size = new System.Drawing.Size(117, 22);
            this.time_auto.TabIndex = 0;
            this.time_auto.Value = new System.DateTime(2022, 11, 3, 17, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn ngày :";
            // 
            // gr_box_auto
            // 
            this.gr_box_auto.BackColor = System.Drawing.Color.Transparent;
            this.gr_box_auto.Controls.Add(this.label1);
            this.gr_box_auto.Controls.Add(this.time_auto);
            this.gr_box_auto.Location = new System.Drawing.Point(268, 154);
            this.gr_box_auto.Name = "gr_box_auto";
            this.gr_box_auto.Size = new System.Drawing.Size(246, 133);
            this.gr_box_auto.TabIndex = 3;
            this.gr_box_auto.TabStop = false;
            this.gr_box_auto.Text = "Quay tự động";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gr_box_manual);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.gr_box_auto);
            this.Controls.Add(this.radio_btn_manual);
            this.Controls.Add(this.radio_btn_auto);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form2";
            this.Text = "CONFIG";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gr_box_manual.ResumeLayout(false);
            this.gr_box_manual.PerformLayout();
            this.gr_box_auto.ResumeLayout(false);
            this.gr_box_auto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_btn_auto;
        private System.Windows.Forms.RadioButton radio_btn_manual;
        private System.Windows.Forms.GroupBox gr_box_manual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_HCM;
        private System.Windows.Forms.CheckBox cb_DaN;
        private System.Windows.Forms.CheckBox cb_HN;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.DateTimePicker time_auto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gr_box_auto;
    }
}