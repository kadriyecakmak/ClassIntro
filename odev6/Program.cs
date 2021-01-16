using System;

namespace odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            string müsteriAdi = "Kadriye";
            Console.WriteLine("Hoşgeldin" + " : " + müsteriAdi);

            Product product1 = new Product();
            product1.EticarePaketleri = "EKO";
            Product product2 = new Product();
            product2.EticarePaketleri = "KOBİ";
            Product product3 = new Product();
            product3.EticarePaketleri = "PRO";
            Product product4 = new Product();
            product4.EticarePaketleri = "KOBİ";
            Product product5 = new Product();
            product5.EticarePaketleri = "FAVORİ JET";
            Product product6 = new Product();
            product6.EticarePaketleri = "ROKET";

            product1.PaketFiyatlari = 650;
            product2.PaketFiyatlari = 1000;
            product3.PaketFiyatlari = 1250;
            product4.PaketFiyatlari = 1600;
            product5.PaketFiyatlari = 2800;
            product6.PaketFiyatlari = 3850;

            Product[] products = new Product[] { product1, product2, product3, product3, product4, product5, product6 };

            foreach (var product in products)
            {
                Console.WriteLine(product.EticarePaketleri + " :" + product.PaketFiyatlari);
            }
            Console.WriteLine("foreach Bitti");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].EticarePaketleri + " :" + products[i].PaketFiyatlari);
            }
            Console.WriteLine("For bitti");
            int sayac = 0;

            while (sayac < products.Length)
    {
                Console.WriteLine(products[sayac].EticarePaketleri + " :" + products[sayac].PaketFiyatlari);
                sayac++;
            }
            Console.WriteLine("while bitti");
            Console.WriteLine("-------------------------");
            Console.WriteLine("%30 BİTMEDEN JETTEKNOLOJİ.COM'A GELİN");









        }
        class Product
        {
            public string EticarePaketleri { get; set; }

            public int PaketFiyatlari { get; set; }

        }
    }
    }

