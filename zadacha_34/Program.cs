// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//1. задать массив
//2. определить четные числа
//3. вывести колличество четных чисел

Console.Clear();

//1.
const int SIZE = 4;
const int LEFT_RANGE = 100;
const int RIGHT_RANGE = 999;
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
System.Console.WriteLine('[' + string.Join(", ", array) + ']');

//2.
int sumEven = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        sumEven = sumEven + 1;
    }
}

//3.
System.Console.WriteLine("-> " + sumEven);
