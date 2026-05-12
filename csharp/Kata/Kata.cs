namespace Kata;

using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static long Calculate(IEnumerable<int[]> rectangles)
  {
    if (rectangles == null || !rectangles.Any()) return 0;

    // 1. 建立事件：將每個矩形拆成左邊界 (+1) 和右邊界 (-1)
    var events = new List<(int x, int y1, int y2, int type)>();
    foreach (var r in rectangles)
    {
      // 確保座標順序正確 (x1, y1, x2, y2)
      events.Add((r[0], r[1], r[3], 1));  // 左邊界
      events.Add((r[2], r[1], r[3], -1)); // 右邊界
    }

    // 按 X 座標排序
    events = events.OrderBy(e => e.x).ToList();

    long totalArea = 0;
    // 儲存目前掃描線橫跨的所有 Y 區間
    var activeIntervals = new List<(int y1, int y2)>();

    for (int i = 0; i < events.Count - 1; i++)
    {
      var currentEvent = events[i];

      // 更新目前活躍的 Y 區間
      if (currentEvent.type == 1)
        activeIntervals.Add((currentEvent.y1, currentEvent.y2));
      else
        activeIntervals.Remove((currentEvent.y1, currentEvent.y2));

      // 如果 X 有移動，計算這段間隔內的面積
      int deltaX = events[i + 1].x - currentEvent.x;
      if (deltaX > 0 && activeIntervals.Any())
      {
        totalArea += (long)deltaX * CalculateUnionLength(activeIntervals);
      }
    }

    return totalArea;
  }

  // 計算多個 Y 區間聯集後的總長度
  private static int CalculateUnionLength(List<(int y1, int y2)> intervals)
  {
    // 按起點排序區間
    var sorted = intervals.OrderBy(interval => interval.y1).ToList();

    int totalLength = 0;
    if (!sorted.Any()) return 0;

    int currentStart = sorted[0].y1;
    int currentEnd = sorted[0].y2;

    for (int i = 1; i < sorted.Count; i++)
    {
      if (sorted[i].y1 < currentEnd)
      {
        // 有重疊，更新當前結束點
        currentEnd = Math.Max(currentEnd, sorted[i].y2);
      }
      else
      {
        // 無重疊，加上舊區間長度，開啟新區間
        totalLength += currentEnd - currentStart;
        currentStart = sorted[i].y1;
        currentEnd = sorted[i].y2;
      }
    }
    totalLength += currentEnd - currentStart;

    return totalLength;
  }
}

