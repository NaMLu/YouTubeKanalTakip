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
    public partial class AyarlarForm : Form
    {
        Veritabani vt = new Veritabani();
        YouTube_sinif yt = new YouTube_sinif();

        public AyarlarForm()
        {
            InitializeComponent();
        }

        private void apiKeyKaydetButton_Click(object sender, EventArgs e)
        {
            String apiKey = apiKeyTextBox.Text;

            if(String.IsNullOrEmpty(apiKey))
            {
                MessageBox.Show("Lütfen api key alanını boş bırakmayınız.","Uyarı !",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                vt.ayarKaydet("api_key",apiKey);

                if(!yt.ApiKeyKontrol())
                {
                    MessageBox.Show("Lütfen geçerli bir api key giriniz.", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Api key başarıyla çalışıyor.", "Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void AyarlarForm_Load(object sender, EventArgs e)
        {
            apiKeyTextBox.Text = vt.ayarGetir("api_key");
            otoTaramaAcik.Checked = vt.ayarGetir("oto_tarama") == true.ToString() ? true : false;
            otoTaramaKapali.Checked = vt.ayarGetir("oto_tarama") == false.ToString() ? true : false;
            int deger = vt.ayarGetir("oto_aralik") == "" ? 0 : Convert.ToInt32(vt.ayarGetir("oto_aralik"));
            otoTaramaAralik.Value = deger;
        }

        private void otoTaramaAralik_ValueChanged(object sender, EventArgs e)
        {
            if(otoTaramaAralik.Value < 0)
            {
                otoTaramaAralik.Value = 0;
            }
            else
            {
                vt.ayarKaydet("oto_aralik",otoTaramaAralik.Value.ToString());
            }
        }

        private void otoTaramaAralik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void otoTaramaKapali_CheckedChanged(object sender, EventArgs e)
        {
            if (otoTaramaKapali.Checked == true)
            {
                otoTaramaAralik.Enabled = false;
                vt.ayarKaydet("oto_tarama", false.ToString());
                otoTaramaAralik.Value = 0;
                vt.ayarKaydet("oto_aralik", 0.ToString());
            }
        }

        private void otoTaramaAcik_CheckedChanged(object sender, EventArgs e)
        {
            if (otoTaramaAcik.Checked == true)
            {
                otoTaramaAralik.Enabled = true;
                vt.ayarKaydet("oto_tarama", true.ToString());
            }
        }

        private void alarmKapali_CheckedChanged(object sender, EventArgs e)
        {
            if(alarmKapali.Checked == true)
            {
                vt.ayarKaydet("oto_alarm",false.ToString());

                videoAlarmCombo.Enabled = false;
                kanalAlarmCombo.Enabled = false;
            }
        }

        private void alarmAcik_CheckedChanged(object sender, EventArgs e)
        {
            if(alarmAcik.Checked == true)
            {
                vt.ayarKaydet("oto_alarm", true.ToString());

                videoAlarmCombo.Enabled = true;
                kanalAlarmCombo.Enabled = true;
            }
        }
    }
}
