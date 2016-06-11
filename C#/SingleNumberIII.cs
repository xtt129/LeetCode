public class Solution {
    public int[] SingleNumber(int[] nums) {
        int xorValue = 0;
        foreach(var i in nums)
        {
            xorValue ^= i;
        }
        int lowbit = (xorValue & (-xorValue));
        int[] ans = new int[2];
        foreach(var i in nums)
        {
            int index = (i & lowbit) >0? 0 : 1;
            ans[index] ^= i;
        }
        return ans;
    }
}