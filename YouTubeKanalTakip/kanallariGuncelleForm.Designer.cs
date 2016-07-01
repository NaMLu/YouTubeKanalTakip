namespace YouTubeKanalTakip
{
    partial class kanallariGuncelleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.durumLabel = new System.Windows.Forms.Label();
            this.durumProgress = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.genelDurumProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Durum:";
            // 
            // durumLabel
            // 
            this.durumLabel.AutoSize = true;
            this.durumLabel.Location = new System.Drawing.Point(66, 13);
            this.durumLabel.Name = "durumLabel";
            this.durumLabel.Size = new System.Drawing.Size(34, 13);
            this.durumLabel.TabIndex = 1;
            this.durumLabel.Text = "Hazır.";
            // 
            // durumProgress
            // 
            this.durumProgress.Location = new System.Drawing.Point(12, 34);
            this.durumProgress.Name = "durumProgress";
            this.durumProgress.Size = new System.Drawing.Size(347, 23);
            this.durumProgress.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Genel İlerleme";
            // 
            // genelDurumProgress
            // 
            this.genelDurumProgress.Location = new System.Drawing.Point(12, 91);
            this.genelDurumProgress.Name = "genelDurumProgress";
            this.genelDurumProgress.Size = new System.Drawing.Size(347, 23);
            this.genelDurumProgress.TabIndex = 4;
            // 
            // kanallariGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(371, 125);
            this.Controls.Add(this.genelDurumProgress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.durumProgress);
            this.Controls.Add(this.durumLabel);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "kanallariGuncelleForm";
            this.Text = "Kanalları Güncelle Formu";
            this.Load += new System.EventHandler(this.kanallariGuncelleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label durumLabel;
        private System.Windows.Forms.ProgressBar durumProgress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar genelDurumProgress;
    }
}