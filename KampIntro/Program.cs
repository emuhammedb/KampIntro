using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type safety = tip güvenliği (Java ve C# gibi diller için)
            //yorum satırı bununla eklenir
            //"alias" yani değer tutucu örnek kategoriEtiketi

            string kategoriEtiketi = "Kategoriler"; // metinsel
            int ogrenciSayisi = 32000; //tam sayi
            double faizOrani = 1.45; // ondalikli sayi
            bool sistemeGirisYapmisMi = true;//true bir veri kaynağından gelen kısımdır //Javadaki boolean ile eş değer
            
            
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Eşittir");
            }


           //sart bloklari if(eğer) den sonra (buraya şart yazılır)  {blok yazılır} | iki defa tab a basarsak burayı oluşturur

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları butonu");
            }
            else//değilse
            {
                Console.WriteLine("Giriş Yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
