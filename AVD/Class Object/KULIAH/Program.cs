//1
MobilSedan SL55 = new MobilSedan("Mercedes Benz","SL55",180); //instansiasi object dengan kelas MobilSedan
SL55.setHargaJual("550.000.000"); //menjalankan method setHargaJual dengan parameter berupa harga jual mobil
SL55.GetInformasi(); //menjalankan method GetInformasi untuk menampilkan informasi object pada console
Pemisah.Dash();

//2
Ikan cupang = new Ikan("Cupang", false); //instansiasi object dengan kelas Ikan
cupang.GetInformasi(); //menjalankan method GetInformasi untuk menampilkan informasi object pada console
Pemisah.Dash();

//3
Burung ayam = new Burung("Ayam", false); //instansiasi object dengan kelas Burung
ayam.GetInformasi(); //menjalankan method GetInformasi untuk menampilkan informasi object pada console
Pemisah.Dash();

//4
Komputer K413FQ = new Komputer("ASUS", "K413FQ", "Intel Core i7-10510", "NVIDIA GeForce MX350", 8); //instansiasi object dengan kelas Komputer
K413FQ.GetInformasi(); //menjalankan method GetInformasi untuk menampilkan informasi object pada console
Pemisah.Dash();


class MobilSedan
{
    private string merek; //deklarasi properties dengan access modifier private karena properties hanya akan diakses oleh kelas itu sendiri
    private string nama;
    private int kecepatan_maks;
    private string harga_jual = "Tidak dijual";
    public MobilSedan(string merek, string nama, int kecepatan_maks) //constructor (expression dieksekusi setiap object di-instansiasi)
    {
        this.merek = merek; //menetapkan nilai pada property
        this.nama = nama;
        this.kecepatan_maks = kecepatan_maks;
    }
    public void setHargaJual(string harga_jual) //mendeklarasikan method void (tidak mengembalikan nilai) untuk menetapkan harga jual mobil
    {
        this.harga_jual = harga_jual; //menetapkan nilai pada property
    }
    public void GetInformasi() //mendeklarasikan method void (tidak mengembalikan nilai) untuk menampilkan informasi mobil
    {
        Console.WriteLine("{0} {1}", this.merek, this.nama); //menampilkan nilai pada console dalam bentuk string
        Console.WriteLine("Kecepatan Maksimum: {0}", this.kecepatan_maks);
        Console.WriteLine("Harga: Rp{0}", this.harga_jual);
    }
}

abstract class Hewan //membuat abstract class sebagai template/kerangka bagi class turunannya
{
    protected string nama; //deklarasi properties dengan access modifier protected karena properties hanya akan diakses oleh class itu sendiri dan class turunannya
    protected string kelas = "";

    public Hewan(string nama) //constructor (expression dieksekusi setiap object di-instansiasi)
    {
        this.nama = nama; //menetapkan nilai pada property
    }

    public abstract void GetInformasi(); //mendeklarasikan abstract method untuk menjadi kerangka method dari class turunannya
}

class Ikan:Hewan
{
    private bool dapat_dimakan = false; //deklarasi property dengan access modifier private karena properties hanya akan diakses oleh kelas itu sendiri
    public Ikan(string nama, bool dapat_dimakan): base (nama) //constructor (expression dieksekusi setiap object di-instansiasi) dan base keyword untuk mengakses property dari parent class
    {
        this.dapat_dimakan = dapat_dimakan; //menetapkan nilai pada property
        this.kelas = "Pisces";
    }
    public override void GetInformasi() //mendeklarasikan overriding method void (tidak mengembalikan nilai) mengimplementasikan abstract method milik parent class untuk menampilkan informasi ikan
    {
        Console.WriteLine("Nama hewan: {0}",this.nama); //menampilkan nilai pada console dalam bentuk string
        Console.WriteLine("Kelas: {0}",this.kelas);
        switch (this.dapat_dimakan) //membuat pengondisian untuk mengecek apakah ikan tersebut dapat dimakan atau tidak
        {
            case true: //jika ikan tersebut dapat dimakan
                Console.WriteLine("Dapat dimakan");
                break;
            default: //jika ikan tersebut tidak dapat dimakan
                Console.WriteLine("Tidak dapat dimakan");
                break;
        }
    }
}

class Burung:Hewan
{
    private bool dapat_terbang = true; //deklarasi property dengan access modifier private karena properties hanya akan diakses oleh kelas itu sendiri
    public Burung(string nama, bool dapat_terbang) : base(nama) //constructor (expression dieksekusi setiap object di-instansiasi) dan base keyword untuk mengakses property dari parent class
    {
        this.dapat_terbang = dapat_terbang; //menetapkan nilai pada property
        this.kelas = "Aves";
    }
    public override void GetInformasi() //mendeklarasikan overriding method void (tidak mengembalikan nilai) mengimplementasikan abstract method milik parent class untuk menampilkan informasi burung
    {
        Console.WriteLine("Nama hewan: {0}", this.nama); //menampilkan nilai pada console dalam bentuk string
        Console.WriteLine("Kelas: {0}", this.kelas);
        switch (this.dapat_terbang) //membuat pengondisian mengecek apakah burung tersebut dapat terbang atau tidak
        {
            case true: //jika burung tersebut dapat terbang
                Console.WriteLine("Dapat terbang");
                break;
            default: //jika burung tersebut tidak dapat terbang
                Console.WriteLine("Tidak dapat terbang");
                break;
        }
    }
}

class Komputer
{
    private string merek; //deklarasi properties dengan access modifier private karena properties hanya akan diakses oleh kelas itu sendiri
    private string nama_model;
    private string processor;
    private string graphics_card;
    private int memory;

    public Komputer (string merek, string nama_model, string processor, string graphics_card, int memory) //constructor (expression dieksekusi setiap object di-instansiasi)
    {
        this.merek = merek; //menetapkan nilai pada property
        this.nama_model = nama_model;
        this.processor = processor;
        this.graphics_card = graphics_card;
        this.memory = memory;
    }

    public void GetInformasi() //mendeklarasikan method void (tidak mengembalikan nilai) untuk menampilkan informasi komputer
    {
        Console.Write("Overview "); //menampilkan nilai pada console dalam bentuk string
        Console.WriteLine("{0} {1}",this.merek,this.nama_model); 
        Console.WriteLine("Processor: {0}",this.processor);
        Console.WriteLine("Graphics Card: {0}",this.graphics_card);
        Console.WriteLine("Memory: {0}GB",this.memory);
    }
}

static class Pemisah //membuat static class sebagai wadah method untuk memisahkan antar nomor soal
{
    public static void Dash() //method static merupakan method yang dapat dipanggil tanpa adanya instansiasi
    {
        Console.WriteLine(String.Concat(Enumerable.Repeat("-", 50))); //menampilkan - sebanyak 50 kali
    }
}