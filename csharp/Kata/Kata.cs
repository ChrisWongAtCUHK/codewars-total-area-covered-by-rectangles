namespace Kata;

public class Kata
{
  public static long Calculate(IEnumerable<int[]> rectangles)
  {
    // your code here...
    if (rectangles.Count() == 0) return 0;
    long area = 0;
    foreach (var rectangle in rectangles)
    {
      area += (long)(rectangle[2] - rectangle[0]) * (long)(rectangle[3] - rectangle[1]);
    }
    return area;
  }
}
