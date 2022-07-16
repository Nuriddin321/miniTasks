public class Circle
{
    public Point Center {get; set; }
    public int Radius { get; set; }


    public Circle(Point center, int radius)
    {
        Center = center;
        Radius = radius;
    }

    public bool Contains(Point point) => Center.DistanceTo(point) <= Radius;
}