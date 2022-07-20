namespace GeometryLibrary
{
    public class Triangle : TriangleInterface
    {
        private double minLenght = 0.0000001;
        public double EdgeA { get; }
        public double EdgeB { get; }
        public double EdgeC { get; }
        public bool IsRightTriangle => _isRightTriangle.Value;

        public readonly Lazy<bool> _isRightTriangle;

        /// <exception cref="ArgumentException"></exception>
        public Triangle(double edgeA, double edgeB, double edgeC)
        {
            if (edgeA < minLenght)
                throw new ArgumentException("Неверно указана сторона.", nameof(edgeA));

            if (edgeB < minLenght)
                throw new ArgumentException("Неверно указана сторона.", nameof(edgeB));

            if (edgeC < minLenght)
                throw new ArgumentException("Неверно указана сторона.", nameof(edgeC));

            var maxEdge = Math.Max(edgeA, Math.Max(edgeB, edgeC));
            var perimeter = edgeA + edgeB + edgeC;
            if ((perimeter - maxEdge) - maxEdge < minLenght)
                throw new ArgumentException("Наибольшая сторона треугольника должна быть меньше суммы других сторон");

            EdgeA = edgeA;
            EdgeB = edgeB;
            EdgeC = edgeC;

            _isRightTriangle = new Lazy<bool>(GetIsRightTriangle);
        }

        public double PerimeterHalf()
        {
            return ((EdgeA + EdgeB + EdgeC) / 2);
        }

        public bool GetIsRightTriangle()
        {
            //Периметр прямоугольного треугольника равен сумме двух радиусов вписанной и четырёх описанных окружностей
            double perimeter = EdgeA + EdgeB + EdgeC;
            double radiusOut = (EdgeA * EdgeB * EdgeC) / (4 * Square());
            double radiusIn = Square() / PerimeterHalf();

            return (perimeter == radiusIn * 2 + radiusOut * 4);
        }

        public double Square()
        {
            return Math.Sqrt(PerimeterHalf() * (PerimeterHalf() - EdgeA) * (PerimeterHalf() - EdgeB) * (PerimeterHalf() - EdgeC));
        }
    }
}