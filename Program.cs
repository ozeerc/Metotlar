using System;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyat = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyat = 80;
            product2.Aciklama = "Diyarbakır Karpuzu";


            Product[] products = new Product[] { product1, product2 };

            //type safe -- tip güvenli
            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyat);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("");
            Console.WriteLine("---------Metotlar----------");
            Console.WriteLine("");

            //instance - örnek
            //encapsulation - kapsülleme

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            Console.WriteLine("");
            Console.WriteLine("------------");
            Console.WriteLine("");

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 5);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 15, 85);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 80, 41);
        }
    }
}


//Don't repeat yourself - DRY - Clean Code - Best Practise
