int[] array = new int[4] { 1, 2, 3, 4 };
//string[] array1 = new string[] { "A", "B", "C" };
//System.Console.Write($"Введите число : {array[2]}");
//array[2] = array[2] * 2;
//System.Console.WriteLine($"{array[2]}");

for (int i = 0; i < array.Length; i++)
{
    array[i] *= 2;
    System.Console.WriteLine($"{array[i]}");
}

System.Console.WriteLine("Введите координаты X : ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты Y : ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0)
{
    System.Console.WriteLine("Eror");
}
else if (x > 0 && y > 0)
{
    System.Console.WriteLine("Точка находится в первой четверти");
}
else if (x < 0 && y > 0)
{
    System.Console.WriteLine("Точка находится во второй четверти");
}
else if (x < 0 && y < 0)
{
    System.Console.WriteLine("Точка находится в третьей четверти");
}
else if (x > 0 && y < 0)
{
    System.Console.WriteLine("Точка находится в четвертой четверти");
}

System.Console.WriteLine("Введите номер четверти : ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
{
    System.Console.WriteLine("Диапазон координат х > 0 ; y > 0 ");
}
else if (num == 2)
{
    System.Console.WriteLine("Диапазон координат х < 0 ; y > 0 ");
}
else if (num == 3)
{
    System.Console.WriteLine("Диапазон координат х < 0 ; y < 0 ");
}
else if (num == 4)
{
    System.Console.WriteLine("Диапазон координат х < 0 ; y < 0 ");
}
else
{
    System.Console.WriteLine("Eror");
}


System.Console.WriteLine("Введите координату Х для первой точки :");
int xa = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату У для первой точки :");
int ya = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Х для второй точки :");
int xb = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату У для второй точки :");
int yb = Convert.ToInt32(Console.ReadLine());


double l = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya));
System.Console.WriteLine($"Расстояние между точками : {Math.Round(l, 2)} ");


System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
int number = 1;
while (count <= N)
{
    number = count * count;
    System.Console.WriteLine(number);
    count++;
}




