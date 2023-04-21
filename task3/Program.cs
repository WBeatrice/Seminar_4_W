/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int PrintNumber(int number)
{
    System.Console.Write($"Enter the number {number}: ");
    int n = int.Parse(Console.ReadLine());
    return n;
}

int[] array = new int[8];

int number = 0;

for (int i = 0; i < array.Length; i++)
{
    number = PrintNumber(i+1);
    array[i] = number;
}
System.Console.WriteLine();
System.Console.Write("[");
System.Console.Write(String.Join(",", array));
System.Console.Write("]");
