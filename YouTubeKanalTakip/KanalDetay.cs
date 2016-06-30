using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTubeKanalTakip
{
    public partial class KanalDetay : Form
    {
        Veritabani vt = new Veritabani();
        YouTube_sinif yt = new YouTube_sinif();

        public ListViewItem item;

        public KanalDetay()
        {
            InitializeComponent();
        }

        private void KanalDetay_Load(object sender, EventArgs e)
        {
            Thread kanalDetayThread = new Thread(KanalDetayYukle);
            kanalDetayThread.IsBackground = true;
            kanalDetayThread.Start();

            Thread grupBilgiThread = new Thread(GrupBilgisiGetir);
            grupBilgiThread.IsBackground = true;
            grupBilgiThread.Start();
        }

        private void GrupBilgisiGetir()
        {
            DataTable dt = vt.gruplariGetir();

            foreach(DataRow dr in dt.Rows)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = dr["grup_ismi"].ToString();
                item.Value = dr["grup_kimlik"].ToString();

                if (grupListesiCombo.InvokeRequired)
                {
                    grupListesiCombo.Invoke((MethodInvoker) delegate() { grupListesiCombo.Items.Add(item); });
                }
                else
                {
                    grupListesiCombo.Items.Add(item);
                }
            }
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void KanalDetayYukle()
        {
            if (kanalResimPicture.InvokeRequired)
            {
                kanalResimPicture.BeginInvoke((MethodInvoker) delegate { kanalResimPicture.Image = LoadImage(item.Tag.ToString()); });
            }
            else
            {
                kanalResimPicture.Image = LoadImage(item.Tag.ToString());
            }

            if(notRichTextBox.InvokeRequired)
            {
                notRichTextBox.Invoke((MethodInvoker) delegate { notRichTextBox.Text = this.item.SubItems[7].Text; });
            }
            else
            {
                notRichTextBox.Text = this.item.SubItems[7].Text;
            }

            Thread videoListeGuncelle = new Thread(VideoListesiYenile);
            videoListeGuncelle.IsBackground = true;
            videoListeGuncelle.Start();
            Thread temelIstatistikGuncelle = new Thread(TemelIstatistikGuncelle);
            temelIstatistikGuncelle.IsBackground = true;
            temelIstatistikGuncelle.Start();
        }

        public Image LoadImage(string url)
        {
            System.Net.WebRequest request =
                System.Net.WebRequest.Create(url);

            System.Net.WebResponse response = request.GetResponse();
            System.IO.Stream responseStream =
                response.GetResponseStream();

            Bitmap bmp = new Bitmap(responseStream);

            responseStream.Dispose();

            return bmp;
        }

        private void grupGuncelleButton_Click(object sender, EventArgs e)
        {
            ComboboxItem item = (ComboboxItem) grupListesiCombo.SelectedItem;
            int kimlik = 0;
            try
            {
                kimlik = Convert.ToInt32(item.Value);
            }
            catch(Exception ex)
            {
                
            }

            if (kimlik > 0)
            {
                if(vt.kanalGrupGuncelle(Convert.ToInt32(this.item.SubItems[9].Text),kimlik))
                {
                    MessageBox.Show("Grup bilgisi başarıyla güncellendi !");
                }
                else
                {
                    MessageBox.Show("Grup bilgisi güncellenemedi.","Hata !",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir eleman seçiniz.","Uyarı !",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void notGuncelleButton_Click(object sender, EventArgs e)
        {
            String not = notRichTextBox.Text;
            int kanalKimlik = Convert.ToInt32(this.item.SubItems[9].Text);

            if (vt.kanalNotGuncelle(kanalKimlik,not))
            {
                MessageBox.Show("Kanal notu başarıyla güncellendi.","Uyarı !",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kanal notu güncelleme işlemi başarısız oldu.","Hata !",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void videoListeGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread videoListeGuncelle = new Thread(VideolariGuncelle);
            videoListeGuncelle.IsBackground = true;
            videoListeGuncelle.Start();
        }

        private void VideoListesiYenile()
        {
            if(videolarListView.InvokeRequired)
            {
                videolarListView.Invoke((MethodInvoker) delegate { videolarListView.Items.Clear(); });
            }
            else
            {
                videolarListView.Items.Clear();
            }

            int kanal = Convert.ToInt32(this.item.SubItems[9].Text);

            DataTable tablo = vt.videoListesi(kanal);
            durumLabel.Text = tablo.Rows.Count + " adet video listeleniyor.";

            foreach(DataRow satir in tablo.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = satir["video_id"].ToString();
                item.SubItems.Add(satir["video_adi"].ToString());
                item.SubItems.Add(satir["video_hit"].ToString());
                item.SubItems.Add(satir["video_like"].ToString());
                item.SubItems.Add(satir["video_unlike"].ToString());
                item.SubItems.Add(satir["video_yorum"].ToString());
                item.SubItems.Add(Convert.ToBoolean(satir["video_durum"]) == true ? "Açık" : "Kapalı");

                resimListesi.Images.Add(LoadImage(satir["video_resim"].ToString()));
                item.ImageIndex = resimListesi.Images.Count - 1;


                if (videolarListView.InvokeRequired)
                {
                    videolarListView.Invoke((MethodInvoker) delegate { videolarListView.Items.Add(item); });
                }
                else
                {
                    videolarListView.Items.Add(item);
                }

                durumLabel.Text = satir["video_id"].ToString() + " id'li video listeye eklendi.";

                Thread.Sleep(1);
            }

            durumLabel.Text = "Liste yenileme işlemi tamamlandı.";
        }

        private void VideolariGuncelle()
        {
            int kanal = Convert.ToInt32(this.item.SubItems[9].Text);
            string upload = this.item.SubItems[10].Text;

            DataTable videolar = yt.videolariGetir(upload);

            foreach (DataRow satir in videolar.Rows)
            {
                string id = satir["id"].ToString();

                if (yt.videoEkle(id, kanal))
                {
                    durumLabel.Text = id + " video güncellendi.";
                }
                else
                {
                    durumLabel.Text = id + " video güncellenemedi.";
                }
            }

            durumLabel.Text = "Videolar güncellendi.";

            Thread videoListeThread = new Thread(VideoListesiYenile);
            videoListeThread.IsBackground = true;
            videoListeThread.Start();

            Thread temelIstatistikThread = new Thread(TemelIstatistikGuncelle);
            temelIstatistikThread.IsBackground = true;
            temelIstatistikThread.Start();
        }

        private void TemelIstatistikGuncelle()
        {
            int kanal = Convert.ToInt32(this.item.SubItems[9].Text);


            LabelDegistir(toplamHitLabel,vt.toplamHit(kanal).ToString("N0"));
            LabelDegistir(toplamLikeLabel,vt.toplamLike(kanal).ToString("N0"));
            LabelDegistir(toplamDislikeLabel,vt.toplamDislike(kanal).ToString("N0"));
            LabelDegistir(toplamYorumLabel, vt.toplamYorum(kanal).ToString("N0"));
        }

        private void LabelDegistir(Label label,string veri)
        {
            if(label.InvokeRequired)
            {
                label.Invoke((MethodInvoker) delegate { label.Text = veri; });
            }
            else
            {
                label.Text = veri;
            }
        }

        private void videolarListView_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                if(videolarListView.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    sagTikMenu.Show(Cursor.Position);
                }
            }
        }

        private void videoyaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = videolarListView.SelectedItems[0];

            string id = item.Tag.ToString();

            string link = "https://www.youtube.com/watch?v=" + id;

            System.Diagnostics.Process.Start(link);
        }
    }
}
