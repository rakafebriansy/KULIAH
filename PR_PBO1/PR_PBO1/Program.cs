namespace LOL
{
    class Processor { protected string merk; protected string tipe; }
    class Intel : Processor { public Intel() { this.merk = "Intel"; } }
    class CoreI3 : Intel { public CoreI3() { this.tipe = "Core i3"; } }
    class CoreI5 : Intel { public CoreI5() { this.tipe = "Core i5"; } }
    class CoreI7 : Intel { public CoreI7() { this.tipe = "Core i7"; } }
    class AMD : Processor { public AMD() { this.merk = "AMD"; } }
    class Ryzen : AMD { public Ryzen() { this.tipe = "RAYZEN"; } }
    class Athlon : AMD { public Athlon() { this.tipe = "ATHLON"; } }


    class Vga { protected string merk; }
    class Nvidia:Vga { public Nvidia() { this.merk = "Nvidia"; } }
    class AMD:Vga { public AMD() { this.merk = "AMD"; } }

    class Laptop
    {
        protected string merk; protected string tipe; protected Vga vga; protected Processor processor;
    }

}

