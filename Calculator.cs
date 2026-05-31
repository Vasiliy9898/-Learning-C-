using System;

namespace project
{

    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите число 1: ");
            float num1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите знак: ");
            string math = Console.ReadLine();
            Console.Write("Введите число 2: ");
            float num2 = Convert.ToSingle(Console.ReadLine());

            float result;
            switch (math)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine("Результат " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine("Результат " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine("Результат " + result);
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;

                            Console.WriteLine("Результат " + result);
                     
                    }
                    else
                    {
                        Console.WriteLine("Делить на ноль нельзя");

                    }

                    break;
            }
        }
    }
}
