// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите число: ");
int count = int.Parse(Console.ReadLine());
if (count > 0 && count < 6)
{
    Console.WriteLine("Число "+count+" соотвествует буднему дню недели");
}
else if ( count > 5 && count < 8)
{
    Console.WriteLine("Число "+count+" соотвествует выходному дню недели");
}
else
{
    Console.WriteLine("Число "+count+" не соотвествует не одному дню недели");
}