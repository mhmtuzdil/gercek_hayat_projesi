using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_uygulaması
{
    public class Kitap
    {
        public string Baslik { get; set; }
        public string Yazar { get; set; }
        public string ISBN { get; set; }
        public int YayinYili { get; set; }
        public bool Durum { get; set; } 

        
        public Kitap(string baslik, string yazar, string isbn, int yayinYili)
        {
            this.Baslik = baslik;
            this.Yazar = yazar;
            this.ISBN = isbn;
            this.YayinYili = yayinYili;
            this.Durum = true;
        }


        public string Oku_KitapBilgileri()
        {
            string durumMetni = Durum ? "Müsait" : "Ödünç Alınmış";
            return $"[{ISBN}] {Baslik} - {Yazar} ({YayinYili}) | Durum: {durumMetni}";
        }
       
    }
}
