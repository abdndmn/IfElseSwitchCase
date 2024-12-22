// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;


namespace IfElse
{
    class ProgramIfElse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rüya Manavina Hosgeldiniz!");
            Console.WriteLine("Elma= 2 TL");
            Console.WriteLine("Armut= 3 TL");
            Console.WriteLine("Çilek= 2 TL");
            Console.WriteLine("Muz= 3 TL");
            Console.WriteLine("Diğer Tüm Meyveler= 4 TL");
            Console.Write("Hangi Meyveyi Satın Almak İstersiniz? (Elma/Armut/Çilek/Muz/Diğer):");
            string meyve = Console.ReadLine()?.ToLower();
            if (meyve == "elma")
            {
                Console.WriteLine("Sectiginiz Meyvenin Fiyati 2 TL'dir.");
            }
            else if (meyve == "armut")
            {
                Console.WriteLine("Sectiginiz Meyvenin Fiyati 3 TL'dir.");
            }
            else if (meyve == "cilek")
            {
                Console.WriteLine("Sectiginiz Meyvenin Fiyati 2 TL'dir.");
            }
            else if (meyve == "muz")
            {
                Console.WriteLine("Sectiginiz Meyvenin Fiyati 3 TL'dir.");
            }
            else if (meyve == "diger")
            {
                Console.WriteLine("Diğer Tüm Meyveler 4 TL' dir");
            }
            else
            {
                Console.WriteLine("Lütfen Satın Almak İstediğiniz Meyveyi Seçiniz!");
            }
            ////Bu program için Swift kullanımı daha uygun, Case değeri bulunduğu anda kod sonlandırılacağı için geri kalan koşullar için çalışmaya gerek kalmayacak.
            // Ayrıca koşulun sadece eşitlik içermesi, Switch karar yapısı için daha uygun. Daha karmaşık, değer aralıkları içeren koşullar için if else çalıştırabilirdik.


        }
    }
}



