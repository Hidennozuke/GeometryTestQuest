namespace GeometryLibrary
{
    public class Circle : AllFiguresInterface
    {
        public const double MinRadius = 0.000001;
        public double Radius { get; }

        /// <exception cref="ArgumentException"></exception>
        public Circle(double radius)
        {
            if (radius < MinRadius)
                throw new ArgumentException("Слишком маленькое значение, укажите большее число", nameof(radius));
            Radius = radius;
        }

        public double Square()
        {
             return Math.PI * Math.Pow(Radius, 2);
        }
    }
}