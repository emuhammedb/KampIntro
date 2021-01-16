using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Product
    {

        //Property - Özellik demek aşağıdakilerin her biri prop dur
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }
    }
}