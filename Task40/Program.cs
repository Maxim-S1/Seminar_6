// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
//  может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы 
// двух других сторон.

// Console.WriteLine("Введите первое число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число: ");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число: ");
// int C = Convert.ToInt32(Console.ReadLine());


//     if (A < B + C && B < A + C && C < A + B)
//     {
//         Console.WriteLine("Треугольник с такими сторонами существует");
//     }
//     else
//     {
//         Console.WriteLine("Треугольник с такими сторонами не существует");
//     }



Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int C = Convert.ToInt32(Console.ReadLine());


bool res = IsTriangleExist(A, B, C);
if(res == true)// такой треугольник может существовать
{
    Console.WriteLine("Треугольник с такими сторонами существует");
}
else
{
    Console.WriteLine("Треугольник с такими сторонами не существует");
}

bool IsTriangleExist(int a, int b, int c)
{
    bool isExist = false; //такой треугольник не существует
    if (a < b + C && b < a + c && c < a + b)
    {
        isExist = true; // такой треугольник может существовать
    }
    return isExist;
    
}