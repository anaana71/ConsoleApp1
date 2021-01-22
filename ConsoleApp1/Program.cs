#region Naumov

#endregion
#region Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
//а) используя склеивание;
//б) используя форматированный вывод;
//в) используя вывод со знаком $.
#endregion
#region Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] questions = new string[,] { { "Как вас зовут?", "Сколько вам лет?", "Какой у вас рост?", "Какой у вас вес?" }, { "Имя:", "Возраст:", "Рост:", "Вес:" } };
            string[] answers = new string[questions.GetUpperBound(1)+1];
            for(int i = 0; i < questions.GetUpperBound(1)+1; i++)
            {
                Console.WriteLine(questions[0,i]);
                answers[i] = Console.ReadLine();                
            }
            for (int i = 0; i < answers.Length; i++)
            {
                Console.Write(questions[1,i] + answers[i]);
            }
            Console.ReadKey();
            for (int i = 0; i < answers.Length; i++)
            {
                Console.Write($"\n{questions[1, i] + answers[i]}");
            }
            //Часть 2
            var weight = Convert.ToInt32(answers[3]);
            var height = Convert.ToDouble(answers[2])/100;
            var index = Convert.ToDouble(weight / (height * height));
            Console.WriteLine($"\nИндекс массы тела: {index:f2}");
            Console.ReadKey();
        }        
    }
}
