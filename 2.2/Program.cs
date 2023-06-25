using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Кардаш Михаил Андреевич";
            int age = 29;
            string email = "mixan193@gmail.com";
            double mathScores = 5;
            double phisicsScores = 4;
            double programmingScores = 4;
            double GPA = (mathScores + phisicsScores + programmingScores) / 3;
            Console.WriteLine($"Студент {fullName} возрастом {age} лет, \nemail: {email} \nполучил следующие отметки:\nМатематика: {mathScores}\nФизика: {phisicsScores}\nПрограммирование: {programmingScores}\nсредний балл {GPA.ToString("#.##")}");
            Console.ReadKey();
        }
    }
}
