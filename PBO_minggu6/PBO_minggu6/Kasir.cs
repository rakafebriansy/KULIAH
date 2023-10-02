using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasir
{
    static class Transaksi //1. class
    {
        private static int _uang_masuk;
        private static int _total_harga;
        private static int _kembalian;

        public static bool Bayar(int[] list_harga)
        {
            bool mampu_bayar = UangMasuk(list_harga);
            if (mampu_bayar)
            {
                Hitung();
                GetPembayaran();
            }
            return mampu_bayar;
        }
        public static bool UangMasuk(int[] list_harga)
        {
            bool mampu_bayar = true;
            for (int i = 0; i < list_harga.Length; i++)
            {
                _total_harga += list_harga[i];
            }
            while (true)
            {
                Console.Write("Masukkan nominal pembayaran: Rp");
                var uang = Console.ReadLine();
                if (int.TryParse(uang,out int _))
                {
                    int int_uang = int.Parse(uang);
                    if (int_uang < _total_harga)
                    {
                        mampu_bayar = false;
                    }
                    else
                    {
                        _uang_masuk = int_uang;                        
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Masukkan nominal pembayaran dengan benar!");
                }
            }
            return mampu_bayar;
        }
        public static void Hitung()
        {
            _kembalian = _uang_masuk - _total_harga;
        }
        public static void GetPembayaran()
        {
            Console.WriteLine();
            Console.WriteLine(String.Concat(Enumerable.Repeat("=", 29)));
            Console.WriteLine("=========== STRUK ===========");
            Console.WriteLine($"Total       : Rp{_total_harga}");
            Console.WriteLine($"Bayar       : Rp{_uang_masuk}");
            Console.WriteLine($"Kembalian   : Rp{_kembalian}");
            Console.WriteLine(String.Concat(Enumerable.Repeat("=", 29)));
        }
    }
}
