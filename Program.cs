using System;

namespace consoleApp
{
    class program
    {
        static void Main(string[] args)
        {

                //SAYI TAHMİN OYUNU

            do
            {
                var rnd = new Random();
                int sayi = rnd.Next(1, 10);
                int hak = 5;
                int tur = 0;
                double soruPuani = 100 / hak;

                while (hak > 0)
                {
                    tur++;
                    Console.WriteLine($"{tur}. sayi giriniz");
                    int tahminEdilen = int.Parse(Console.ReadLine());
                    hak--;

                    if (sayi == tahminEdilen)
                    {
                        double puan = 100 - (soruPuani * (tur - 1));
                        Console.WriteLine($"Tebrikler {tur} defada bildiniz");
                        Console.WriteLine($"kazanılan puan {puan}");
                        break;
                    }
                    else
                    {
                        if (hak == 0)
                            break;
                        if (sayi > tahminEdilen)
                        {
                            Console.WriteLine("yukarı");
                        }
                        else
                        {
                            Console.WriteLine("aşağı");
                        }

                    }

                }

                Console.WriteLine("Oyun bitti");
                Console.WriteLine("Devam etmek istiyor musun ? (e/h)");
                string result = Console.ReadLine();
                if (result=="h" || result == "hayir")
                {
                    break;
                }
            }
            while (true);
        }
    }
}

