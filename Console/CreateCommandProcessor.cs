using System;
using VS.Core;
namespace Console
{
    class CreateCommandProcessor : CommandProcessor
    {
        public override void Process()
        {
            System.Console.Write("name: ");
            var name = System.Console.ReadLine();
            System.Console.Write("star: ");
            var star = System.Console.ReadLine();
            System.Console.Write("IsCountry Y/N: ");
            var IsCountry = System.Console.ReadLine();
            bool isCountry = false;
            if (IsCountry=="Y")
            {
                isCountry = true;
            }
            Program.Logics.Create(new Team { Name = name, Star = Convert.ToDouble(star), Form = 3,IsCountry=isCountry });
        }
    }
}