// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

const int SIZE = 5;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 100;
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

int sum = array.Max() - array.Min();
System.Console.WriteLine('[' + string.Join(", ", array) + ']' + " -> " + sum);





