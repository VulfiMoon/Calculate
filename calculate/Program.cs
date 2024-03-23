using System;

class Calculator
{
    static void Main(string[] args)
    {
        double num1, num2, result;
        char operation;

        Console.WriteLine("Калькулятор на c#");
        Console.WriteLine("Ведите первое число:");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ведите второе число:");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ведите операцию(+,-,/,*):");
        operation = Convert.ToChar(Console.ReadLine());

        switch(operation) 
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine("Результат:" +  result);
                break;
            case '-':
                result = num1 - num2;
                Console.WriteLine("Результат:" + result);
                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine("Рзультат:" + result);
                break;
            case '/':
                result = num1 / num2;
                Console.WriteLine("Результат" + result);
                break;
            default: Console.WriteLine("Ошибка ввода");
                break;

        }

        Console.WriteLine("Для выхода нажмите любую клавишу. Для продолжения - Enter.");
        if (Console.ReadKey().Key != ConsoleKey.Enter)
            return;
        Console.Clear();


    }
}