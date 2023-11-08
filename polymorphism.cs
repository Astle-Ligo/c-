using System;
public class baseClass{
    public void method1(){
        Console.WriteLine("Base Class - Method 1");
        method2();
    }

    public void method2(){
        Console.WriteLine("Base Class - Method 2");
    }
}
public class derived:baseClass{
    public override void method2(){
        Console.WriteLine("Derived Method 2");
    }
}
public class program{
    static void Main(string[] args){
        baseClass obj = new baseClass();
        obj.method1();
        derived obj1 = new derived();
        obj1.method1();
    }
}