namespace YouTubeKanalTakip
{
    partial class TekKanalEkleForm
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
            this.kanalEkleLinkTextBox = new System.Windows.Forms.TextBox();
            this.kanalEkleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kanal linki:";
            // 
            // kanalEkleLinkTextBox
            // 
            this.kanalEkleLinkTextBox.Location = new System.Drawing.Point(106, 12);
            this.kanalEkleLinkTextBox.Name = "kanalEkleLinkTextBox";
            this.kanalEkleLinkTextBox.Size = new System.Drawing.Size(257, 24);
            this.kanalEkleLinkTextBox.TabIndex = 1;
            // 
            // kanalEkleButton
            // 
            this.kanalEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kanalEkleButton.Location = new System.Drawing.Point(106, 42);
            this.kanalEkleButton.Name = "kanalEkleButton";
            this.kanalEkleButton.Size = new System.Drawing.Size(257, 41);
            this.kanalEkleButton.TabIndex = 2;
            this.kanalEkleButton.Text = "KANAL EKLE";
            this.kanalEkleButton.UseVisualStyleBackColor = true;
            this.kanalEkleButton.Click += new System.EventHandler(this.kanalEkleButton_Click);
            // 
            // TekKanalEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 91);
            this.Controls.Add(this.kanalEkleButton);
            this.Controls.Add(this.kanalEkleLinkTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TekKanalEkleForm";
            this.Text = "Tek Kanal Ekle";
            this.Load += new System.EventHandler(this.TekKanalEkleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kanalEkleLinkTextBox;
        private System.Windows.Forms.Button kanalEkleButton;
    }
}