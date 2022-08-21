// Задача 42: Напишите программу, которая будет преобразовывать десятичное число
//  в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.WriteLine("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int res = 0;

// while (A > 0)
// {
//     res = A % 2;
//     A = A / 2;
//     Console.Write(res);
// }


Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
GetBinaryView(N);

void GetBinaryView(int number)
{
    if (number <= 0) return;
    GetBinaryView(number / 2);
    Console.Write(number % 2);
}
