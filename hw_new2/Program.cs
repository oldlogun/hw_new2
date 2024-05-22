using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_new2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("В какой сфере деятельности работаете: ");
            string profeccionalArea = Console.ReadLine();
            Console.Write("Сколько времени уделяете времени программированию: ");
            int studyTime = Convert.ToInt32(Console.ReadLine());
            Console.Write("Желаемая зароботная плата: ");
            long futureSalary = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine($"Ваше имя {name}, вы заняты в/на - {profeccionalArea}. Учитесь {studyTime} часов и хотите запрлату {futureSalary} тугриков.");
        }
    }
}