using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            
        }
    }
}


//bu hususu anlarsak tam anlamıyla kavrayabiliriz diğerlerinide ÇOK ÖNEMLİ -- bundan sonra yazılım hayatı çok kolay olacak kavramak önemli olan
//sektörde de az bilinen bir konu
//int, decimal, float, double, bool = değer tip
//array, class, interface = referans tip