using System;

public class boxUnbox{
    public static void Main(String[] args){
        int m = 10;
        object a = m;
        try{
            
            Console.WriteLine("Value of m is : {0}",a);
            object n = 25;
            int b = (int)n;
            Console.WriteLine("Value of n is : {0}",b);
        }catch(InvalidCastException e){
            Console.WriteLine("Incorrect Unboxing "+e);
        }
    }
}