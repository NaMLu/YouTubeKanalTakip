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
    public partial class anaForm : Form
    {
        Veritabani vt = new Veritabani();

        public anaForm()
        {
            InitializeComponent();
        }

        private void anaForm_Load(object sender, EventArgs e)
        {
            YouTube_sinif yt = new YouTube_sinif();

            vt.SQLKontrol();

            if(!yt.ApiKeyKontrol())
            {
                durumLabel.Text = "Lütfen geçerli bir api key giriniz.";
            }
            else
            {
                durumLabel.Text = "Hazır";
            }

            Thread th = new Thread(KanalListesiYenile);
            th.IsBackground = true;
            th.Start();
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AyarlarForm form = new AyarlarForm();
            form.ShowDialog();
        }

        private void grupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grupForm form = new grupForm();
            form.ShowDialog();
        }

        private void tekKanalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekKanalEkleForm form = new TekKanalEkleForm();
            form.ShowDialog();
        }

        private void KanalListesiYenile()
        {
            durumLabel.Text = "Kanal listesi yükleniyor.";
            
            if(kanallarListView.InvokeRequired)
            {
                kanallarListView.Invoke((MethodInvoker) delegate { kanallarListView.Items.Clear(); });
            }
            else
            {
                kanallarListView.Items.Clear();
            }


            DataTable tablo = vt.kanallarListesi();
            int i = 0;
            foreach(DataRow dr in tablo.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = dr["kanal_resim"].ToString();
                item.SubItems.Add(dr["kanal_adi"].ToString());
                item.SubItems.Add(dr["kanal_id"].ToString());
                item.SubItems.Add(dr["kanal_hit"].ToString());
                item.SubItems.Add(dr["kanal_abone"].ToString());
                item.SubItems.Add(dr["kanal_video"].ToString());
                item.SubItems.Add(Convert.ToBoolean(dr["kanal_durum"]) == true ? "Açık" : "Kapalı");
                item.SubItems.Add(dr["kanal_not"].ToString());
                item.SubItems.Add(dr["kanal_grup"].ToString());
                item.SubItems.Add(dr["kanal_kimlik"].ToString());
                item.SubItems.Add(dr["kanal_upload"].ToString());

                item.BackColor = i % 2 == 0 ? System.Drawing.ColorTranslator.FromHtml("#ecf0f1") : System.Drawing.ColorTranslator.FromHtml("#bdc3c7");

                resimListesi.Images.Add(LoadImage(dr["kanal_resim"].ToString()));
                item.ImageIndex = resimListesi.Images.Count - 1;

                if (kanallarListView.InvokeRequired)
                {
                    kanallarListView.BeginInvoke((MethodInvoker) delegate { kanallarListView.Items.Add(item); });
                }
                else
                {
                    kanallarListView.Items.Add(item);
                }

                i++;

                Thread.Sleep(1);
            }

            durumLabel.Text = "Kanal listesi yüklendi.";
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

        private void kanallarListView_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                if(kanallarListView.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    sagTikMenu.Show(Cursor.Position);
                }
            }
        }

        private void kanalDetayıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = kanallarListView.SelectedItems[0];

            KanalDetay form = new KanalDetay();
            form.item = item;
            form.ShowDialog();
        }

        private void listeyiYenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread kanalListeYenile = new Thread(KanalListesiYenile);
            kanalListeYenile.IsBackground = true;
            kanalListeYenile.Start();
        }

        private void kanalaGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = kanallarListView.SelectedItems[0];
            string id = item.SubItems[2].Text;
            string link = "https://www.youtube.com/channel/" + id;

            System.Diagnostics.Process.Start(link);
        }

        private void kanalıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = kanallarListView.SelectedItems[0];
            string id = item.SubItems[2].Text;

            if(vt.KanalSil(id))
            {
                Thread kanalListeYenile = new Thread(KanalListesiYenile);
                kanalListeYenile.IsBackground = true;
                kanalListeYenile.Start();
            }
            else
            {
                durumLabel.Text = "Kanal silinemedi.";
            }
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HakkimdaForm form = new HakkimdaForm();
            form.ShowDialog();
        }

        private void topluKanalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            topluKanalEkleForm form = new topluKanalEkleForm();
            form.ShowDialog();
        }
    }
}
