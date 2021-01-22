#region Naumov

#endregion
#region Написать программу обмена значениями двух переменных:
//а) с использованием третьей переменной;
//б) *без использования третьей переменной.
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            int b = Convert.ToInt32(Console.ReadLine());
            a += b;
            b = a - b;
            a -= b;
            Console.WriteLine($"a={a}, b={b}");
            Console.ReadKey();
        }
    }
}
