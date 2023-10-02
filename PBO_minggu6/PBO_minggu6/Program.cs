using System;
using Kasir; //12. library class

namespace PBO_minggu6 //5. namespace
{
    interface IMenu //11. Interface
    {
        public static void GetMenu() { }
        public static void GetArray() { }
    }
    abstract class Menu //10. abstract
    {
        private static string[] _list_pesanan = { };  
        private static int[] _list_harga = { };
        protected string nama; //3. attribute
        protected int harga;
        protected int diskon;

        public Menu(string nama, int harga)
        {
            this.nama = nama;
            this.harga = harga;
        }

        public abstract void GetInformasi();
        public static int[] GetListHarga() //4. method
        {
            return _list_harga;
        }
        public static void PilihMenu()
        {
            while (true)
            {
                Console.Write("Pilih menu makananmu:  ");
                string pesanan = Console.ReadLine();
                if (Makanan.GetArray("").Contains(pesanan))
                {
                    _list_pesanan = _list_pesanan.Concat(new string[] { pesanan }).ToArray();
                    int index = Array.IndexOf(Makanan.GetArray(""), pesanan);
                    _list_harga = _list_harga.Concat(new int[] { Makanan.GetArray(0)[index] }).ToArray();
                    break;
                }
                else if (Minuman.GetArray("").Contains(pesanan))
                {
                    _list_pesanan = _list_pesanan.Concat(new string[] { pesanan }).ToArray();
                    int index = Array.IndexOf(Minuman.GetArray(""), pesanan);
                    _list_harga = _list_harga.Concat(new int[] { Minuman.GetArray(0)[index] }).ToArray();
                    break;
                }
                else if (pesanan == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nMasukkan menu dengan benar!\n");
                }
            }
        }
        public static void TampilkanPesanan()
        {
            Console.WriteLine("======== Pesanan Anda ========\n");
            if (_list_pesanan.Length == 0)
            {
                Console.WriteLine("Anda belum memesan apapun");
            }
            else
            {
                for (int i = 0; i < _list_pesanan.Length; i++)
                {
                    Console.WriteLine("- " + _list_pesanan[i] + " Rp" + _list_harga[i]);
                }
            }
            Console.Write("\n");
            Console.WriteLine(String.Concat(Enumerable.Repeat("=", 30)));
        }
        public static bool TampilkanMenu()
        {
            while (true)
            {
                Console.Write("Masukkan Perintah.\n1. Pilih Menu\n2. Bayar\n");
                string perintah = Console.ReadLine(); Console.Write("\n");
                perintah = perintah.Replace(" ", "");
                if (perintah == "1")
                {
                    while (true)
                    {
                        Console.Write("Masukkan Perintah.\n1. Pesan Makanan\n2. Pesan Minuman\n0. Kembali\n");
                        string pesanan = Console.ReadLine();
                        pesanan = pesanan.Replace(" ", "");
                        if (pesanan.ToLower() == "1")
                        {
                            Console.WriteLine("\n==== Daftar Menu Makanan ====");
                            Makanan.GetMenu();
                            Console.WriteLine("0. Kembali");
                            Console.WriteLine(String.Concat(Enumerable.Repeat("=", 29)));
                            PilihMenu();
                            break;
                        }
                        else if (pesanan.ToLower() == "2")
                        {
                            Console.WriteLine("\n==== Daftar Menu Minuman ====");
                            Minuman.GetMenu();
                            Console.WriteLine("0. Kembali");
                            Console.WriteLine(String.Concat(Enumerable.Repeat("=", 29)));
                            PilihMenu();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Kamu salah pilih!\n");
                        }
                    }
                    return false;
                }
                else if (perintah == "2")
                {
                    return true;
                }
                else if (perintah == "0")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Masukkan perintah dengan benar!");
                }
            }
        }
        public virtual int SetDiskon(int diskon) //6. Polymorphism
        {
            return diskon;
        }
    }
    class Makanan : Menu, IMenu
    {
        protected static string[] daftar_menu_makanan = { };
        protected static int[] daftar_harga_makanan = { };

        public Makanan(string nama_makanan, int harga_makanan, int diskon = 0) : base(nama_makanan, harga_makanan)
        {
            daftar_menu_makanan = daftar_menu_makanan.Concat(new string[] { nama_makanan }).ToArray();
            if (diskon > 0)
            {
                this.diskon = diskon;
                daftar_harga_makanan = daftar_harga_makanan.Concat(new int[] { this.SetDiskon(harga_makanan) }).ToArray();
            }
            else
            {
                daftar_harga_makanan = daftar_harga_makanan.Concat(new int[] { harga_makanan }).ToArray();
            }
        }
        public override void GetInformasi()
        {
            Console.WriteLine($"=== Informasi Makanan ===\n{nama}    {nama}");
        }
        public static void GetMenu()
        {
            for (int i = 0; i < daftar_menu_makanan.Length; i++)
            {
                Console.WriteLine("- " + daftar_menu_makanan[i]);
            }
        }
        public static string[] GetArray(string str) //7. overloading
        {
            return daftar_menu_makanan;
        }
        public static int[] GetArray(int integer)
        {
            return daftar_harga_makanan;
        }
        public override int SetDiskon(int harga_makanan) //8. overriding
        {
            return harga_makanan - (harga_makanan * this.diskon / 100);
        }
    }

    class Minuman : Menu, IMenu
    {
        protected static string[] daftar_menu_minuman = { };
        protected static int[] daftar_harga_minuman = { };

        public Minuman(string nama_minuman, int harga_minuman, int diskon = 0) : base(nama_minuman, harga_minuman)
        {
            daftar_menu_minuman = daftar_menu_minuman.Concat(new string[] { nama_minuman }).ToArray();
            if (diskon > 0)
            {
                this.diskon = diskon;
                daftar_harga_minuman = daftar_harga_minuman.Concat(new int[] { this.SetDiskon(harga_minuman) }).ToArray();
            }
            else
            {
                daftar_harga_minuman = daftar_harga_minuman.Concat(new int[] { harga_minuman }).ToArray();
            }
        }
        public override void GetInformasi()
        {
            Console.WriteLine($"=== Informasi Makanan ===\n{this.nama}      {this.nama}");
        }
        public static void GetMenu()
        {
            for (int i = 0; i < daftar_menu_minuman.Length; i++)
            {
                Console.WriteLine("- " + daftar_menu_minuman[i]);
            }
        }
        public static string[] GetArray(string str)
        {
            return daftar_menu_minuman;
        }
        public static int[] GetArray(int integer)
        {
            return daftar_harga_minuman;
        }
        public override int SetDiskon(int harga_minuman)
        {
            return harga_minuman - (harga_minuman * this.diskon/100);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Makanan menu1 = new Makanan("Nasi Goreng", 10000, 20); //2. object
            Makanan menu2 = new Makanan("Mie Goreng", 15000);
            Makanan menu3 = new Makanan("Capcay", 7000);
            Makanan menu4 = new Makanan("Nasi Fuyunghai", 15000, 5);
            Makanan menu5 = new Makanan("Nasi Campur Jagung", 20000);
            Minuman menu6 = new Minuman("Teh", 4000, 50);
            Minuman menu7 = new Minuman("Jeruk", 3000);
            Minuman menu8 = new Minuman("Teh Jahe Lemon", 4500);
            Minuman menu9 = new Minuman("Choco Milkshake", 6000, 3);
            Minuman menu10 = new Minuman("Coca Cola", 5000);

            Console.WriteLine("Selamat datang di resto DEALICIOUS\n");
            while (true)
            {
                Console.WriteLine(String.Concat(Enumerable.Repeat("=", 30)));
                Menu.TampilkanPesanan();
                bool kondisi_bayar = Menu.TampilkanMenu();
                if (kondisi_bayar)
                {
                    int[] list_harga = Menu.GetListHarga();
                    bool mampu_bayar = Transaksi.Bayar(list_harga);
                    if (mampu_bayar)
                    {
                        Console.WriteLine("Terima kasih sudah datang di resto kami\nSalam hangat, DEALICIOUS!");
                    }
                    else
                    {
                        Console.WriteLine("\nUang anda tidak cukup!\nCUCI PIRING SEKARANG!");
                    }
                    break;
                }
                Console.WriteLine(String.Concat(Enumerable.Repeat("=", 30)));
                Console.Write("\n\n");
            }
            
        }
    }
}