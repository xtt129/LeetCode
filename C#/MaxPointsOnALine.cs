/**
 * Definition for a point.
 * public class Point {
 *     public int x;
 *     public int y;
 *     public Point() { x = 0; y = 0; }
 *     public Point(int a, int b) { x = a; y = b; }
 * }
 */
public class Solution {
    
    private int GCD(int a, int b)
    {
         if(b == 0) return a;
         return GCD(b, a % b);
    }
    private void getLineInfo(Point p1, Point p2, out int x, out int y)
    {
        x = p1.x - p2.x;
        y=  p1.y - p2.y;
        int gcd = GCD(x, y);
        x /= gcd;
        y /= gcd;
    }
    
    public int MaxPoints(Point[] points) {
        if(null == points || points.Length == 0) return 0;
        if(points.Length <= 2) return points.Length;
        Dictionary<int, Dictionary<int, int>> dict = new Dictionary<int, Dictionary<int, int>>();
        int ans = 0;
        for(int i = 0; i < points.Length - 1; ++i)
        {
            dict.Clear();
            int overlap = 0;
            for(int j = i +1; j < points.Length; ++j)
            {
                if (points[i].x - points[j].x ==0 && points[i].y - points[j].y ==0)
                {
                    overlap++;
                    continue;
                }
                int x, y;
                getLineInfo(points[i], points[j], out x, out y);
                if(!dict.ContainsKey(x))    dict.Add(x, new Dictionary<int, int>());
                if(!dict[x].ContainsKey(y)) dict[x].Add(y, 0);
                dict[x][y] ++;
            }
            int max = 0;
            foreach(var innerDict in dict)
            {
                foreach(var pair in innerDict.Value)
                {
                     max = Math.Max(max, pair.Value);
                }
            }
            ans = Math.Max(ans, max + overlap + 1);
        }
        return ans;
    }
}