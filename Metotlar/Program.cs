using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Products urun1 = new Products();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Products urun2 = new Products();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 85;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Products[] urunler = new Products[] { urun1, urun2 };

            foreach (Products urun  in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------");
            }

            Console.WriteLine("------------Metotlar----------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Armut","Yeşil armut",12,15);
            sepetManager.Ekle2("Elma", "Yeşil elmet", 13,20);
            sepetManager.Ekle2("incir", "Aydın inciri", 14,5);



            Console.WriteLine("Hello World!");
        }
    }
}

//do not repeat yourself - DRY- Clean code - Best practice