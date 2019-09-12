using System;

namespace quiz09092019
{
    class Program
    {
        static void Main(string[] args)
        {
            bangundatar obj = new bangundatar();

            int s;

            Console.WriteLine("=======================");
            Console.WriteLine("Menghitung luas persegi");
            Console.WriteLine("=======================");

            Console.WriteLine("masukkan nilai sisi :");
            s = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nilai luas persegi adalah " +bangundatar.Luas_Persegi(s));

            int a , t;

            Console.WriteLine("========================");
            Console.WriteLine("Menghitung luas segitiga");
            Console.WriteLine("========================");

            Console.WriteLine("masukkan nilai alas :");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("masukkan nilai tinggi :");
            t = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nilai luas segitiga adalah " +bangundatar.Luas_Segitiga(a , t));


            int radius;

            Console.WriteLine("========================");
            Console.WriteLine("Menghitung luas lingkaran");
            Console.WriteLine("========================");

            Console.WriteLine("masukkan jari-jari:");
            radius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("luas lingkaran adalah "+bangundatar.Luas_Lingkaran(radius));

            bangunruang objt = new bangunruang();

            int panjang, lebar, tinggi;

            Console.WriteLine("========================");
            Console.WriteLine("Menghitung Volume Balok");
            Console.WriteLine("========================");

            Console.WriteLine("masukkan panjang:");
            panjang = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("masukkan lebar:");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("masukkan tinggi:");
            tinggi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nilai volume balok adalah "+bangunruang.volume_balok(tinggi, lebar, panjang));

            Console.WriteLine("========================");
            Console.WriteLine("Menghitung Volume Kubus");
            Console.WriteLine("========================");

            int sisi;

            Console.WriteLine("masukkan nilai rusuk: ");
            sisi = Convert.ToInt32(Console.ReadLine());

            objt.volume_kubus(sisi);
        }
    }
}