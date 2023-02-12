//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите перове число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numC = Convert.ToInt32(Console.ReadLine());
int max = numA;
if (numB > max)
{
    numB = max;
}
if (numC > max)
{
    numC = max;
}
Console.WriteLine("Наибольшее значение " + max);
