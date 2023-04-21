/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int PrintNumber(string number)
{
    System.Console.Write($"Enter the {number}: ");
    int n = int.Parse(Console.ReadLine());
    return n;
}

int a = PrintNumber("A");
int b = PrintNumber("B");
int power = 1;

for (int i = 1; i <= b; i++)
{

    power *= a;

}
Console.WriteLine($"Number {a} to the power of {b} = {power}");