public class Solution {
    public int SingleNumber(int[] nums) {
        int one = 0, two = 0, three = 0;
        foreach(var i in nums)
        {
            two |= one & i;
            one ^= i;
            three = one & two;
            one &= ~three;
            two &= ~three;
        }
        return one;
    }
}