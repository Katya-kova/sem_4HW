// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] numbers = new int[8];
int length = numbers.Length;

Method (length);
void Method (int length)
{
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        numbers [i] = new Random().Next(1, 100);
        Console.Write(numbers [i] + ", ");
    }
    Console.Write(numbers [numbers.Length -1] +"]");
}
