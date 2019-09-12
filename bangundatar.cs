using System;

namespace quiz09092019
{
    class bangundatar
    {
        public static int Luas_Persegi(int angka1)
        {
            return angka1 * angka1;
        }

        public static int Luas_Segitiga(int tinggi , int alas)
        {
            return tinggi * alas / 2;
        }

        public static int Luas_Lingkaran(int radius)
        {
           return 22/7 * radius * radius;
        }
    }
}