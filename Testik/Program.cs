using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testik
{
    class Program
    {
        static void Main(string[] args)
        {
            int PC = 60;
            int lvl;


            {
                do
                {
                    Console.WriteLine("Сколько тебе лет?");
                    lvl = Convert.ToInt32(Console.ReadLine());

                    if (lvl < 60)
                    {
                        int sum = PC - lvl;
                        Console.WriteLine("Я старше тебя на {0} лет", sum);

                    }

                    else if (lvl == PC)
                    {
                        Console.WriteLine("Мы одногодки");

                    }

                  else if (lvl > 120)
                    {
                        Console.WriteLine("Не может быть");

                    }

    
                    else
                    {

                        int sum = lvl - PC;
                        Console.WriteLine("Я моложе тебя на {0} лет", sum);

                    }
                }
                while (lvl > 150);
                Console.WriteLine("Ты пиздабол!");
                Console.ReadKey();
                { }
            }
        }
    }
}