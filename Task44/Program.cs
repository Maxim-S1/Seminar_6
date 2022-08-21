// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


Console.WriteLine("Введите число N обозначающее количество вывода чисел Фибоначчи: ");
int N = Convert.ToInt32(Console.ReadLine());
int res = 0;
int n1 = 0;
int n2 = 1;

Console.Write($"{n1} {n2} ");
for (int i = 0; i < N - 2; i++)
{
    res = n1 + n2;
    n1 = n2;
    n2 = res;
    Console.Write($"{res} ");
}
