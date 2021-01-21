using System;
using System.Collections.Generic;
namespace MyDictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ogrenci = new Dictionary<int, string>();
            ogrenci.Add(123, "Duygu UĞUR");
            ogrenci.Add(124, "Ahmet Yasar");
            ogrenci.Add(125, "Samet Mutlu");
            ogrenci.Add(126, "Fatma Kurt");
            ogrenci.Add(127, "Furkan Bereket");
            ogrenci.Add(128, "Beyza Yüksel");

            foreach (var ogrenciler in ogrenci )
            {
                Console.WriteLine( "Ogrenci No : " + ogrenciler.Key + "\t Adi-Soyadi :  " + ogrenciler.Value);
            }
        }
    }
}
