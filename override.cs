using System;
public class overRide{
    public void display(int a){
        Console.WriteLine("a : "+a);
    }
    public void display(char c){
        Console.WriteLine("c : "+c);
    }
    public void display(int a,char c){
        Console.Write("a : "+a);
        Console.WriteLine("c : "+c);
    }
    public void display(char c,int a){
        Console.Write("c : "+c);
        Console.WriteLine("a : "+a);
    }
    public static void Main(string[] args){
        overRide obj = new overRide();
        obj.display(10);
        obj.display('c');
        obj.display(10,'c');
        obj.display('c',10);
    }
}