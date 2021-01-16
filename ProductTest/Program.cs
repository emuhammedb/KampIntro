using System;

namespace ClassIntro
{
    class Program
    {
        private static string Main(string[] args)
        {
            Product ürün1 = new Product();
            ürün1.UrunAdi = "Reyon App Hediye Kartı / Bayramınız Mübarek Olsun";
            ürün1.Satici = "Reyon App";
            ürün1.Fiyat = 2;

            Product ürün2 = new Product();
            ürün2.UrunAdi = "Nakış Gıda Ramazan Kartı";
            ürün2.Satici = "Nakış";
            ürün2.Fiyat = 5;

            Product ürün3 = new Product();
            ürün3.UrunAdi = "Beypazarı Doğal Maden Suyu";
            ürün3.Satici = "BeyStanbul";
            ürün3.Fiyat = 13;



            Product[] ürünler = new Product[] { ürün1, ürün2, ürün3 };

            foreach (var ürün in ürünler)
            {
                Console.WriteLine(ürün.UrunAdi + " " + ürün.Satici + " " + ürün.Fiyat);
            }

        }
    }

    class Product
    {
       
        public string UrunAdi { get; set; }
        public string Satici { get; set; }
        public int Fiyat { get; set; }

    }
}
