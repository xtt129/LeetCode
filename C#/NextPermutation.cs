public class Solution {
    
    public void NextPermutation(int[] nums) {
        if(null == nums) return;
        int index = nums.Length -1;
        for(; index > 0 && nums[index] <= nums[index-1]; --index);
        if(index > 0)
        {
            int replace = nums.Length -1;
            for(; replace >= index && nums[replace] <= nums[index-1]; --replace);
            int temp = nums[index-1];
            nums[index-1] = nums[replace];
            nums[replace] = temp;
        }
        Array.Sort(nums, index, nums.Length - index);
    }
}