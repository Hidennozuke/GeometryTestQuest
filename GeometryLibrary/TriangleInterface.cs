namespace GeometryLibrary
{
    internal interface TriangleInterface : AllFiguresInterface
    {
        double EdgeA { get; }
        double EdgeB { get; }
        double EdgeC { get; }
        bool IsRightTriangle { get; }
    }
}