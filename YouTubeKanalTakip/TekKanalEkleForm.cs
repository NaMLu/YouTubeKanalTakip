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
    public partial class TekKanalEkleForm : Form
    {
        Veritabani vt = new Veritabani();
        YouTube_sinif yt = new YouTube_sinif();

        public TekKanalEkleForm()
        {
            InitializeComponent();
        }

        private void kanalEkleButton_Click(object sender, EventArgs e)
        {

            if (yt.ApiKeyKontrol())
            {
                String link = kanalEkleLinkTextBox.Text;

                if (String.IsNullOrEmpty(link))
                {
                    MessageBox.Show("Link alanını boş bırakmayınız.", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    String kimlik = null;
                    bool tip = true;

                    if (link.IndexOf("channel/") != -1)
                    {
                        kimlik = link.Substring(link.IndexOf("channel/") + 8);
                    }
                    else if (link.IndexOf("user/") != -1)
                    {
                        tip = false;
                        kimlik = link.Substring(link.IndexOf("user/") + 5);
                    }


                    if (String.IsNullOrEmpty(kimlik))
                    {
                        MessageBox.Show("Geçerli bir link giriniz.", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (kimlik.IndexOf("/") != -1)
                        {
                            kimlik = kimlik.Substring(0, kimlik.IndexOf("/"));
                        }

                        if (yt.kanalEkle(tip, kimlik))
                        {
                            MessageBox.Show("Kanal ekleme başarılı !", "Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            kanalEkleLinkTextBox.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Kanal ekleme başarısız.", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce geçerli bir api key uygulamaya ekleyiniz.","Uyarı !",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void TekKanalEkleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
