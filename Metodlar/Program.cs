using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır Karpuzu";

            Product[] Products = new Product[] { product1, product2 };

            foreach (Product product in Products)
            {
                Console.WriteLine(product.Adi + ":" + product.Aciklama);
            }



            Console.WriteLine("------------------Metodlar------------------");


            SepetManager sepetManeger = new SepetManager();
            sepetManeger.Ekle(product1);
            sepetManeger.Ekle2("Armut",  "Yeşil Armut", 12);
            sepetManeger.Ekle2("Elma", "Yeşil Elma", 12);
            sepetManeger.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12);

            Console.WriteLine("Hello World!");
        }
    }
}



//Dont repeat yourself - DRY - Clean Code - Best Pratice