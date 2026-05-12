namespace Kata;

public class Kata
{
  public static long Calculate(IEnumerable<int[]> rectangles)
  {
    // your code here...
    if (rectangles.Count() == 0) return 0;
    long area = 0;
    List<int[]> rs = new List<int[]>();
    foreach (var rectangle in rectangles)
    {
      area += (long)(rectangle[2] - rectangle[0]) * (long)(rectangle[3] - rectangle[1]);
      foreach (var r in rs)
      {
        int xOverlap = Math.Max(0, Math.Min(rectangle[2], r[2]) - Math.Max(rectangle[0], r[0]));
        int yOverlap = Math.Max(0, Math.Min(rectangle[3], r[3]) - Math.Max(rectangle[1], r[1]));
        area -= (long)xOverlap * (long)yOverlap;
      }
      rs.Add(rectangle);
    }
    return area;
  }
}
