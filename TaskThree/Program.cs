using System;

namespace TaskThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число, и программа определит четное оно или нет");
            string strNumber = Console.ReadLine();
            int number = int.Parse(strNumber);
            if (number % 2 == 0)
            {
                Console.WriteLine("Число {0} четное", number);
            } else
            {
                Console.WriteLine("Число {0} нечетное", number);
            }
            Console.ReadKey();
        }
    }
}
