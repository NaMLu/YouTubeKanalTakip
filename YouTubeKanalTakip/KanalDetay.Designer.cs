namespace YouTubeKanalTakip
{
    partial class KanalDetay
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
            this.kanalResimPicture = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grupGuncelleButton = new System.Windows.Forms.Button();
            this.grupListesiCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.durumLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.notGuncelleButton = new System.Windows.Forms.Button();
            this.notRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.videolarListView = new System.Windows.Forms.ListView();
            this.resim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resimListesi = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoListeGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.toplamYorumLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toplamDislikeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toplamLikeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toplamHitLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sagTikMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.videoyaGitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kanalResimPicture)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.sagTikMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kanalResimPicture);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resim";
            // 
            // kanalResimPicture
            // 
            this.kanalResimPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kanalResimPicture.Location = new System.Drawing.Point(3, 16);
            this.kanalResimPicture.Name = "kanalResimPicture";
            this.kanalResimPicture.Size = new System.Drawing.Size(150, 133);
            this.kanalResimPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kanalResimPicture.TabIndex = 0;
            this.kanalResimPicture.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grupGuncelleButton);
            this.groupBox2.Controls.Add(this.grupListesiCombo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(174, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 67);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grup güncelle";
            // 
            // grupGuncelleButton
            // 
            this.grupGuncelleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grupGuncelleButton.Location = new System.Drawing.Point(303, 21);
            this.grupGuncelleButton.Name = "grupGuncelleButton";
            this.grupGuncelleButton.Size = new System.Drawing.Size(83, 34);
            this.grupGuncelleButton.TabIndex = 2;
            this.grupGuncelleButton.Text = "GÜNCELLE";
            this.grupGuncelleButton.UseVisualStyleBackColor = true;
            this.grupGuncelleButton.Click += new System.EventHandler(this.grupGuncelleButton_Click);
            // 
            // grupListesiCombo
            // 
            this.grupListesiCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grupListesiCombo.FormattingEnabled = true;
            this.grupListesiCombo.Location = new System.Drawing.Point(54, 29);
            this.grupListesiCombo.Name = "grupListesiCombo";
            this.grupListesiCombo.Size = new System.Drawing.Size(243, 21);
            this.grupListesiCombo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grup:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.durumLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 550);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(578, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel1.Text = "Durum:";
            // 
            // durumLabel
            // 
            this.durumLabel.Name = "durumLabel";
            this.durumLabel.Size = new System.Drawing.Size(37, 17);
            this.durumLabel.Text = "Hazır.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.notGuncelleButton);
            this.groupBox3.Controls.Add(this.notRichTextBox);
            this.groupBox3.Location = new System.Drawing.Point(174, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 79);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Not";
            // 
            // notGuncelleButton
            // 
            this.notGuncelleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.notGuncelleButton.Location = new System.Drawing.Point(303, 19);
            this.notGuncelleButton.Name = "notGuncelleButton";
            this.notGuncelleButton.Size = new System.Drawing.Size(83, 54);
            this.notGuncelleButton.TabIndex = 1;
            this.notGuncelleButton.Text = "GÜNCELLE";
            this.notGuncelleButton.UseVisualStyleBackColor = true;
            this.notGuncelleButton.Click += new System.EventHandler(this.notGuncelleButton_Click);
            // 
            // notRichTextBox
            // 
            this.notRichTextBox.Location = new System.Drawing.Point(6, 19);
            this.notRichTextBox.Name = "notRichTextBox";
            this.notRichTextBox.Size = new System.Drawing.Size(291, 54);
            this.notRichTextBox.TabIndex = 0;
            this.notRichTextBox.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.videolarListView);
            this.groupBox4.Location = new System.Drawing.Point(12, 248);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(551, 294);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Video listesi";
            // 
            // videolarListView
            // 
            this.videolarListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.resim,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.videolarListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videolarListView.FullRowSelect = true;
            this.videolarListView.Location = new System.Drawing.Point(3, 16);
            this.videolarListView.MultiSelect = false;
            this.videolarListView.Name = "videolarListView";
            this.videolarListView.Size = new System.Drawing.Size(545, 275);
            this.videolarListView.SmallImageList = this.resimListesi;
            this.videolarListView.TabIndex = 0;
            this.videolarListView.UseCompatibleStateImageBehavior = false;
            this.videolarListView.View = System.Windows.Forms.View.Details;
            this.videolarListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.videolarListView_MouseClick);
            // 
            // resim
            // 
            this.resim.Text = "Resim";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Video Başlık";
            this.columnHeader1.Width = 149;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İzlenme";
            this.columnHeader2.Width = 73;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Like";
            this.columnHeader3.Width = 68;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Dislike";
            this.columnHeader4.Width = 72;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Yorum";
            this.columnHeader5.Width = 68;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Durum";
            this.columnHeader6.Width = 58;
            // 
            // resimListesi
            // 
            this.resimListesi.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.resimListesi.ImageSize = new System.Drawing.Size(64, 64);
            this.resimListesi.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoListeGüncelleToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // videoListeGüncelleToolStripMenuItem
            // 
            this.videoListeGüncelleToolStripMenuItem.Name = "videoListeGüncelleToolStripMenuItem";
            this.videoListeGüncelleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.videoListeGüncelleToolStripMenuItem.Text = "Video Liste Güncelle";
            this.videoListeGüncelleToolStripMenuItem.Click += new System.EventHandler(this.videoListeGüncelleToolStripMenuItem_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.toplamYorumLabel);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.toplamDislikeLabel);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.toplamLikeLabel);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.toplamHitLabel);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(15, 182);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(551, 60);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Temel istatistikler";
            // 
            // toplamYorumLabel
            // 
            this.toplamYorumLabel.AutoSize = true;
            this.toplamYorumLabel.Location = new System.Drawing.Point(488, 27);
            this.toplamYorumLabel.Name = "toplamYorumLabel";
            this.toplamYorumLabel.Size = new System.Drawing.Size(13, 13);
            this.toplamYorumLabel.TabIndex = 7;
            this.toplamYorumLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Toplam yorum:";
            // 
            // toplamDislikeLabel
            // 
            this.toplamDislikeLabel.AutoSize = true;
            this.toplamDislikeLabel.Location = new System.Drawing.Point(356, 27);
            this.toplamDislikeLabel.Name = "toplamDislikeLabel";
            this.toplamDislikeLabel.Size = new System.Drawing.Size(13, 13);
            this.toplamDislikeLabel.TabIndex = 5;
            this.toplamDislikeLabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Toplam dislike:";
            // 
            // toplamLikeLabel
            // 
            this.toplamLikeLabel.AutoSize = true;
            this.toplamLikeLabel.Location = new System.Drawing.Point(202, 27);
            this.toplamLikeLabel.Name = "toplamLikeLabel";
            this.toplamLikeLabel.Size = new System.Drawing.Size(13, 13);
            this.toplamLikeLabel.TabIndex = 3;
            this.toplamLikeLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Toplam like:";
            // 
            // toplamHitLabel
            // 
            this.toplamHitLabel.AutoSize = true;
            this.toplamHitLabel.Location = new System.Drawing.Point(62, 27);
            this.toplamHitLabel.Name = "toplamHitLabel";
            this.toplamHitLabel.Size = new System.Drawing.Size(13, 13);
            this.toplamHitLabel.TabIndex = 1;
            this.toplamHitLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Toplam hit:";
            // 
            // sagTikMenu
            // 
            this.sagTikMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoyaGitToolStripMenuItem});
            this.sagTikMenu.Name = "sagTikMenu";
            this.sagTikMenu.Size = new System.Drawing.Size(134, 26);
            // 
            // videoyaGitToolStripMenuItem
            // 
            this.videoyaGitToolStripMenuItem.Name = "videoyaGitToolStripMenuItem";
            this.videoyaGitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.videoyaGitToolStripMenuItem.Text = "Videoya git";
            this.videoyaGitToolStripMenuItem.Click += new System.EventHandler(this.videoyaGitToolStripMenuItem_Click);
            // 
            // KanalDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(578, 572);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KanalDetay";
            this.Text = "Kanal Detayı - YouTube Kanal Takip";
            this.Load += new System.EventHandler(this.KanalDetay_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kanalResimPicture)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.sagTikMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox kanalResimPicture;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox grupListesiCombo;
        private System.Windows.Forms.Button grupGuncelleButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel durumLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox notRichTextBox;
        private System.Windows.Forms.Button notGuncelleButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView videolarListView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoListeGüncelleToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ImageList resimListesi;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader resim;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label toplamHitLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label toplamDislikeLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label toplamLikeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label toplamYorumLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ContextMenuStrip sagTikMenu;
        private System.Windows.Forms.ToolStripMenuItem videoyaGitToolStripMenuItem;
    }
}