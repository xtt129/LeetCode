public class Solution {
    public void SortColors(int[] nums) {
        if(nums == null) return;
        int[] colors = new int[3];
        foreach(var num in nums)
        {
            colors[num] ++;
        }
        int idx = 0;
        for(int i = 0; i < colors.Length; ++i)
        {
            for(int j = 0; j < colors[i]; ++j)
            {
                nums[idx++] = i;
            }
        }
    }
}