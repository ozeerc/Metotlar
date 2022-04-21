using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    internal class SepetManager
    {
        //naming convention - isimlendirme kuralı
        //syntax - yazım şekli

        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler, " + product.Adi + "  Ürünü Sepete Eklendi!");
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler, " + urunAdi + "  Ürünü Sepete Eklendi!");
        }
    }
}