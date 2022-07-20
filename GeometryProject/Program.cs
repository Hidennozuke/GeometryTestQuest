using GeometryLibrary;

Console.WriteLine("Простая геометрия");
//Идеальные значения
//double a = 6;
//double b = 8;
//double c = 10;
//double radius = 10;

#region Пример исполнения треугольника

try
{
    Console.WriteLine($"Введите три значения строн для треугольника");
    double a = Convert.ToDouble(Console.ReadLine());
    double b = Convert.ToDouble(Console.ReadLine());
    double c = Convert.ToDouble(Console.ReadLine());
    Triangle triangle = new Triangle(a, b, c);

    string isRight = triangle.IsRightTriangle ? "Треугольник прямоугольный" : "Треугольник не прямоугольный";

    Console.WriteLine($"{triangle.Square()}, {isRight} \n");
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.Message} \n");
}

#endregion _Пример исполнения треугольника

#region Пример исполнения круга

try
{
    Console.WriteLine($"Введите радиус окружности");
    double radius = Convert.ToDouble(Console.ReadLine());
    Circle circle = new Circle(radius);
    Console.WriteLine($"Площадь круга равна: {circle.Square()} \n");
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.Message} \n");
}

#endregion _Пример исполнения круга

Console.ReadLine();