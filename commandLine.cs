using System;
class commandLine{
    const float PI = 3.14f;
    static int x = 100;
    int y;
    readonly int z;

    public void prog1(int a,int b){
        y = a;
        z = b;
        x++;
    }

    static void main(string[] args){
        Console.WriteLine("X value : {0}",x);
        Console.WriteLine("PI value : {0}",PI);

        commandLine obj1 = new commandLine(int.Parse(args[0]),int.Parse(args[1]));
        commandLine obj2 = new commandLine(int.Parse(args[2]),int.Parse(args[3]));

        
        Console.WriteLine("X value : {0}",x);
        Console.WriteLine("OBJ Y value : {0} \nRead Only Z value : {1}",obj1.y,obj2.y);
    }
}