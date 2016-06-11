public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        if(null == nums.Length) return false;
        int x = int.MaxValue, y = int.MaxValue;
        foreach(int num in nums)
        {
            if(x >= num)
            {
                x = num;
            }
            else if (y >= num)
            {
                y = num;
            }
            else
            {
                return true;
            }
        }
        return false;
    }
}