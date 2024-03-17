using Reference01;
using System;

namespace MsBuild_Multitarget_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Program target framework is {typeof(Program).Assembly.GenerateInformation()}");
            Console.ReadKey();
        }
    }
}
