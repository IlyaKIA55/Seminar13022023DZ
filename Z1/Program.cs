// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через запятую");
string[] strArray = Console.ReadLine().Split(',');

int[] result = new int[strArray.Length];
int count = 0;

for (int i = 0; i < result.Length; i++)
{
    result[i] = int.Parse(strArray[i]);
    if (result[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество положительных элементов {count}");
