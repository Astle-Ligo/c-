using System;
class access{
    public int publicVar = 10;
    // protected int protectedVar = 20;
    // private int privateVar = 30;
    internal int internalVar = 40;
    protected internal int protectedInternalVar = 50;
}

class program{
    static void Main(String[] args){
        access obj = new access();
        Console.WriteLine("Public Variable : "+obj.publicVar);
        Console.WriteLine("Internal Variable : "+obj.internalVar);
        Console.WriteLine("Protected Internal Variable : "+obj.protectedInternalVar);
    }
}