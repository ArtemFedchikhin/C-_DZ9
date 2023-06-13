// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int SumNaturalNumber(int M, int N)
{
    if(M == N)
        return M;
    return SumNaturalNumber(M, N - 1) + N; 
}
Console.Write("Введите 2 числа: ");
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.Write(SumNaturalNumber(numbers[0], numbers[1]));