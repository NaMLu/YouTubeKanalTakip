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
    public partial class topluKanalEkleForm : Form
    {
        Veritabani vt = new Veritabani();
        YouTube_sinif yt = new YouTube_sinif();

        public topluKanalEkleForm()
        {
            InitializeComponent();
        }

        private void topluKanalEkleForm_Load(object sender, EventArgs e)
        {

        }

        private void topluListeText_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            foreach (string satir in topluListeText.Lines)
            {
                string id = "";

                if (satir.IndexOf("user/") > -1)
                {
                    id = satir.Substring(satir.IndexOf("user/") + 5);
                }
                else if (satir.IndexOf("channel/") > -1)
                {
                    id = satir.Substring(satir.IndexOf("channel/") + 8);
                }

                if (!String.IsNullOrEmpty(id))
                {
                    i++;
                }
            }

            durumLabel.Text = i + " adet kanal var listede.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] satirlar = SatirlariGetir(topluListeText);

            foreach(string link in satirlar)
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
                    durumLabel.Text = "Geçerli bir link giriniz.";
                }
                else
                {
                    if (kimlik.IndexOf("/") != -1)
                    {
                        kimlik = kimlik.Substring(0, kimlik.IndexOf("/"));
                    }

                    if (yt.kanalEkle(tip, kimlik))
                    {
                        durumLabel.Text = kimlik + " Kanal ekleme işlemi başarılı !";
                    }
                    else
                    {
                        durumLabel.Text = kimlik + " Kanal ekleme işlemi başarısız.";
                    }

                }
            }
        }

        public string[] SatirlariGetir(RichTextBox RichtextBox)
        {
            if (RichtextBox.InvokeRequired)
            {
                return (string[])RichtextBox.Invoke(
                  new Func<String[]>(() => SatirlariGetir(RichtextBox))
                );
            }
            else
            {
                string[] varText = RichtextBox.Lines;
                return varText;
            }
        }
    }
}
