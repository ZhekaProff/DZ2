// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите первое число: ");
int count = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int count2 = int.Parse(Console.ReadLine());
if ( count == count2/2)
{
    Console.WriteLine("Второе число "+count2+" я вляется квадратом первого числа "+count+" ");
}
else if ( count2 == count /2)
{
    Console.WriteLine("Первое число "+count+" я вляется квадратом второго числа "+count2+" ");
}
else
{
    Console.WriteLine("Числа не являются квадратом друг друга!");
}