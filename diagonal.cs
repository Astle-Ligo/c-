using System;
public class diagonal{
    public static void Main(string[] args){
        int l, b;
        double d;
        Console.WriteLine("Enter The Length and Breadth of the Rectangle : ");
        l = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        d = Math.Sqrt(Math.Pow(l,2)+Math.Pow(b,2));
        Console.WriteLine("Diagonal of the Rectangle : "+d);
    }
}