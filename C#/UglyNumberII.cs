public class Solution {
    public int NthUglyNumber(int n) {
        if(n <= 0) return 0;
        List<int> seq = new List<int>(){ 1 };
        int[] indexes = new int[3]{ 0, 0, 0};
        int[] factors = new int[3]{ 2, 3, 5};
        while(seq.Count < n)
        {
            //find the index j has min value of seq[indexes[j]]*factor[j]
            int min = int.MaxValue;
            for(int j = 0; j < 3; ++j)
            {
                if(seq[indexes[j]] * factors[j] < min)
                {
                    min = seq[indexes[j]] * factors[j];
                }
            }
            for(int j = 0; j < 3; ++j)
            {
                if(seq[indexes[j]] * factors[j] == min)
                {
                    indexes[j] ++;
                }
            }
            seq.Add(min);
        }
        return seq[n - 1];
    }
}