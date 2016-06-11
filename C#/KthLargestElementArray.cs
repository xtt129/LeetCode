public class Solution {
    private void Swap(ref int i, ref int j)
    {
        int temp = i;
        i = j;
        j = temp;   
    }
    private int Partition(int[] nums,int left, int right, int k)
    {
        int x = nums[left];
        int i = left + 1, j = right;
        while(i <= j)
        {
            if(nums[i] < x && nums[j] > x)
            {
                Swap(ref nums[i], ref nums[j]);
                ++i; --j;
            }
            if(nums[i] >= x) ++i;
            if(nums[j] <= x) --j;
        }
        Swap(ref nums[left], ref nums[j]);
        if(j - left + 1 > k) return Partition(nums, left, j - 1, k);
        if(j - left + 1 < k) return Partition(nums, j + 1, right, k - (j - left + 1));
        return nums[j];
    }
    public int FindKthLargest(int[] nums, int k) {
        if(null == nums || k > nums.Length || k <= 0) return 0;
        return Partition(nums, 0, nums.Length - 1, k);
    }
}


public class Solution2 {
    public class BiggerIntComparer:Comparer<int>
    {
        public override int Compare(int x, int y)
        {
            return y - x;
        }
    }
    public int FindKthLargest(int[] nums, int k) {
        if(null == nums || k > nums.Length) return 0;
        Array.Sort(nums, new BiggerIntComparer());
        return nums.Skip(k - 1).Take(1).First();
    }
}