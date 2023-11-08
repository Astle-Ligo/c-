using System;
class incomeTax
{
    static void Main(String[] args)
    {

        int age;
        char gender;
        double income;

        Console.WriteLine("Enter Your Age : ");
        age = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Your Gender (M/F) :");
        gender = Console.ReadLine()[0];

        Console.WriteLine("Enter Your Income :");
        income = double.Parse(Console.ReadLine());

        if(age>=65||gender=='F')
            Console.WriteLine("Wrong Category");
        else{
            Console.Write("TAX : ");
            if(income <=160000)
                Console.Write("0.00");
            else if(income <=500000)
                Console.Write((income-160000)*0.1);
            else if(income <= 800000)
                Console.Write((income-500000)*0.2 + 34000);
            else
                Console.Write((income-800000)*0.3+94000);
        }

    }
}