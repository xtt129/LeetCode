public class Solution {
    public int MajorityElement(int[] nums) {
        int x = 0, count = 0;
        foreach(int num in nums)
        {
            if(count > 0)
            {
               count += x == num ? 1 : -1;
            }
            else
            {
                x = num;
                ++ count;
            }
        }
        return x;
    }
}