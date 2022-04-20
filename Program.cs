using System;

namespace Array_Sınıfı_Metodları
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };
            //Sırasız Dizi
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            //Sıralı Dizi
            //Sort 
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            //Clear
            //SayıDizisi elemanlarını kullanarak 2.indexten itibaren 2 elemanı sıfırlar.
            Console.WriteLine("**** Array Clear ****");
            Array.Clear(sayiDizisi, 2, 2);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            //Reverse tersine çeviriyor
            Console.WriteLine("**** Array Reverse ****");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            //IndexOf
            Console.WriteLine("**** Array IndexOf ****");
            ;
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));
            //Resize
            Console.WriteLine("****  Array.Resize ****");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);


        }
    }
}
