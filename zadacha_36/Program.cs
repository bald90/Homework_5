// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

//1. задать массив
//2. найти нечетные позиции
//3. найти сумму чисел


Console.Clear();

const int SIZE = 4;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 20;
int[] array = new int[SIZE];  //создали массив

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();             //создали объект класса рандом
    int[] arr = new int[size];              // объявили массив

    for (int i = 0; i < arr.Length; i++)        // заполнили циклом
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);              // всегда + 1 тк правая граница не включается
    }
    return arr;
}

array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
//System.Console.WriteLine('[' + string.Join(", ", array) + ']');

//вариант с методом
int sum = 0;
int FindSumOdd(int sum)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }

    }
    return sum;
}
int sumOdd = FindSumOdd(sum);

System.Console.WriteLine('[' + string.Join(", ", array) + ']' + " -> " + sumOdd);

//вариант без метода
// int sumOdd = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (i % 2 != 0)
//     {
//         sumOdd = sumOdd + array[i];
//         //System.Console.Write(string.Join(", ", array[i]) + ' ');        //вывод чисел с нечетных позиций

//     }
// }
//  System.Console.Write(sumOdd); 