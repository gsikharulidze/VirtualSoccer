using System;
namespace Console
{
    class ListCommandProcessor : CommandProcessor
    {
        public override void Process()
        {
            System.Console.WriteLine("\nid\tname");
            System.Console.WriteLine("================");
            foreach (var task in Program.Logics.List())
            {
                System.Console.WriteLine(task);
            }
            System.Console.WriteLine();
        }
    }
}