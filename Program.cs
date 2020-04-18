using System;

namespace SOLID.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("S (Single Responsible Principle):");
            SRP.Starter.Run();

            Console.WriteLine();
            Console.WriteLine("O (Open-Closed Principle):");
            OCP.Starter.Run();

            Console.WriteLine();
            Console.WriteLine("L (Liskov Substitution Principle):");
            LSP.Starter.Run();

            Console.WriteLine();
            Console.WriteLine("I (Interface Segregation Principle):");
            ISP.Starter.Run();

            Console.WriteLine();
            Console.WriteLine("D (Dependency Inversion Principle):");
            DIP.Starter.Run();
        }
    }
}
