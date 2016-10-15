using System;
using System.IO;

namespace DelegateAppl
{
    class PrintString
    {

        // delegate declaration
        public delegate void printString(int x);

        // this method prints to the console
        public static void WriteToScreen(int x)
        {
            Console.WriteLine(2*x);
        }

        public static void WriteToFile(int x)
        {
            Console.WriteLine(5 * x);
        }

        // this method takes the delegate as parameter and uses it to
        // call the methods as required
        public static void sendString(printString ps, int x)
        {
            ps(x);
        }
        static void Main(string[] args)
        {
            printString ps1 = new printString(WriteToScreen);
            printString ps2 = new printString(WriteToFile);
            sendString(ps1, 1);
            sendString(ps2, 1);
            Console.ReadKey();
        }
    }
}
