Console.WriteLine("Введите значение х: ");
double x = double.Parse(Console.ReadLine());
double y = (2 * Math.Cos(1/(x*x + 2)))/((Math.Pow(x,3)) + 1);
Console.WriteLine(y);