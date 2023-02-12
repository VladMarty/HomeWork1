int i = 1;
bool not = true;
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.WriteLine("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Четные число от 1 до " + num);
while (i <= num)
{
    if(i % 2 != 1)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;  
}
if (not)
{
    Console.WriteLine("Нет четных чисел!");
}

