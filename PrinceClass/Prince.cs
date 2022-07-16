public class Prince
{
    public Point Start {get; set; }
    public Point End { get; set; }

  public Prince (Point start, Point end)
  {
    Start = start;
    End = end;
  }

  public int CrossingCount (Circle[] planet)
  =>planet.Count(p => Crosses(p));

  private bool Crosses(Circle planet)
  => planet.Contains(Start) ^ planet.Contains(End);
}