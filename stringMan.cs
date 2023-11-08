using System;
class stringMan{
    static void main(){
        string ogString = "C#";
        string upString = "Programming";

        string result = string.Empty;
        var stopwatch = new stopwatch();
        stopwatch.start();

        for(int i = 0;i<100000;i++)
            result = ogString+upString;
        stopwatch.stop();
        Console.WriteLine("Result : "+result);
        Console.WriteLine("Time Taken : "+stopwatch.ElapsedMillSecond+" ms.");
    }
}