
namespace Transaksi
{
static class Transaksi
{
    public static int _uang_masuk;

    public static void Bayar(int harga_makanan)
    {
        _uang_masuk -= harga_makanan;
    }
    public static void UangMasuk()
    {
        string inputan = Console.ReadLine();
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

class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("SELAMAT DATANG DI RESTO DEA");
            Transaksi.UangMasuk();
            Console.WriteLine(Transaksi._uang_masuk);
        }
    }

}