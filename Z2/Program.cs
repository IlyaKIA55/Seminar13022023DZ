// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите ввод");
        }
    }

    return result;
}
double numberB1 = GetNumber("Введите число b1: ");
double numberK1 = GetNumber("Введите число k1: ");
double numberB2 = GetNumber("Введите число b2: ");
double numberK2 = GetNumber("Введите число k2: ");

double x = -(numberB1 - numberB2) / (numberK1 - numberK2);
double y = numberK1 * x + numberB1;
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");