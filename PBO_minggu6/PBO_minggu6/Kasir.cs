using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasir
{
    static class Transaksi //1. class
    {
        private static int _uang_masuk; //9. encapsulation

        public static void Bayar(int harga_makanan)
        {
            _uang_masuk -= harga_makanan;
        }
        public static void UangMasuk()
        {
            var inputan = Console.ReadLine();
            if (inputan != null)
            {
                Type tp = inputan.GetType();
                if (tp.Equals(typeof(int)))
                {
                    _uang_masuk = int.Parse(inputan);
                }
                else
                {
                    Console.WriteLine("Masukkan nominal uang dengan benar!");
                }
            }
            else
            {
                Console.WriteLine("Masukkan nominal pembayaran!");
            }
        }

    }
}
