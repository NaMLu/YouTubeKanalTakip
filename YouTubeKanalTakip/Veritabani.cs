using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeKanalTakip
{
    class Veritabani
    {
        private SQLiteConnection baglanti = new SQLiteConnection("Data Source=veritabani.s3db");

        public Veritabani()
        {
            baglanti.Open();
        }

        public void SQLKontrol()
        {
            SQLiteCommand ayarlarTabloOlustur = new SQLiteCommand("CREATE TABLE IF NOT EXISTS [ayarlar] ([id] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT,[ayar_adi] VARCHAR(30)  UNIQUE NULL,[ayar_veri] TEXT  NULL)", baglanti);
            ayarlarTabloOlustur.ExecuteNonQuery();

            SQLiteCommand gruplarTabloOlustur = new SQLiteCommand("CREATE TABLE IF NOT EXISTS [gruplar] ([grup_kimlik] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT,[grup_ismi] VARCHAR(50)  NULL)", baglanti);
            gruplarTabloOlustur.ExecuteNonQuery();

            SQLiteCommand kanallarTabloOlustur = new SQLiteCommand("CREATE TABLE IF NOT EXISTS [kanallar] ([kanal_kimlik] INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL,[kanal_adi] VARCHAR(50)  NULL,[kanal_resim] VARCHAR(255)  NULL,[kanal_plususerid] VARCHAR(255)  NULL,[kanal_hit] INTEGER  NULL,[kanal_abone] INTEGER  NULL,[kanal_video] INTEGER  NULL,[kanal_aboneDurum] BOOLEAN  NULL,[kanal_durum] BOOLEAN  NULL,[kanal_id] VARCHAR(255)  NULL,[kanal_upload] VARCHAR(255)  NULL,[kanal_not] TEXT  NULL,[kanal_grup] INTEGER  NULL)", baglanti);
            kanallarTabloOlustur.ExecuteNonQuery();

            SQLiteCommand videolarTabloOlustur = new SQLiteCommand("CREATE TABLE IF NOT EXISTS [videolar] ([video_kimlik] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT,[video_id] VARCHAR(50)  NULL,[video_hit] INTEGER  NULL,[video_like] INTEGER  NULL,[video_unlike] INTEGER  NULL,[video_adi] VARCHAR(255)  NULL,[video_yorum] INTEGER  NULL,[video_durum] BOOLEAN  NULL,[video_kanal] INTEGER  NULL,[video_resim] VARCHAR(255)  NULL)", baglanti);
            videolarTabloOlustur.ExecuteNonQuery();
        }

        #region Ayar İşlemleri

        public string ayarGetir(string ayarAdi)
        {
            try
            {
                SQLiteCommand ayarGetirKomut = new SQLiteCommand("SELECT ayar_veri FROM ayarlar WHERE ayar_adi = @ayar_adi", baglanti);
                ayarGetirKomut.Parameters.AddWithValue("@ayar_adi", ayarAdi);

                string ayar = ayarGetirKomut.ExecuteScalar().ToString();

                if (String.IsNullOrEmpty(ayar))
                {
                    return "";
                }
                else
                {
                    return ayar;
                }
            }
            catch
            {
                return "";
            }
        }

        public void ayarKaydet(string ayarAdi, string ayarVeri)
        {
            SQLiteCommand varMiKomut = new SQLiteCommand("SELECT * FROM ayarlar WHERE ayar_adi = @ayar_adi", baglanti);
            varMiKomut.Parameters.AddWithValue("@ayar_adi", ayarAdi);

            if (Convert.ToInt32(varMiKomut.ExecuteScalar()) == 0)
            {
                SQLiteCommand ekleKomut = new SQLiteCommand("INSERT INTO ayarlar (ayar_adi,ayar_veri) VALUES (@ayar_adi,@ayar_veri)", baglanti);
                ekleKomut.Parameters.AddWithValue("@ayar_adi", ayarAdi);
                ekleKomut.Parameters.AddWithValue("@ayar_veri", ayarVeri);

                ekleKomut.ExecuteNonQuery();
            }
            else
            {
                SQLiteCommand guncelleKomut = new SQLiteCommand("UPDATE ayarlar SET ayar_veri = @ayar_veri WHERE ayar_adi = @ayar_adi", baglanti);
                guncelleKomut.Parameters.AddWithValue("@ayar_adi", ayarAdi);
                guncelleKomut.Parameters.AddWithValue("@ayar_veri", ayarVeri);

                guncelleKomut.ExecuteNonQuery();
            }
        }

        #endregion
        #region Grup İşlemleri
        public bool grupEkle(string grupAdi)
        {
            SQLiteCommand grupVarMi = new SQLiteCommand("SELECT COUNT(*) FROM gruplar WHERE grup_ismi = @grup_ismi", baglanti);
            grupVarMi.Parameters.AddWithValue("@grup_ismi", grupAdi);

            if (Convert.ToInt32(grupVarMi.ExecuteScalar()) == 0)
            {
                SQLiteCommand grupEkle = new SQLiteCommand("INSERT INTO gruplar (grup_ismi) VALUES (@grup_ismi)", baglanti);
                grupEkle.Parameters.AddWithValue("@grup_ismi", grupAdi);

                if (grupEkle.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool grupSil(int kimlik)
        {
            SQLiteCommand grupSilKomut = new SQLiteCommand("DELETE FROM gruplar WHERE grup_kimlik = @grup_kimlik",baglanti);
            grupSilKomut.Parameters.AddWithValue("@grup_kimlik",kimlik);

            return grupSilKomut.ExecuteNonQuery() > 0;
        }

        public bool grupGuncelle(int id, string grupAdi)
        {
            SQLiteCommand grupGuncelle = new SQLiteCommand("UPDATE gruplar SET grup_ismi = @isim WHERE grup_kimlik = @id", baglanti);
            grupGuncelle.Parameters.AddWithValue("@isim", grupAdi);
            grupGuncelle.Parameters.AddWithValue("@id", id);

            if (grupGuncelle.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable gruplariGetir()
        {
            DataTable tablo = new DataTable();

            SQLiteCommand gruplarGetir = new SQLiteCommand("SELECT * FROM gruplar ORDER BY grup_kimlik ASC", baglanti);
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(gruplarGetir);

            dataAdapter.Fill(tablo);

            return tablo;
        }
        #endregion

        #region Kanal İşlemleri
        public bool kanalEkle(String[] kanal)
        {
            String adi = kanal[0];
            String resim = kanal[1];
            String plus = kanal[2];
            String hit = kanal[3];
            String abone = kanal[4];
            String video = kanal[5];
            String subDurum = kanal[6];
            String kanalDurum = kanal[7];
            String id = kanal[8];
            String upload = kanal[9];

            SQLiteCommand varMi = new SQLiteCommand("SELECT * FROM kanallar WHERE kanal_id = @id", baglanti);
            varMi.Parameters.AddWithValue("@id", id);

            if (Convert.ToInt32(varMi.ExecuteScalar()) == 0)
            {
                SQLiteCommand ekleKomut = new SQLiteCommand("INSERT INTO kanallar (kanal_adi,kanal_resim,kanal_plususerid,kanal_hit,kanal_abone,kanal_video,kanal_aboneDurum,kanal_durum,kanal_id,kanal_upload) VALUES (@kanal_adi,@kanal_resim,@kanal_plususerid,@kanal_hit,@kanal_abone,@kanal_video,@kanal_aboneDurum,@kanal_durum,@kanal_id,@kanal_upload)", baglanti);
                ekleKomut.Parameters.AddWithValue("@kanal_adi", adi);
                ekleKomut.Parameters.AddWithValue("@kanal_resim", resim);
                ekleKomut.Parameters.AddWithValue("@kanal_plususerid", plus);
                ekleKomut.Parameters.AddWithValue("@kanal_hit", hit);
                ekleKomut.Parameters.AddWithValue("@kanal_abone", abone);
                ekleKomut.Parameters.AddWithValue("@kanal_video", video);
                ekleKomut.Parameters.AddWithValue("@kanal_aboneDurum", subDurum);
                ekleKomut.Parameters.AddWithValue("@kanal_durum", kanalDurum);
                ekleKomut.Parameters.AddWithValue("@kanal_id", id);
                ekleKomut.Parameters.AddWithValue("@kanal_upload", upload);

                int sonuc = ekleKomut.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                SQLiteCommand guncelleKomut = new SQLiteCommand("UPDATE kanallar SET kanal_adi = @adi, kanal_hit = @hit, kanal_abone=@abone,kanal_video = @video,kanal_durum = @durum WHERE kanal_id = @id",baglanti);
                guncelleKomut.Parameters.AddWithValue("@id",id);
                guncelleKomut.Parameters.AddWithValue("@adi",adi);
                guncelleKomut.Parameters.AddWithValue("@hit",hit);
                guncelleKomut.Parameters.AddWithValue("@abone",abone);
                guncelleKomut.Parameters.AddWithValue("@video",video);
                guncelleKomut.Parameters.AddWithValue("@durum",kanalDurum);

                int sonuc = guncelleKomut.ExecuteNonQuery();

                if(sonuc > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool kanalGrupGuncelle(int kanalKimlik, int grup)
        {
            SQLiteCommand kanalGrupGuncelle = new SQLiteCommand("UPDATE kanallar SET kanal_grup = @grup WHERE kanal_kimlik = @kimlik", baglanti);
            kanalGrupGuncelle.Parameters.AddWithValue("@kimlik", kanalKimlik);
            kanalGrupGuncelle.Parameters.AddWithValue("@grup", grup);

            int veri = kanalGrupGuncelle.ExecuteNonQuery();

            if (veri > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool kanalNotGuncelle(int kanalKimlik, String not)
        {
            SQLiteCommand notGuncelleKomut = new SQLiteCommand("UPDATE kanallar SET kanal_not = @not WHERE kanal_kimlik = @kimlik", baglanti);
            notGuncelleKomut.Parameters.AddWithValue("@kimlik", kanalKimlik);
            notGuncelleKomut.Parameters.AddWithValue("@not", not);

            int durum = notGuncelleKomut.ExecuteNonQuery();

            if (durum > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable videoListesi(int kanal)
        {
            DataTable dt = new DataTable();

            SQLiteCommand videolariGetir = new SQLiteCommand("SELECT * FROM videolar WHERE video_kanal = @kanal",baglanti);
            videolariGetir.Parameters.AddWithValue("@kanal",kanal);

            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(videolariGetir);

            dataAdapter.Fill(dt);

            return dt;
        }

        public DataTable kanallarListesi()
        {
            DataTable dt = new DataTable();

            SQLiteCommand kanallariGetir = new SQLiteCommand("SELECT * FROM kanallar ORDER BY kanal_adi ASC", baglanti);
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(kanallariGetir);

            dataAdapter.Fill(dt);

            return dt;
        }
        #endregion

        #region Video işlemleri
        public bool videoEkle(String[] veriler,int kanal)
        {
            bool varMi = this.videoVarMi(veriler[5], kanal);

            if (!varMi)
            {
                SQLiteCommand videoEkleKomut = new SQLiteCommand("INSERT INTO videolar (video_resim,video_kanal,video_id,video_hit,video_like,video_unlike,video_adi,video_yorum,video_durum) VALUES (@resim,@kanal,@id,@hit,@like,@unlike,@adi,@yorum,@durum)", baglanti);
                videoEkleKomut.Parameters.AddWithValue("@adi", veriler[0]);
                videoEkleKomut.Parameters.AddWithValue("@hit", veriler[1]);
                videoEkleKomut.Parameters.AddWithValue("@like", veriler[2]);
                videoEkleKomut.Parameters.AddWithValue("@unlike", veriler[3]);
                videoEkleKomut.Parameters.AddWithValue("@yorum", veriler[4]);
                videoEkleKomut.Parameters.AddWithValue("@id", veriler[5]);
                videoEkleKomut.Parameters.AddWithValue("@durum", true);
                videoEkleKomut.Parameters.AddWithValue("@kanal", kanal);
                videoEkleKomut.Parameters.AddWithValue("@resim",veriler[6]);

                int sonuc = videoEkleKomut.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                SQLiteCommand videoGuncelleKomut = new SQLiteCommand("UPDATE videolar SET video_resim = @resim,video_hit = @hit,video_like = @like,video_unlike = @unlike,video_yorum = @yorum,video_durum=@durum WHERE video_kanal = @kanal AND video_id = @id",baglanti);
                videoGuncelleKomut.Parameters.AddWithValue("@kanal",kanal);
                videoGuncelleKomut.Parameters.AddWithValue("@id",veriler[5]);
                videoGuncelleKomut.Parameters.AddWithValue("@hit",veriler[1]);
                videoGuncelleKomut.Parameters.AddWithValue("@like",veriler[2]);
                videoGuncelleKomut.Parameters.AddWithValue("@unlike",veriler[3]);
                videoGuncelleKomut.Parameters.AddWithValue("@yorum",veriler[4]);
                videoGuncelleKomut.Parameters.AddWithValue("@resim",veriler[6]);
                videoGuncelleKomut.Parameters.AddWithValue("@durum",true);

                int sonuc = videoGuncelleKomut.ExecuteNonQuery();

                if(sonuc > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool videoVarMi(String id,int kanal)
        {
            SQLiteCommand videoVarMi = new SQLiteCommand("SELECT COUNT(*) FROM videolar WHERE video_kanal = @kanal AND video_id = @id",baglanti);
            videoVarMi.Parameters.AddWithValue("@kanal",kanal);
            videoVarMi.Parameters.AddWithValue("@id",id);

            int sonuc = Convert.ToInt32(videoVarMi.ExecuteScalar());

            if(sonuc > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        public long toplamHit(int kanal)
        {
            SQLiteCommand komut = new SQLiteCommand("SELECT SUM(video_hit) FROM videolar WHERE video_kanal = @kanal",baglanti);
            komut.Parameters.AddWithValue("@kanal",kanal);

            long sonuc = komut.ExecuteScalar() == DBNull.Value ? 0 : Convert.ToInt64(komut.ExecuteScalar());

            return  sonuc;
        }

        public long toplamLike(int kanal)
        {
            SQLiteCommand komut = new SQLiteCommand("SELECT SUM(video_like) FROM videolar WHERE video_kanal = @kanal", baglanti);
            komut.Parameters.AddWithValue("@kanal", kanal);

            long sonuc = komut.ExecuteScalar() == DBNull.Value ? 0 : Convert.ToInt32(komut.ExecuteScalar());

            return sonuc;
        }

        public long toplamDislike(int kanal)
        {
            SQLiteCommand komut = new SQLiteCommand("SELECT SUM(video_unlike) FROM videolar WHERE video_kanal = @kanal", baglanti);
            komut.Parameters.AddWithValue("@kanal", kanal);

            long sonuc = komut.ExecuteScalar() == DBNull.Value ? 0 : Convert.ToInt32(komut.ExecuteScalar());

            return sonuc;
        }

        public long toplamYorum(int kanal)
        {
            SQLiteCommand komut = new SQLiteCommand("SELECT SUM(video_yorum) FROM videolar WHERE video_kanal = @kanal", baglanti);
            komut.Parameters.AddWithValue("@kanal", kanal);

            long sonuc = komut.ExecuteScalar() == DBNull.Value ? 0 : Convert.ToInt32(komut.ExecuteScalar());

            return sonuc;
        }

        public bool KanalSil(string id)
        {
            SQLiteCommand kimlikGetirKomut = new SQLiteCommand("SELECT kanal_kimlik FROM kanallar WHERE kanal_id = @id",baglanti);
            kimlikGetirKomut.Parameters.AddWithValue("@id",id);

            int kimlik = Convert.ToInt32(kimlikGetirKomut.ExecuteScalar());

            SQLiteCommand komut = new SQLiteCommand("DELETE FROM kanallar WHERE kanal_kimlik = @kimlik",baglanti);
            komut.Parameters.AddWithValue("@kimlik",kimlik);

            int kanalSil = komut.ExecuteNonQuery();

            SQLiteCommand videolarSilKomut = new SQLiteCommand("DELETE FROM videolar WHERE video_kanal = @kanal",baglanti);
            videolarSilKomut.Parameters.AddWithValue("@kanal",kimlik);

            int videoSil = videolarSilKomut.ExecuteNonQuery();

            if(kanalSil > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
