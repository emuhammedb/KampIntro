using System;

namespace ClassIntro
{
    class Program
    {
        static string Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Muhammed Enes";
            kurs1.IzlenmeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursunEgitmeni = "Engin Demiroğ";
            kurs2.IzlenmeOrani = 63;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursunEgitmeni = "Berkay Bey";
            kurs3.IzlenmeOrani = 80;


            //Console.WriteLine(kurs1.KursAdi + " / " + kurs1.KursunEgitmeni);


            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " > " +kurs.KursunEgitmeni);
            }

        }
    }

    class Kurs
    {
        //bunları ekleyebilmek için prop yazım tab a çift bastık
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
