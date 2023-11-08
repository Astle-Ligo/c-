using System;
using System.Threading;
class program{
    static void table(int n){
        for(int i = 1;i<=10;i++){
            Console.WriteLine("{0} * {1} = {2}",n,i,n*i);
            Thread.Sleep(100);
        }
    }
    static void Main(string[] args){
        Thread thread5 = new Thread(table(5));
        Thread thread7 = new Thread(table(7));
        Thread thread13 = new Thread(table(13));

        thread5.start();
        thread7.start();
        thread13.start();
        thread5.join();
        thread7.join();
        thread13.join();
    }
}