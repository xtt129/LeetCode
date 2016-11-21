/**
 * Definition for an interval.
 * public class Interval {
 *     public int start;
 *     public int end;
 *     public Interval() { start = 0; end = 0; }
 *     public Interval(int s, int e) { start = s; end = e; }
 * }
 */
public class Solution {
    public IList<Interval> Merge(IList<Interval> intervals) {
        if(intervals == null) return null;
        IList<Interval> ans = new List<Interval>();
        if(intervals.Count == 0) return ans;
        var sorted = intervals.OrderBy(i=> i.start);
        Interval candidate = new Interval(sorted.First().start, sorted.First().end);
        foreach(var interval in sorted)
        {
            if(candidate.end < interval.start)
            {
                ans.Add(candidate);
                candidate = new Interval(interval.start, interval.end);
            }
            else
            {
                candidate.end = Math.Max(candidate.end, interval.end);
            }
        }
        ans.Add(candidate);
        return ans;
    }
}