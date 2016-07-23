using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTubeKanalTakip
{
    public partial class grupForm : Form
    {
        Veritabani vt = new Veritabani();

        public grupForm()
        {
            InitializeComponent();
        }

        private void grupEkleButton_Click(object sender, EventArgs e)
        {
            String grupAdi = grupEkleAdiTextBox.Text;

            if(String.IsNullOrEmpty(grupAdi))
            {
                MessageBox.Show("Lütfen grup adı alanını boş bırakmayınız.","Uyarı !",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if(vt.grupEkle(grupAdi))
                {
                    grupEkleAdiTextBox.Text = "";

                    MessageBox.Show("Grup başarıyla eklendi.","Başarılı !",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    GrupListesiYenile();
                }
                else
                {
                    MessageBox.Show("Lütfen grup adı eklenemedi.", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void grupForm_Load(object sender, EventArgs e)
        {
            GrupListesiYenile();
        }

        private void GrupListesiYenile()
        {
            gruplarListView.Items.Clear();

            DataTable dt = vt.gruplariGetir();

            foreach(DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = dr["grup_kimlik"].ToString();
                item.Text = dr["grup_ismi"].ToString();

                gruplarListView.Items.Add(item);
            }
        }

        private void gruplarListView_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                if(gruplarListView.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    sagTikMenu.Show(Cursor.Position);
                }
            }
        }

        private void grubuGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = gruplarListView.SelectedItems[0];

            grupGuncelleKimlikTextBox.Text = item.Tag.ToString();
            grupGuncelleTextBox.Text = item.Text;
            grupGuncelleTextBox.Enabled = true;
        }

        private void grupGuncelleButton_Click(object sender, EventArgs e)
        {
            String kimlik = grupGuncelleKimlikTextBox.Text;
            String isim = grupGuncelleTextBox.Text;

            if(String.IsNullOrEmpty(kimlik) || String.IsNullOrEmpty(isim))
            {
                MessageBox.Show("Alanların dolu olduğundan emin olunuz !","Uyarı !",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if(vt.grupGuncelle(Convert.ToInt32(kimlik),isim))
                {
                    grupGuncelleTextBox.Enabled = false;
                    grupGuncelleTextBox.Text = "";
                    grupGuncelleKimlikTextBox.Text = "";

                    MessageBox.Show("Grup başarıyla güncellendi.","Başarılı !",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    GrupListesiYenile();
                }
                else
                {
                    MessageBox.Show("Grup güncellenemedi !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void grubuSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gruplarListView.SelectedItems.Count > 0)
            {
                ListViewItem item = gruplarListView.SelectedItems[0];

                int kimlik = Convert.ToInt32(item.Tag);
                string isim = item.Text;

                if(MessageBox.Show(isim + " isimli grubu silmek istediğinize emin misiniz ?","Uyarı !",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if(vt.grupSil(kimlik))
                    {
                        MessageBox.Show(isim + " isimli grup başarıyla silindi.","Uyarı !");
                        GrupListesiYenile();
                    }
                    else
                    {
                        MessageBox.Show(isim + " isimli grup silinemedi.","Uyarı !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Öncelikle bir grup seçmelisiniz.");
            }
        }
    }
}
