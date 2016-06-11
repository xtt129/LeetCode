public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        if(null == nums || nums.Length ==0) return new int[0];
        int[] elements = new int[nums.Length];
        int prod = 1;
        for(int i = 0; i < nums.Length; prod *= nums[i], ++i)
        {
            elements[i] = prod;
        }
        prod = 1;
        for(int i = nums.Length  - 1; i >= 0; prod *= nums[i], --i)
        {
            elements[i] *= prod;
        }
        return elements;
    }
}