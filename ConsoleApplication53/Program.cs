using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication29
{
    class Program
    {
        static void Try(out double inputnumber)//проверка правильности ввода числа
        {
            inputnumber = 0;
            bool flag = true;
            while (flag == true)
            {
                try
                {
                    string x = Console.ReadLine();
                    inputnumber = double.Parse(x);
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("Неверное значение! Введите число");
                    flag = true;
                }
            }
        }

        static void Main(string[] args)
        {
            string answer = "yes";

            while (answer == "yes")
            {
                Console.WriteLine("Введите координаты точки");
                Console.Write("X=");
                double x;
                Try(out x);
                Console.Write("Y=");
                double y;
                Try(out y);
                if (((x >= -1 && x <= 0) && (y <= -x && y >= -2)) || ((x >= 0 && x <= 1) && (y <= x && y >= -2)))
                {
                    Console.WriteLine("Точка принадлежит области");
                }
                else Console.WriteLine("Точка не принадлежит области");
                Console.WriteLine("Продолжить? Введите yes");
                answer = Console.ReadLine();
            }
        }
    }
}

