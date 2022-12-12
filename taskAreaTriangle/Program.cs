// Задача площадь треугольника. По целочисленным координатам вершин треугольника
// (x1,y1),(x2,y2),(x3,y3) требуется вычислить его площадь
Console.Clear();
string[] numbers = Console.ReadLine().Split(" ");
System.Double x1 = int.Parse(numbers[0]);
System.Double y1 = int.Parse(numbers[1]);
System.Double x2 = int.Parse(numbers[2]);
System.Double y2 = int.Parse(numbers[3]);
System.Double x3 = int.Parse(numbers[4]);
System.Double y3 = int.Parse(numbers[5]);
System.Double A = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));// сторона А треугольника
System.Double B = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));// сторона B
System.Double C = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));// сторона С
System.Double p = (A + B + C) / 2;
Console.WriteLine(Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), 2));