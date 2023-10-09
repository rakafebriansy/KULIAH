using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Tugas3
    {
        static void Main(string[] args)
        {
            Sedan bmw = new Sedan("BMW E36", 4);
            bmw.TambahKecepatan(100);
            bmw.KurangiKecepatan(20);
            bmw.IsiBagasi(8);
            bmw.GetInformasi();

            Truk fuso = new Truk("Fuso FM65FL", 2);
            fuso.TambahKecepatan(60);
            fuso.IsiMuatan(32);
            fuso.GetInformasi();

            SepedaMotor vario = new SepedaMotor("Vario 125", 2);
            vario.TambahKecepatan(85);
            vario.TambahKecepatan(30);
            vario.GetInformasi();
        }
    }

    abstract class Otomobil
    {
        protected int jumlah_penumpang;
        protected int kecepatan;

        public Otomobil(int jumlah_penumpang)
        {
            this.jumlah_penumpang = jumlah_penumpang;
        }
        public void TambahKecepatan(int kecepatan)
        {
            this.kecepatan += kecepatan;
        }
        public void KurangiKecepatan(int kecepatan)
        {
            this.kecepatan -= kecepatan;
        }
        public abstract void GetInformasi();
    }

    class Sedan : Otomobil
    {
        private string merek_mobil;
        private int kapasitas_bagasi = 10;

        public Sedan (string merek_mobil, int jumlah_penumpang) : base(jumlah_penumpang)
        {
            this.merek_mobil = merek_mobil;
            this.jumlah_penumpang = jumlah_penumpang;
        }
        public void IsiBagasi(int bobot)
        {
            if (kapasitas_bagasi - bobot > 0)
            {
                this.kapasitas_bagasi -= bobot;
            } else
            {
                Console.WriteLine("Kapasitas bagasi telah mencapai maksimum.");
            }
        }
        public override void GetInformasi()
        {
            Console.WriteLine($"Mobil {merek_mobil} dengan jumlah penumpang {jumlah_penumpang} memiliki sisa kapasitas bagasi {kapasitas_bagasi}kg dan melaju dengan kecepatan {kecepatan}km/jam\n");
        }
    }

    class Truk : Otomobil
    {
        private string merek_truk;
        private int kapasitas_muatan = 50;

        public Truk(string merek_truk, int jumlah_penumpang) : base (jumlah_penumpang)
        {
            this.merek_truk = merek_truk;
            this.jumlah_penumpang = jumlah_penumpang;
        }
        public void IsiMuatan(int bobot)
        {
            if (kapasitas_muatan - bobot > 0)
            {
                this.kapasitas_muatan -= bobot;
            }
            else
            {
                Console.WriteLine("Kapasitas muatan telah mencapai maksimum.");
            }
        }
        public override void GetInformasi()
        {
            Console.WriteLine($"Truk {merek_truk} dengan jumlah penumpang {jumlah_penumpang} memiliki sisa kapasitas bagasi {kapasitas_muatan}kg dan melaju dengan kecepatan {kecepatan}km/jam\n");
        }
    }

    class SepedaMotor : Otomobil
    {
        private string merek_sepeda_motor;
        private int jumlah_helm;

        public SepedaMotor(string merek_sepeda_motor, int jumlah_penumpang) : base(jumlah_penumpang)
        {
            this.merek_sepeda_motor = merek_sepeda_motor;
            this.jumlah_penumpang = jumlah_penumpang;
        }
        public void TambahHelm(int helm)
        {
            if (jumlah_helm < 2)
            {
            this.jumlah_helm += helm;
            }
            else
            {
                Console.WriteLine("Jumlah helm sudah maksimum.");
            }
        }
        public override void GetInformasi()
        {
            Console.WriteLine($"Sepeda motor {merek_sepeda_motor} dengan jumlah penumpang {jumlah_penumpang} memiliki {jumlah_helm} helm yang tersedia dan melaju dengan kecepatan {kecepatan}\n");
        }
    }
}
