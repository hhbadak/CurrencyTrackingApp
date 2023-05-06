namespace CurrencyTrackingApp
{
    partial class RateList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RateList));
            this.cb_list = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_buying = new System.Windows.Forms.TextBox();
            this.tb_selling = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_getRate = new System.Windows.Forms.Button();
            this.lbl_code = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_list
            // 
            this.cb_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_list.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cb_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_list.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.cb_list.FormattingEnabled = true;
            this.cb_list.Items.AddRange(new object[] {
            "ABD DOLARI",
            "AVUSTRALYA DOLARI",
            "AZERBAYCAN YENİ MANATI",
            "BİRLEŞİK ARAP EMİRLİKLERİ DİRHEMİ",
            "BULGAR LEVASI",
            "ÇİN YUANI",
            "DANİMARKA KRONU",
            "EURO",
            "GÜNEY KORE WONU",
            "İNGİLİZ STERLİNİ",
            "İRAN RİYALİ",
            "İSVEÇ KRONU",
            "İSVİÇRE FRANGI",
            "JAPON YENİ",
            "KANADA DOLARI",
            "KATAR RİYALİ",
            "KUVEYT DİNARI",
            "NORVEÇ KRONU",
            "PAKİSTAN RUPİSİ",
            "RUMEN LEYİ",
            "RUS RUBLESİ",
            "SUUDİ ARABİSTAN RİYALİ"});
            this.cb_list.Location = new System.Drawing.Point(60, 57);
            this.cb_list.Name = "cb_list";
            this.cb_list.Size = new System.Drawing.Size(347, 28);
            this.cb_list.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "PARA BİRİMİNİ SEÇİNİZ";
            // 
            // tb_buying
            // 
            this.tb_buying.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tb_buying.Enabled = false;
            this.tb_buying.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_buying.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb_buying.Location = new System.Drawing.Point(139, 265);
            this.tb_buying.Name = "tb_buying";
            this.tb_buying.ReadOnly = true;
            this.tb_buying.Size = new System.Drawing.Size(185, 30);
            this.tb_buying.TabIndex = 3;
            // 
            // tb_selling
            // 
            this.tb_selling.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tb_selling.Enabled = false;
            this.tb_selling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_selling.ForeColor = System.Drawing.Color.White;
            this.tb_selling.Location = new System.Drawing.Point(139, 340);
            this.tb_selling.Name = "tb_selling";
            this.tb_selling.ReadOnly = true;
            this.tb_selling.Size = new System.Drawing.Size(185, 30);
            this.tb_selling.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(151, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "ALIŞ FİYATI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(150, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "SATIŞ FİYATI";
            // 
            // btn_getRate
            // 
            this.btn_getRate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_getRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_getRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_getRate.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_getRate.Location = new System.Drawing.Point(161, 91);
            this.btn_getRate.Name = "btn_getRate";
            this.btn_getRate.Size = new System.Drawing.Size(118, 33);
            this.btn_getRate.TabIndex = 2;
            this.btn_getRate.Text = "GETİR";
            this.btn_getRate.UseVisualStyleBackColor = false;
            this.btn_getRate.Click += new System.EventHandler(this.btn_getRate_Click);
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_code.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_code.Location = new System.Drawing.Point(125, 146);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(0, 16);
            this.lbl_code.TabIndex = 0;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_name.Location = new System.Drawing.Point(125, 192);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 16);
            this.lbl_name.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "KUR KODU =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Location = new System.Drawing.Point(29, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "KUR ADI =";
            // 
            // RateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(485, 382);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_code);
            this.Controls.Add(this.btn_getRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_list);
            this.Controls.Add(this.tb_selling);
            this.Controls.Add(this.tb_buying);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(503, 429);
            this.MinimumSize = new System.Drawing.Size(503, 429);
            this.Name = "RateList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kur Listele";
            this.Load += new System.EventHandler(this.RateList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_buying;
        private System.Windows.Forms.TextBox tb_selling;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_getRate;
        private System.Windows.Forms.Label lbl_code;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}