using System;
class program{
    static void Main(){
        int[] arr = {1,2,3,4};
        try{
            int value = arr[10];
        }catch(IndexOutOfRangeException e){
            Console.WriteLine("Exception "+e);
        }

        try{
            object[] obj = {"String",123,true};
            string val = (string)obj[1];
        }catch(InvalidCastException e){
            Console.WriteLine("Exception "+e);
        }

        // try{
        //     Recursive();
        // }catch(StackOverflowException e){
        //     Console.WriteLine("Exception "+e);
        // }

        int num = 10;
        int den = 0;
        try{
            int result = num/den;
        }catch(DivideByZeroException e){
            Console.WriteLine("Exception "+e);
        }
    }

    static void Recursive(){
        Recursive();
    }
}