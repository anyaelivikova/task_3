using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика_задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<< ЗАДАЧА 3 >>>");

            popadaetli();

            int answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            { Environment.Exit(0); }

            else
            {
                do
                {
                    switch (answer)
                    {
                        case 2:
                            popadaetli();
                            break;
                    }
                } while (answer > 0);
            }

        }
        static void popadaetli()
        {
             double x, y;
             bool ok;
            do
            {
                Console.WriteLine("Принадлежит ли точка области?");
                Console.Write("Введите координату точки, вещественное число x: ");
                string buf = Console.ReadLine();
                ok = double.TryParse(buf, out x);

            } while (!ok);
            do
            {
                Console.Write("Введите координату точки, вещественное число y: ");
                string buf = Console.ReadLine();
                ok = double.TryParse(buf, out y);

            } while (!ok);


            if ((x >= 0 && y >= 0) || (x <= 0 && y <= 0)) 
            {
                {
                    if (y <= -x + 1) { Console.WriteLine("Точка находится в нужной области"); }

                    else Console.WriteLine("Точка не находится в нужной области");
                }
            }

            else
            {
                if ((x >= 0 && y <= 0) || (x <= 0 && y >= 0)) 
                {
                    if (y >= x + 1) { Console.WriteLine("Точка находится в нужной области"); }
                    else Console.WriteLine("Точка не находится в нужной области");
                }
            }

            Console.WriteLine("1. Выйти 2. Повторить");
        }
    }
}
