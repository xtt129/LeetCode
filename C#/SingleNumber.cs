public class Solution
{
    public int SingleNumber(int[] nums)
    {
        int ans = 0;
        nums.ForEach(i=> 
        {
           ans = ans ^ i;
        });
        return ans;
    }
}