namespace Kata;

public class Kata
{
  public static long Calculate(IEnumerable<int[]> rectangles)
  {
    if (rectangles.Count() == 0) return 0;
    long area = 0;
    var xs = rectangles.SelectMany(r => new[] { r[0], r[2] }).OrderBy(x => x).Distinct().ToArray();
    var ys = rectangles.SelectMany(r => new[] { r[1], r[3] }).OrderBy(y => y).Distinct().ToArray();

    for (int i = 0; i < xs.Length - 1; i++)
    {
      for (int j = 0; j < ys.Length - 1; j++)
      {
        // 只要有一個矩形包含這個小方格，就計入面積
        if (rectangles.Any(r => r[0] <= xs[i] && r[2] >= xs[i + 1] && r[1] <= ys[j] && r[3] >= ys[j + 1]))
        {
          area += (long)(xs[i + 1] - xs[i]) * (ys[j + 1] - ys[j]);
        }
      }
    }

    return area;
  }
}
