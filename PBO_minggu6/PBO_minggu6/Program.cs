using System;
using Kasir;

namespace PBO_minggu6 //4. namespace
{
    interface IMenu //11. Interface
    {
        public static void GetMenu() { }
        public static void GetMenuArray() { }
        public static void GetHargaArray() { }
    }
    abstract class Menu //10. abstract
    {
        private static string[] list_pesanan = { };
        private static int total_pesanan = 0;
        protected string nama; //3. attribute
        protected int harga;

        public Menu(string nama, int harga)
        {
            this.nama = nama;
            this.harga = harga;
        }

        public abstract void GetInformasi();
        public static void PilihMenu()
        {
            while (true)
            {
                Console.Write("Pilih menu makananmu:  ");
                string pesanan = Console.ReadLine();
                if (string.IsNullOrEmpty(pesanan))
                {
                    Console.WriteLine("\nInputan masih kosong!!\n");
                }
                else if (Minuman.GetMenuArray().Contains(pesanan) || Makanan.GetMenuArray().Contains(pesanan))
                {
                    list_pesanan = list_pesanan.Concat(new string[] { pesanan }).ToArray();
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
            Console.WriteLine("======== Pesanan Anda ========");
            for (int i = 0; i < Menu.list_pesanan.Length; i++)
            {
                Console.WriteLine("- " + list_pesanan[i]);
            }
            Console.WriteLine();
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
                            Makanan.GetMenu();
                            PilihMenu();
                            break;
                        }
                        else if (pesanan.ToLower() == "2")
                        {
                            Minuman.GetMenu();
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
                    bool kondisi_bayar = Bayar();
                    Console.WriteLine(total_pesanan);
                    return kondisi_bayar;
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
        public static bool Bayar()
        {
            string[] menu_makanan = Makanan.GetMenuArray();
            string[] menu_minuman = Minuman.GetMenuArray();
            for (int i = 0; i < list_pesanan.Length; i++)
            {
                if (menu_makanan.Contains(list_pesanan[i]))
                {
                    var index = Array.IndexOf(menu_makanan, list_pesanan[i]);
                    total_pesanan += Makanan.GetHargaArray()[index];
                }
                else if (menu_minuman.Contains(list_pesanan[i]))
                {
                    var index = Array.IndexOf(menu_minuman, list_pesanan[i]);
                    total_pesanan += Minuman.GetHargaArray()[index];
                }
            }
            return true;
        }
    }
    class Makanan : Menu, IMenu
    {
        protected static string[] daftar_menu_makanan = { };
        protected static int[] daftar_harga_makanan = { };

        public Makanan(string nama_makanan, int harga_makanan) : base(nama_makanan, harga_makanan)
        {
            daftar_menu_makanan = daftar_menu_makanan.Concat(new string[] { nama_makanan }).ToArray();
            daftar_harga_makanan = daftar_harga_makanan.Concat(new int[] { harga_makanan }).ToArray();
        }
        public override void GetInformasi()  //8. overriding
        {
            Console.WriteLine($"=== Informasi Makanan ===\n{nama}    {nama}");
        }
        public static void GetMenu()
        {
            Console.WriteLine("\n======== Daftar Menu Makanan ========");
            for (int i = 0; i < daftar_menu_makanan.Length; i++)
            {
                Console.WriteLine("- " + daftar_menu_makanan[i]);
            }
        }
        public static string[] GetMenuArray()
        {
            return daftar_menu_makanan;
        }
        public static int[] GetHargaArray()
        {
            return daftar_harga_makanan;
        }
    }

    class Minuman : Menu, IMenu
    {
        protected static string[] daftar_menu_minuman = { };
        protected static int[] daftar_harga_minuman = { };

        public Minuman(string nama_minuman, int harga_minuman) : base(nama_minuman, harga_minuman)
        {
            daftar_menu_minuman = daftar_menu_minuman.Concat(new string[] { nama_minuman }).ToArray();
            daftar_harga_minuman = daftar_harga_minuman.Concat(new int[] { harga_minuman }).ToArray();
        }
        public override void GetInformasi()
        {
            Console.WriteLine($"=== Informasi Makanan ===\n{this.nama}      {this.nama}");
        }
        public static void GetMenu()
        {
            Console.WriteLine("\n======== Daftar Menu Minuman ========");
            for (int i = 0; i < daftar_menu_minuman.Length; i++)
            {
                Console.WriteLine($"{i + 1}. " + daftar_menu_minuman[i]);
            }
        }
        public static string[] GetMenuArray()
        {
            return daftar_menu_minuman;
        }
        public static int[] GetHargaArray()
        {
            return daftar_harga_minuman;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Makanan menu1 = new Makanan("Nasi Goreng", 10000); //2. object
            Makanan menu2 = new Makanan("Mie Goreng", 15000);
            Makanan menu3 = new Makanan("Capcay", 7000);
            Makanan menu4 = new Makanan("Nasi Fuyunghai", 15000);
            Makanan menu5 = new Makanan("Nasi Campur Jagung", 20000);
            Minuman menu6 = new Minuman("Teh", 4000);
            Minuman menu7 = new Minuman("Jeruk", 3000);
            Minuman menu8 = new Minuman("Teh Jahe Lemon", 4500);
            Minuman menu9 = new Minuman("Choco Milkshake", 6000);
            Minuman menu10 = new Minuman("Coca Cola", 5000);

            Console.WriteLine("Selamat datang di resto DEALICIOUS\n");
            while (true)
            {
                bool kondisi_bayar = false;
                Console.WriteLine(String.Concat(Enumerable.Repeat("=", 30)));
                Menu.TampilkanPesanan();
                kondisi_bayar = Menu.TampilkanMenu();
                if (kondisi_bayar)
                {
                    Console.WriteLine("\n\nMasuk class library!");
                    break;
                }
                Console.WriteLine(String.Concat(Enumerable.Repeat("=", 30)));
                Console.Write("\n\n");
            }
            
        }
    }
}