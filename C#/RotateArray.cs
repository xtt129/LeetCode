public class Solution {
    public void Rotate(int[] nums, int k) {
        if(null == nums || nums.Length == 0) return;
        int position = nums.Length - k % nums.Length;
        if(position == nums.Length) return;
        Array.Reverse(nums, 0, position);
        Array.Reverse(nums, position, nums.Length - position);
        Array.Reverse(nums, 0, nums.Length);
    }
}