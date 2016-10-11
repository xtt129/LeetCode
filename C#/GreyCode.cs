public class Solution {
    public IList<int> GrayCode(int n) {
        IList<List<int>> ans = new List<List<int>>(){new List<int>(){0, 1}, new List<int>()};
        if(n == 0) return new List<int>(){ 0};
        int current = 0;
        for(int i = 2; i <= n; ++i)
        {
            int pre = current;
            current  = 1 - current;
            ans[current].Clear();
            int firstDigit = 1 << (i - 1);
            ans[pre].ForEach(x=> { ans[current].Add(x); });
            for(int j = ans[pre].Count - 1; j >= 0; --j)
            {
                ans[current].Add(firstDigit + ans[pre][j]);
            }
        }
        return ans[current];
    }
}