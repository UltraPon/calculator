using System;

namespace calculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите операцию, которую вы хотите совершить: ");
        Console.WriteLine("1. Сложить числа");
        Console.WriteLine("2. Вычесть первое число из второго");
        Console.WriteLine("3. Перемножить числа");
        Console.WriteLine("4. Разделить первое число на второе");
        Console.WriteLine("5. Возвести первое число в степень N");
        Console.WriteLine("6. Найти квадратный корень из числа");
        Console.WriteLine("7. Найти 1 процент от числа");
        Console.WriteLine("8. Найти факториал числа");
        Console.WriteLine("9. Выход из программы");
        while (true) 
        {
            int operation = Convert.ToInt32(Console.ReadLine());
            if (operation == 1) 
            {
                Console.WriteLine("Введите первое число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a + b);
            }
            if (operation == 2) 
            {
                Console.WriteLine("Введите первое число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a - b);
            }
            if (operation == 3) 
            {
                Console.WriteLine("Введите первое число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a * b);
            }
            if (operation == 4) 
            {
                Console.WriteLine("Введите первое число: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                double b = Convert.ToDouble(Console.ReadLine());
                if (a == 0)
                    Console.WriteLine("Ошибка");
                else
                Console.WriteLine(a / b);
            }
            if (operation == 5) 
            {
                Console.WriteLine("Введите число: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите степень числа: ");
                double n = Convert.ToDouble(Console.ReadLine());
                a = Math.Pow(a, n);
                Console.WriteLine(a);
            }
            if (operation == 6) 
            {
                Console.WriteLine("Введите число: ");
                double a = Convert.ToDouble(Console.ReadLine());
                if (a<0)
                {
                    Console.WriteLine("Ошибка");
                }
                else
                {
                    a = Math.Sqrt(a);
                    Console.WriteLine(a);
                }
            }
            if (operation == 7) 
            {
                Console.WriteLine("Введите число: ");
                double a = Convert.ToDouble(Console.ReadLine());
                a = a * 1;
                a = a / 100;
                Console.WriteLine(a);
            }
            if (operation == 8) 
            {
                int a = 1;
                Console.WriteLine("Введите число: ");
                int b = Convert.ToInt32(Console.ReadLine());
                for (int i=1; i<=b; i++)
                {
                    a = a * i;
                }
                Console.WriteLine(a);
            }
            if (operation == 9) 
            {
                Environment.Exit(0);
            }
        }
    }
}