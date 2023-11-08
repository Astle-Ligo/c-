using System;
public class swap{
    public static void swapNum(ref int x,ref int y){
        int temp = x;
        x = y;
        y = temp;
    }
    public static void Main(string[] args){
        int a = 25;
        int b = 90;

        Console.WriteLine("Variable Before Swap");
        Console.WriteLine("a : {0} \tb : {1}",a,b);
        swapNum(ref a,ref b);
        Console.WriteLine("Variable After Swap");
        Console.WriteLine("a : {0} \tb : {1}",a,b);
    }
}