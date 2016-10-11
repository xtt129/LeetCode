public class Solution {
    public bool IsSelfCrossing(int[] x) {
        if(x == null) return false;
        for(int i = 3; i < x.Length; ++i)
        {
            if(x[i - 3] >= x[i - 1] && x[i] >= x[i - 2]) return true;
            if(i >= 4 && x[i - 1] == x[i -3] && x[i - 2] <= x[i] + x[i- 4]) return true;
            if(i >= 5 && x[i - 4] <= x[i - 2] && x[i - 2] <= x[i - 4] + x[i] && x[i - 3] <= x[i - 1] + x[i - 5] && x[i - 3] >= x[i -1]) return true;
            
        }
        return false;
    }
}