using System;
namespace calender{
    class program{
        public static void Main(string[] args){

            int i,j,k,l,c=0;

            int[][] year = new int[12][];

            year[0] = new int[31];
            year[1] = new int[28];
            year[2] = new int[31];
            year[3] = new int[30];
            year[4] = new int[31];
            year[5] = new int[30];
            year[6] = new int[31];
            year[7] = new int[31];
            year[8] = new int[30];
            year[9] = new int[31];
            year[10] = new int[30];
            year[11] = new int[31];

            string[] month = new string[]{"January","Febuary","March","April","May","June","July","August","September","October","November","December"};

            string[] days = new string[]{"Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"};

            for(i=0;i<year.Length;i++)
                for(j=0;j<year[i].Length;j++)
                    year[i][j] = j+1;

            for(i=0;i<year.Length;i++){
                Console.WriteLine("\t"+month[i]);
                for(j=0;j<days.Length;j++)
                    Console.Write(days[j]+"\t");
                Console.WriteLine();
                for(k=0;k<c;k++)
                    Console.Write("\t");
                for(l=0;l<year[i].Length;l++){
                    Console.Write(year[i][l]+"\t");
                    c=(l+1)%7;
                    if(c==0)
                        Console.WriteLine("\n");
                }
            }
        }
    }
}