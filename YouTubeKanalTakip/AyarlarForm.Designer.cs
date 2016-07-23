namespace YouTubeKanalTakip
{
    partial class AyarlarForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.apiKeyKaydetButton = new System.Windows.Forms.Button();
            this.apiKeyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.otoTaramaKapali = new System.Windows.Forms.RadioButton();
            this.otoTaramaAcik = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.otoTaramaAralik = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.alarmAcik = new System.Windows.Forms.RadioButton();
            this.alarmKapali = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.kanalAlarmCombo = new System.Windows.Forms.ComboBox();
            this.kanalAlarmCal = new System.Windows.Forms.Button();
            this.videoAlarmCal = new System.Windows.Forms.Button();
            this.videoAlarmCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otoTaramaAralik)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.apiKeyKaydetButton);
            this.groupBox1.Controls.Add(this.apiKeyTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(377, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Api key";
            // 
            // apiKeyKaydetButton
            // 
            this.apiKeyKaydetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.apiKeyKaydetButton.Location = new System.Drawing.Point(82, 63);
            this.apiKeyKaydetButton.Name = "apiKeyKaydetButton";
            this.apiKeyKaydetButton.Size = new System.Drawing.Size(282, 39);
            this.apiKeyKaydetButton.TabIndex = 2;
            this.apiKeyKaydetButton.Text = "APİ KAYDET";
            this.apiKeyKaydetButton.UseVisualStyleBackColor = true;
            this.apiKeyKaydetButton.Click += new System.EventHandler(this.apiKeyKaydetButton_Click);
            // 
            // apiKeyTextBox
            // 
            this.apiKeyTextBox.Location = new System.Drawing.Point(82, 32);
            this.apiKeyTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.apiKeyTextBox.Name = "apiKeyTextBox";
            this.apiKeyTextBox.Size = new System.Drawing.Size(282, 24);
            this.apiKeyTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.otoTaramaKapali);
            this.groupBox2.Controls.Add(this.otoTaramaAcik);
            this.groupBox2.Location = new System.Drawing.Point(18, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Oto tarama";
            // 
            // otoTaramaKapali
            // 
            this.otoTaramaKapali.AutoSize = true;
            this.otoTaramaKapali.Location = new System.Drawing.Point(110, 28);
            this.otoTaramaKapali.Name = "otoTaramaKapali";
            this.otoTaramaKapali.Size = new System.Drawing.Size(66, 22);
            this.otoTaramaKapali.TabIndex = 1;
            this.otoTaramaKapali.TabStop = true;
            this.otoTaramaKapali.Text = "Kapalı";
            this.otoTaramaKapali.UseVisualStyleBackColor = true;
            this.otoTaramaKapali.CheckedChanged += new System.EventHandler(this.otoTaramaKapali_CheckedChanged);
            // 
            // otoTaramaAcik
            // 
            this.otoTaramaAcik.AutoSize = true;
            this.otoTaramaAcik.Location = new System.Drawing.Point(9, 28);
            this.otoTaramaAcik.Name = "otoTaramaAcik";
            this.otoTaramaAcik.Size = new System.Drawing.Size(54, 22);
            this.otoTaramaAcik.TabIndex = 0;
            this.otoTaramaAcik.TabStop = true;
            this.otoTaramaAcik.Text = "Açık";
            this.otoTaramaAcik.UseVisualStyleBackColor = true;
            this.otoTaramaAcik.CheckedChanged += new System.EventHandler(this.otoTaramaAcik_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.otoTaramaAralik);
            this.groupBox3.Location = new System.Drawing.Point(208, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 71);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tarama aralığı (DK)";
            // 
            // otoTaramaAralik
            // 
            this.otoTaramaAralik.Location = new System.Drawing.Point(6, 28);
            this.otoTaramaAralik.Name = "otoTaramaAralik";
            this.otoTaramaAralik.Size = new System.Drawing.Size(168, 24);
            this.otoTaramaAralik.TabIndex = 0;
            this.otoTaramaAralik.ValueChanged += new System.EventHandler(this.otoTaramaAralik_ValueChanged);
            this.otoTaramaAralik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.otoTaramaAralik_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.videoAlarmCal);
            this.groupBox4.Controls.Add(this.videoAlarmCombo);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.kanalAlarmCal);
            this.groupBox4.Controls.Add(this.kanalAlarmCombo);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.alarmKapali);
            this.groupBox4.Controls.Add(this.alarmAcik);
            this.groupBox4.Location = new System.Drawing.Point(18, 217);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(377, 139);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Alarm çalsın mı?";
            // 
            // alarmAcik
            // 
            this.alarmAcik.AutoSize = true;
            this.alarmAcik.Location = new System.Drawing.Point(9, 32);
            this.alarmAcik.Name = "alarmAcik";
            this.alarmAcik.Size = new System.Drawing.Size(55, 22);
            this.alarmAcik.TabIndex = 0;
            this.alarmAcik.TabStop = true;
            this.alarmAcik.Text = "Evet";
            this.alarmAcik.UseVisualStyleBackColor = true;
            this.alarmAcik.CheckedChanged += new System.EventHandler(this.alarmAcik_CheckedChanged);
            // 
            // alarmKapali
            // 
            this.alarmKapali.AutoSize = true;
            this.alarmKapali.Location = new System.Drawing.Point(110, 32);
            this.alarmKapali.Name = "alarmKapali";
            this.alarmKapali.Size = new System.Drawing.Size(60, 22);
            this.alarmKapali.TabIndex = 1;
            this.alarmKapali.TabStop = true;
            this.alarmKapali.Text = "Hayır";
            this.alarmKapali.UseVisualStyleBackColor = true;
            this.alarmKapali.CheckedChanged += new System.EventHandler(this.alarmKapali_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kapanan kanal:";
            // 
            // kanalAlarmCombo
            // 
            this.kanalAlarmCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kanalAlarmCombo.FormattingEnabled = true;
            this.kanalAlarmCombo.Location = new System.Drawing.Point(139, 67);
            this.kanalAlarmCombo.Name = "kanalAlarmCombo";
            this.kanalAlarmCombo.Size = new System.Drawing.Size(166, 26);
            this.kanalAlarmCombo.TabIndex = 3;
            // 
            // kanalAlarmCal
            // 
            this.kanalAlarmCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kanalAlarmCal.Location = new System.Drawing.Point(311, 67);
            this.kanalAlarmCal.Name = "kanalAlarmCal";
            this.kanalAlarmCal.Size = new System.Drawing.Size(60, 28);
            this.kanalAlarmCal.TabIndex = 4;
            this.kanalAlarmCal.Text = "ÇAL";
            this.kanalAlarmCal.UseVisualStyleBackColor = true;
            // 
            // videoAlarmCal
            // 
            this.videoAlarmCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.videoAlarmCal.Location = new System.Drawing.Point(311, 99);
            this.videoAlarmCal.Name = "videoAlarmCal";
            this.videoAlarmCal.Size = new System.Drawing.Size(60, 28);
            this.videoAlarmCal.TabIndex = 7;
            this.videoAlarmCal.Text = "ÇAL";
            this.videoAlarmCal.UseVisualStyleBackColor = true;
            // 
            // videoAlarmCombo
            // 
            this.videoAlarmCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoAlarmCombo.FormattingEnabled = true;
            this.videoAlarmCombo.Location = new System.Drawing.Point(139, 99);
            this.videoAlarmCombo.Name = "videoAlarmCombo";
            this.videoAlarmCombo.Size = new System.Drawing.Size(166, 26);
            this.videoAlarmCombo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Silinen video:";
            // 
            // AyarlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(417, 565);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AyarlarForm";
            this.Text = "Ayarlar - YouTube Kanal Takip";
            this.Load += new System.EventHandler(this.AyarlarForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.otoTaramaAralik)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox apiKeyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button apiKeyKaydetButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton otoTaramaKapali;
        private System.Windows.Forms.RadioButton otoTaramaAcik;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown otoTaramaAralik;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton alarmKapali;
        private System.Windows.Forms.RadioButton alarmAcik;
        private System.Windows.Forms.ComboBox kanalAlarmCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kanalAlarmCal;
        private System.Windows.Forms.Button videoAlarmCal;
        private System.Windows.Forms.ComboBox videoAlarmCombo;
        private System.Windows.Forms.Label label3;
    }
}