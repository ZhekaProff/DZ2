// Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Введите координаты точки А");
Console.Write("Xa = ");
int xa = int.Parse(Console.ReadLine());
Console.Write("Ya = ");
int ya = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
Console.Write("Xb = ");
int xb = int.Parse(Console.ReadLine());
Console.Write("Yb = ");
int yb = int.Parse(Console.ReadLine());

Console.WriteLine(Math.Sqrt((xb-xa)*2 + (yb-ya)*2)); // для 3D нужно просто добавить координаты Z и добавить в формулу ((zb - za) *2)