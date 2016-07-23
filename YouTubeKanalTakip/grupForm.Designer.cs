namespace YouTubeKanalTakip
{
    partial class grupForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grupEkleButton = new System.Windows.Forms.Button();
            this.grupEkleAdiTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gruplarListView = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grupGuncelleButton = new System.Windows.Forms.Button();
            this.grupGuncelleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grupGuncelleKimlikTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sagTikMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grubuGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grubuSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.sagTikMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grupEkleButton);
            this.groupBox1.Controls.Add(this.grupEkleAdiTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grup ekle";
            // 
            // grupEkleButton
            // 
            this.grupEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grupEkleButton.Location = new System.Drawing.Point(107, 53);
            this.grupEkleButton.Name = "grupEkleButton";
            this.grupEkleButton.Size = new System.Drawing.Size(177, 34);
            this.grupEkleButton.TabIndex = 2;
            this.grupEkleButton.Text = "GRUP EKLE";
            this.grupEkleButton.UseVisualStyleBackColor = true;
            this.grupEkleButton.Click += new System.EventHandler(this.grupEkleButton_Click);
            // 
            // grupEkleAdiTextBox
            // 
            this.grupEkleAdiTextBox.Location = new System.Drawing.Point(107, 23);
            this.grupEkleAdiTextBox.Name = "grupEkleAdiTextBox";
            this.grupEkleAdiTextBox.Size = new System.Drawing.Size(177, 24);
            this.grupEkleAdiTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grup adı:";
            // 
            // gruplarListView
            // 
            this.gruplarListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gruplarListView.Location = new System.Drawing.Point(3, 20);
            this.gruplarListView.MultiSelect = false;
            this.gruplarListView.Name = "gruplarListView";
            this.gruplarListView.Size = new System.Drawing.Size(148, 209);
            this.gruplarListView.TabIndex = 1;
            this.gruplarListView.UseCompatibleStateImageBehavior = false;
            this.gruplarListView.View = System.Windows.Forms.View.List;
            this.gruplarListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gruplarListView_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gruplarListView);
            this.groupBox2.Location = new System.Drawing.Point(318, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 232);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grup Listesi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grupGuncelleButton);
            this.groupBox3.Controls.Add(this.grupGuncelleTextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.grupGuncelleKimlikTextBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 127);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grup güncelle";
            // 
            // grupGuncelleButton
            // 
            this.grupGuncelleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grupGuncelleButton.Location = new System.Drawing.Point(107, 84);
            this.grupGuncelleButton.Name = "grupGuncelleButton";
            this.grupGuncelleButton.Size = new System.Drawing.Size(177, 34);
            this.grupGuncelleButton.TabIndex = 5;
            this.grupGuncelleButton.Text = "GRUBU GÜNCELLE";
            this.grupGuncelleButton.UseVisualStyleBackColor = true;
            this.grupGuncelleButton.Click += new System.EventHandler(this.grupGuncelleButton_Click);
            // 
            // grupGuncelleTextBox
            // 
            this.grupGuncelleTextBox.Enabled = false;
            this.grupGuncelleTextBox.Location = new System.Drawing.Point(107, 54);
            this.grupGuncelleTextBox.Name = "grupGuncelleTextBox";
            this.grupGuncelleTextBox.Size = new System.Drawing.Size(177, 24);
            this.grupGuncelleTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Grup adı:";
            // 
            // grupGuncelleKimlikTextBox
            // 
            this.grupGuncelleKimlikTextBox.Enabled = false;
            this.grupGuncelleKimlikTextBox.Location = new System.Drawing.Point(107, 24);
            this.grupGuncelleKimlikTextBox.Name = "grupGuncelleKimlikTextBox";
            this.grupGuncelleKimlikTextBox.Size = new System.Drawing.Size(177, 24);
            this.grupGuncelleKimlikTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kimlik:";
            // 
            // sagTikMenu
            // 
            this.sagTikMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grubuGüncelleToolStripMenuItem,
            this.grubuSilToolStripMenuItem});
            this.sagTikMenu.Name = "sagTikMenu";
            this.sagTikMenu.Size = new System.Drawing.Size(156, 70);
            // 
            // grubuGüncelleToolStripMenuItem
            // 
            this.grubuGüncelleToolStripMenuItem.Name = "grubuGüncelleToolStripMenuItem";
            this.grubuGüncelleToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.grubuGüncelleToolStripMenuItem.Text = "Grubu güncelle";
            this.grubuGüncelleToolStripMenuItem.Click += new System.EventHandler(this.grubuGüncelleToolStripMenuItem_Click);
            // 
            // grubuSilToolStripMenuItem
            // 
            this.grubuSilToolStripMenuItem.Name = "grubuSilToolStripMenuItem";
            this.grubuSilToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.grubuSilToolStripMenuItem.Text = "Grubu sil";
            this.grubuSilToolStripMenuItem.Click += new System.EventHandler(this.grubuSilToolStripMenuItem_Click);
            // 
            // grupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(481, 252);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "grupForm";
            this.Text = "Grup Ayarları - YouTube Kanal Takip";
            this.Load += new System.EventHandler(this.grupForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.sagTikMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox grupEkleAdiTextBox;
        private System.Windows.Forms.Button grupEkleButton;
        private System.Windows.Forms.ListView gruplarListView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ContextMenuStrip sagTikMenu;
        private System.Windows.Forms.ToolStripMenuItem grubuGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grubuSilToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox grupGuncelleKimlikTextBox;
        private System.Windows.Forms.TextBox grupGuncelleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button grupGuncelleButton;
    }
}