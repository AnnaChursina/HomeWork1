using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, figure;
            try
            {
                Console.WriteLine("Введите возраст кошки не больше 20");
                age = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Кошки столько не живут, введите заново");
                return;
            }

            Cat cat1 = new Cat(age); //вызов конструктора
            while (true)
            {
                Console.WriteLine("Cat's age is " + cat1.Age);
                Console.WriteLine("Cat's name is " + cat1.Name);
                Console.WriteLine("Cat's color is " + cat1.CurrentColor);
                Console.WriteLine();
                Console.WriteLine("Menu");
                Console.WriteLine("0. Set name");
                Console.WriteLine("1. Change a color");
                Console.WriteLine("2. Punish");
                Console.WriteLine("3. Feed");
                Console.WriteLine();
                Console.WriteLine("Type a needed figure without dot and push Enter");
                figure = Convert.ToInt32(Console.ReadLine());
                if (figure == 0)
                {
                    try
                    {
                        Console.WriteLine("Type cat's name, please");
                        cat1.Name = Console.ReadLine();
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine(exc.Message);
                    }
                }
                else if (figure == 1)
                {
                    Console.WriteLine("Type a color of healthy cat");
                    cat1.CatColor.HealthyColor = Console.ReadLine();
                    Console.WriteLine("Type a color of sick cat");
                    cat1.CatColor.SickColor = Console.ReadLine();
                }
                else if (figure == 2)
                {
                    cat1.Punish();
                }
                else if (figure == 3)
                {
                    cat1.Feed();
                }

            }

        }
    }
}
