using System;

public class matrixMultiplication
{
    public static void Main(String[] args)
    {
        int i, j, k, r1, c1, r2, c2;
        Console.WriteLine("Enter the rows and column of 1st matrix");
        r1 = int.Parse(Console.ReadLine());
        c1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the rows and column of 2nd matrix");
        r2 = int.Parse(Console.ReadLine());
        c2 = int.Parse(Console.ReadLine());
        if (c1 == r2)
        {
            int[,] m1 = new int[r1, c1];
            int[,] m2 = new int[r2, c2];
            int[,] m3 = new int[r1, c2];

            Console.WriteLine("Enter The First Matrix Elements :");
            for(i=0;i<r1;i++)
                for(j=0;j<c1;j++)
                    m1[i,j] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Second Matrix Elements :");
            for(i=0;i<r1;i++)
                for(j=0;j<c1;j++)
                    m2[i,j] = int.Parse(Console.ReadLine());

            for(i=0;i<r1;i++)
                for(j=0;j<c2;j++){
                    m3[i,j] = 0;
                    for(k=0;k<c1;k++)
                        m3[i,j] += m1[i,k]*m2[k,j];
                }
            Console.WriteLine("Resultant Matrix :");
            for(i=0;i<r1;i++){
                for(j=0;j<c1;j++)
                    Console.Write(m3[i,j] +"\t");
                Console.WriteLine();
            }
        }else{
            Console.WriteLine("Sorry!! Wrong Dimension!");
        }
    }
}