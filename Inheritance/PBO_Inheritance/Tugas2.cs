//using System;

//namespace Inheritance
//{
//    internal class Tugas2
//    {
//        static void Main(string[] args)
//        {
//            MobilSedan audi = new MobilSedan("Audi",200);
//            audi.TambahKecepatan(180);
//            audi.KurangiKecepatan(20);
//            Console.WriteLine(audi.GetKecepatan() + "\n");

//            Ikan bandeng = new Ikan("Bandeng", 215);
//            bandeng.Makan(40);
//            Console.WriteLine(bandeng.GetBobot() + "\n");

//            PionCatur pion = new PionCatur("hitam", "B7");
//            pion.Melangkah("B5");
//            Console.WriteLine(pion.GetPosisi() + "\n");

//            RekeningBank rek = new RekeningBank("00951278008112", 200000);
//            rek.SetorTunai(10000);
//            rek.TarikTunai(80000);
//            Console.WriteLine(rek.GetSaldo());
//            Console.Read();
//        }
//    }
//    class MobilSedan
//    {
//        private string merek;
//        private int kecepatan_maks, kecepatan = 0;

//        public MobilSedan(string merek, int kecepatan_maks)
//        {
//            this.merek = merek;
//            this.kecepatan_maks = kecepatan_maks;
//        }
//        public void TambahKecepatan(int kecepatan)
//        {
//            if ((this.kecepatan + kecepatan) <= kecepatan_maks)
//            {
//                this.kecepatan += kecepatan;
//            }
//            else
//            {
//                Console.WriteLine("Kecepatan sudah maksimum!");
//            }
//        }
//        public void KurangiKecepatan(int kecepatan)
//        {
//            this.kecepatan -= kecepatan;
//        }
//        public string GetKecepatan()
//        {
//            return $"Kecepatan mobil {merek} saat ini adalah {kecepatan}.";
//        }
//    }
//    class Ikan
//    {
//        private string jenis;
//        private float bobot;

//        public Ikan(string jenis, float bobot)
//        {
//            this.jenis = jenis;
//            this.bobot = bobot;
//        }
//        public void Makan(int berat_makanan)
//        {
//            bobot += berat_makanan;
//        }
//        public string GetBobot()
//        {
//            return $"Bobot ikan {jenis} sekarang adalah {bobot} lbs.";
//        }
//    }
//    class PionCatur
//    {
//        private string warna, posisi;

//        public PionCatur(string warna, string posisi)
//        {
//            this.warna = warna;
//            this.posisi = posisi;
//        }
//        public void Melangkah(string posisi_baru)
//        {
//            if (posisi_baru.Substring(0,1) == posisi.Substring(0,1) && Math.Abs(int.Parse(posisi_baru.Substring(1)) - int.Parse(posisi.Substring(1))) <= 2)
//            {
//                this.posisi = posisi_baru;
//            } else
//            {
//                Console.WriteLine("Langkah tidak valid!");
//            }
//        }
//        public string GetPosisi()
//        {
//            return $"Pion {warna} berada di {posisi}.";
//        }
//    }
//    class RekeningBank
//    {
//        private string no_rekening;
//        private int saldo;
//        public RekeningBank(string no_rekening, int saldo_awal)
//        {
//            this.no_rekening = no_rekening;
//            this.saldo = saldo_awal;
//        }
//        public void SetorTunai (int jumlah_setor)
//        {
//            this.saldo += jumlah_setor;
//        }
//        public void TarikTunai (int jumlah_tarik)
//        {
//            this.saldo -= jumlah_tarik;
//        }
//        public string GetSaldo()
//        {
//            return $"Saldo akun dengan no. rekening {no_rekening} adalah Rp {saldo}.";
//        }

//    }
//}
