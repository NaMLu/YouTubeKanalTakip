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
        }
    }
}
