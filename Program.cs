// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
int NaturalDegree(int a, int b)
{
    int result = 1;

    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    return result;

}

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int naturalDegree = NaturalDegree(a, b);
Console.WriteLine("Ответ: "+ naturalDegree);

*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
int SumNumbers (int numbers)
{
    int counter = Convert.ToString(numbers).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = numbers - numbers % 10;
        result = result + (numbers - advance);
        numbers = numbers / 10;
    }
    return result;
    
}
Console.Write("Введите число: ");
int numbers = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(numbers);
Console.WriteLine($"Сумма цифр в числе - {numbers}. Это {sumNumbers}.");
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/*
int [] numbers = new int[8];

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 100);
    Console.Write(" " + Method (i) + " ");
 }


int Method (int a)
{
    return numbers[a];
}
Console.WriteLine();

*/