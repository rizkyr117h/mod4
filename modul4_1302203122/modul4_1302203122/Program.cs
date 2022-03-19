using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302203122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            penjumlahan.JumlahTigaAngka<float>(13, 02, 20);
            Console.WriteLine("TES");
        }
    }
    class penjumlahan
    {
        public static void JumlahTigaAngka<T>(T tambah1, T tambah2, T tambah3)
        {
            dynamic angka1 = tambah1;
            dynamic angka2 = tambah2;
            dynamic angka3 = tambah3;

            Console.WriteLine(angka1 + angka2 + angka3);
        }
    }

}
