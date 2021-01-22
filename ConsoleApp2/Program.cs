#region Naumov

#endregion
#region а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
//б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Question("x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Question("y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Question("x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Question("y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Расстояние между точками: { Distance(x1, x2, y1, y2):f2} единиц");
            Console.ReadKey();
        }
        static void Question(string x)
        {
            Console.WriteLine($"Введите {x}");
        }
        static double Distance(int x1, int x2, int y1, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
