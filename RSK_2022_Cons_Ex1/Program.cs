using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSK_2022_Cons_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            var txt = SayHello(name);

            Console.WriteLine(txt);

            Console.ReadKey();
        }

        private static string SayHello(string name)
        {
            return $"Hello, {name}!!!";
        }

        private static string SayHello111(string name)
        {
            return $"Hello, {name}!!!";
        }
    }
}
