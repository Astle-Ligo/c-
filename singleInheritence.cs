using System;
public class laptop
{
    public const string Name = "Acer Aspire 5";
    public const string Proc = "Intel Core i5";
    public const int Ram = 8;
    public const int HD = 512;
    public const int Price = 50000;
    public void print()
    {
        Console.WriteLine("Name :{0}\nProcessor : {1}\nRAM : {2}\nHard Drive : {3}\nPrice : {4}", Name, Proc, Ram, HD, Price);
    }
}

public class gaming:laptop
{
    public const string Name = "ASUS TUF";
    public const string Proc = "Intel Core i7";
    public const int Ram = 16;
    public const int HD = 1024;
    public const int Price = 100000;
    public void print()
    {
        Console.WriteLine("Name :{0}\nProcessor : {1}\nRAM : {2}\nHard Drive : {3}\nPrice : {4}", Name, Proc, Ram, HD, Price);
    }
}
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("BASIC LAPTOP");
        laptop basic = new laptop();
        basic.print();

        Console.WriteLine("GAMING LAPTOP");
        gaminglaptop gaming = new gaminglaptop();
        gaming.print();
    }
}