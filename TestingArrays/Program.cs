const int ARRAY_SIZE = 6;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;

int[] array = FillArrayWithRandomNumbers(ARRAY_SIZE, LEFT_RANGE, RIGHT_RANGE);
int[] copyArray = array;

array[0] = 100;
Console.WriteLine($"Исходный массив: {string.Join(", ", array)}");
Console.WriteLine($"Скопированный массив: {string.Join(", ", copyArray)}");

//метод возвращает массив на size элементов
int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];

    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(leftRange, rightRange + 1);
    }

    return array;
}

