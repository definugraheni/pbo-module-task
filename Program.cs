//Defi Nugraheni (222410102041) PBO_A

class Program
{
    static void Main(string[] args)
    {
        //laptop 1
        Laptop laptop1 = new Laptop();
        Nvidia nvidia = new Nvidia();
        CoreI5 corei5 = new CoreI5();
        Vivobook vivobook = new Vivobook();
        laptop1 = vivobook;
        vivobook.Ngoding();
        //soal 1
        //laptop1.Ngoding();

        //nomor 3
        Console.WriteLine($"laptop1 dengan merk vga {nvidia.merk}, merk processor {corei5.merk}, dan tipe processor {corei5.tipe}");


       // Laptop 2
        Laptop laptop2 = new Laptop();
        amd amd = new amd();
        Ryzen ryzen = new Ryzen();
        IdeaPad ideapad = new IdeaPad(amd, ryzen);
        laptop2 = ideapad;
        //nomor 2
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();


        //laptop predator
        CoreI7 coreI7 = new CoreI7();
        Predator Predator = new Predator(amd, coreI7);
        //nomor 4
        Predator.BermainGame();



        //soal 5
        //ACER acer = new ACER();
        //Predator predator = new Predator();
        //acer.BermainGame();
        //predator.BermainGame();
    }
}


//laptop
class Laptop
{
    public string merk;
    public string tipe;
    public Vga vga;
    public Processor processor;

    
    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {this.merk} {this.tipe} menyala");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {this.merk} {this.tipe} mati");
    }
}

class ASUS : Laptop
{
    public ASUS()
    {
        base.merk = "ASUS";
    }
}

class ROG : ASUS
{
    
    public ROG()
    {
        base.tipe = "ROG";
    }
}

class Vivobook : ASUS
{
    public Vivobook()
    {
        base.tipe = "Vivobook";
    }

    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class ACER : Laptop
{
    public ACER()
    {
        base.merk = "ACER";
    }
    
}

class Swift : ACER
{
    public Swift()
    {
        base.tipe = "Swift";
    }
}

class Predator : ACER
{
    public Predator(Vga vga, Processor processor)
    {
        base.tipe = "Predator";
        base.vga = vga;
        base.processor = processor;
    }

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {this.merk} {this.tipe} sedang memainkan game");
    }
}

class Lenovo : Laptop
{
    public Lenovo()
    {
        base.merk = "Lenovo";
    }
}

class IdeaPad : Lenovo
{
    public IdeaPad(Vga vga, Processor processor)
    {
        base.tipe = "IdeaPad";
        base.vga = vga;
        base.processor = processor;
    }
}

class Legion : Lenovo
{
    public Legion()
    {
        base.tipe = "Legion";
    }
}



//Processor
class Processor
{
    public string merk;
    public string tipe;
}

class Intel : Processor 
{
    public Intel()
    {
        base.merk = "Intel";
    }
}

class CoreI3 : Intel
{
    public CoreI3()
    {
        base.tipe = "Core i3";
    }
}
class CoreI5 : Intel
{
    public CoreI5()
    {
        base.tipe = "Core i5";
    }
}

class CoreI7 : Intel
{
    public CoreI7()
    {
        base.tipe = "Core i7";
    }
}

class AMD : Processor
{
    public AMD()
    {
        base.merk = "AMD";
    }
}

class Ryzen : AMD
{
    public Ryzen()
    {
        base.tipe = "Ryzen";
    }
}

class Athlon : AMD
{
    public Athlon()
    {
        base.tipe = "Athlon";
    }
}




//Vga
class Vga
{
    public string merk;
}

class Nvidia : Vga
{
    public Nvidia()
    {
        base.merk = "Nvidia";
    }
}

class amd : Vga
{
    public amd()
    {
        base.merk = "AMD";
    }
}


