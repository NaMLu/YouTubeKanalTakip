using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System.Data;

namespace YouTubeKanalTakip
{
    class YouTube_sinif : Veritabani
    {
        YouTubeService youtubeServis;
        Veritabani vt;

        public YouTube_sinif()
        {
            vt = new Veritabani();

            youtubeServis = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = vt.ayarGetir("api_key"),
                ApplicationName = this.GetType().ToString()
            });
        }

        public bool ApiKeyKontrol()
        {
            try
            {
                var kanalBilgileri = youtubeServis.Channels.List("snippet,contentDetails,statistics,status");
                kanalBilgileri.ForUsername = "Google";

                var sonuc = kanalBilgileri.Execute();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool kanalEkle(bool idMi, string veri)
        {
            var kanalBilgileri = youtubeServis.Channels.List("snippet,contentDetails,statistics,status");

            if (idMi == false)
            {
                kanalBilgileri.ForUsername = veri;
            }
            else
            {
                kanalBilgileri.Id = veri;
            }

            var sonuc = kanalBilgileri.Execute();

            if (sonuc.Items.Count == 0)
            {
                return false;
            }
            else
            {
                string adi = sonuc.Items[0].Snippet.Title;
                string resim = sonuc.Items[0].Snippet.Thumbnails.Default__.Url;
                string plususerid = sonuc.Items[0].ContentDetails.GooglePlusUserId;
                string izlenim = sonuc.Items[0].Statistics.ViewCount.ToString();
                string abone = sonuc.Items[0].Statistics.SubscriberCount.ToString();
                string video = sonuc.Items[0].Statistics.VideoCount.ToString();
                string subs_gizli = (sonuc.Items[0].Statistics.HiddenSubscriberCount == false ? "0" : "1");
                string durum = sonuc.Items.Count == 0 ? "0" : "1";
                string kimlik = sonuc.Items[0].Id;
                string upload = sonuc.Items[0].ContentDetails.RelatedPlaylists.Uploads;

                string[] veriler = { adi, resim, plususerid, izlenim, abone, video, subs_gizli, durum, kimlik, upload };

                return vt.kanalEkle(veriler);
            }
        }

        public bool videoEkle(String id,int kanal)
        {
            var videoBilgileri = youtubeServis.Videos.List("snippet,contentDetails,statistics,status");
            videoBilgileri.Id = id;

            var sonuc = videoBilgileri.Execute();

            if (sonuc.Items.Count == 0)
            {
                return false;
            }
            else
            {
                string title = sonuc.Items[0].Snippet.Title.ToString();
                string hit = sonuc.Items[0].Statistics.ViewCount.ToString();
                string like = sonuc.Items[0].Statistics.LikeCount.ToString();
                string unlike = sonuc.Items[0].Statistics.DislikeCount.ToString();
                string yorum = sonuc.Items[0].Statistics.CommentCount.ToString();
                string resim = "https://i.ytimg.com/vi/" + id + "/default.jpg";

                string[] veriler = { title, hit, like, unlike, yorum, id,resim };

                return vt.videoEkle(veriler, kanal);
            }
        }

        public DataTable videolariGetir(string uploads)
        {
            DataTable tablo = new DataTable();
            tablo.Columns.Add("id");

            var nextPageToken = "";
            while (nextPageToken != null)
            {
                var kanalVideolar = youtubeServis.PlaylistItems.List("snippet");
                kanalVideolar.PlaylistId = uploads;
                kanalVideolar.MaxResults = 50;
                kanalVideolar.PageToken = nextPageToken;

                var sonuc = kanalVideolar.Execute();

                foreach (var video in sonuc.Items)
                {
                    string id = video.Snippet.ResourceId.VideoId;

                    DataRow satir = tablo.NewRow();
                    satir["id"] = id;

                    tablo.Rows.Add(satir);
                }

                nextPageToken = sonuc.NextPageToken;
            }

            return tablo;
        }
    }
}
