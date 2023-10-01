using System;
using Kasir;

namespace PBO_minggu6 //4. namespace
{
    interface IMenu //11. Interface
    {
        public static void GetMenu() { }
    }
    abstract class Menu //10. abstract
    {
        public static string[] list_pesanan = { };
        public static int[] total_pesanan = { };
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
            Console.Write("\nPilih menu makananmu:  ");
            string pesanan = Console.ReadLine();
            Console.WriteLine(pesanan);
        }
        public static void TampilkanMenu()
        {
            while (true)
            {
                Console.Write("Ingin pesan makanan/minuman?");
                string pesanan = Console.ReadLine();
                if (pesanan.ToLower() == "makanan")
                {
                    Makanan.GetMenu();
                    break; 
                } 
                else if (pesanan.ToLower() == "minuman")
                {
                    Minuman.GetMenu();
                    break;
                }
                else
                {
                    Console.WriteLine("Kamu salah pilih!\n");
                }
            }
        }
    }
    class Makanan : Menu, IMenu
    {
        protected static string[] daftar_menu_makanan = { };

        public Makanan(string nama_makanan, int harga_makanan) : base(nama_makanan, harga_makanan)
        {
            daftar_menu_makanan = daftar_menu_makanan.Concat(new string[] { nama_makanan }).ToArray();
        }
        public override void GetInformasi()  //8. overriding
        {
            Console.WriteLine($"=== Informasi Makanan ===\n{nama}    {nama}");
        }
        public static void GetMenu()
        {
            Console.WriteLine("=== Daftar Menu Makanan ===");
            for (int i = 0; i < daftar_menu_makanan.Length; i++)
            {
                Console.WriteLine($"{i + 1}. " + daftar_menu_makanan[i]);
            }
        }
    }

    class Minuman : Menu, IMenu
    {
        protected static string[] daftar_menu_minuman = { };

        public Minuman(string nama_minuman, int harga_minuman) : base(nama_minuman, harga_minuman)
        {
            daftar_menu_minuman = daftar_menu_minuman.Concat(new string[] { nama_minuman }).ToArray();
        }
        public override void GetInformasi()
        {
            Console.WriteLine($"=== Informasi Makanan ===\n{this.nama}      {this.nama}");
        }
        public static void GetMenu()
        {
            Console.WriteLine("=== Daftar Menu Minuman ===");
            for (int i = 0; i < daftar_menu_minuman.Length; i++)
            {
                Console.WriteLine($"{i + 1}. " + daftar_menu_minuman[i]);
            }
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
            Minuman menu6 = new Minuman("Teh (Hangat/Dingin", 4000);
            Minuman menu7 = new Minuman("Jeruk (Hangat/Dingin", 3000);
            Minuman menu8 = new Minuman("Teh Jahe Lemon hangat", 4500);
            Minuman menu9 = new Minuman("Choco Milkshake", 6000);
            Minuman menu10 = new Minuman("Coca Cola", 5000);

            Console.WriteLine("Selamat datang di resto DEALICIOUS\n");
            while (true)
            {
                Console.WriteLine(Menu.list_pesanan);
                Menu.TampilkanMenu();
                Menu.PilihMenu();
            }
            
        }
    }
}