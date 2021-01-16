using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention Ekle nin baş harfini büyük yaptığımız gibi //C# ve Java gibi dillerde eger _()_ varsa method vardır orada
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + product.Adi);

        } //bunu uygula üsttekini

        public void Ekle2(string productAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + productAdi);
        }
    }
}
