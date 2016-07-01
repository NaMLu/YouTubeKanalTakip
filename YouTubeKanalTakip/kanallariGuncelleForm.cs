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
    public partial class kanallariGuncelleForm : Form
    {
        Veritabani vt = new Veritabani();
        YouTube_sinif yt = new YouTube_sinif();

        public kanallariGuncelleForm()
        {
            InitializeComponent();
        }

        private void kanallariGuncelleForm_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(TumKanallarGuncelle);
            th.IsBackground = true;
            th.Start();
        }

        private void TumKanallarGuncelle()
        {
            DataTable kanallar = vt.kanallarListesi();
            int toplamKanal = kanallar.Rows.Count;

            int kanalSira = 1;
            foreach (DataRow dr in kanallar.Rows)
            {
                int yuzde = Convert.ToInt32((kanalSira * 100) / toplamKanal);
                YuzdeDegistir(genelDurumProgress,yuzde);

                string id = dr["kanal_id"].ToString();

                LabelDegistir(durumLabel, id + " kanalın temel bilgileri güncelleniyor.");

                if (yt.kanalEkle(true, id))
                {
                    int kanal = Convert.ToInt32(dr["kanal_kimlik"]);
                    string upload = dr["kanal_upload"].ToString();
                    
                    DataTable videolar = yt.videolariGetir(upload);

                    int videoSayisi = videolar.Rows.Count;
                    int videoSira = 1;
                    foreach (DataRow satir in videolar.Rows)
                    {
                        string vid = satir["id"].ToString();

                        if (yt.videoEkle(vid, kanal))
                        {
                            LabelDegistir(durumLabel, vid + " video güncellendi.");
                        }
                        else
                        {
                            LabelDegistir(durumLabel,vid + " video güncellenemedi.");
                        }

                        int vYuzde = Convert.ToInt32((videoSira * 100) / videoSayisi);

                        YuzdeDegistir(durumProgress, vYuzde);

                        Thread.Sleep(10);
                        videoSira++;
                    }
                }

                kanalSira++;
                Thread.Sleep(10);
            }

            LabelDegistir(durumLabel,"Tüm kanallar güncellendi.");
        }

        public void LabelDegistir(Label lab,string veri)
        {
            if(lab.InvokeRequired)
            {
                lab.Invoke((MethodInvoker) delegate { lab.Text = veri; });
            }
            else
            {
                lab.Text = veri;
            }
        }

        public void YuzdeDegistir(ProgressBar bar,int deger)
        {
            if(bar.InvokeRequired)
            {
                bar.Invoke((MethodInvoker) delegate { bar.Value = deger; });
            }
            else
            {
                bar.Value = deger;
            }
        }
    }
}
