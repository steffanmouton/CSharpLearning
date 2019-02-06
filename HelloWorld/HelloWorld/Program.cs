using System;

namespace HelloWorld
{
    internal class Program
    {
        public static void Main(string[] args)
        {
         var hello = new MyPrintingObject();
         hello.Print(hello.sayHi);
         var hi = new MyPrintingStruct();
         hi.Print("Hello World!");
         Console.ReadLine();
        }
    }
    
    class MyPrintingObject
    {
        public string sayHi = "Hello World!";
        public void Print(string s)
        {
            System.Console.WriteLine(s);
        }
    }

    struct MyPrintingStruct
    {
        public void Print(string s)
        {
            System.Console.WriteLine(s);
        }
    }
}