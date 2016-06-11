public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> triplets = new List<IList<int>>();
        if(null == nums) return triplets;
        Array.Sort(nums);
        for(int i = 0; i <= nums.Length -2 ; ++i)
        {
            if(i == 0 || nums[i] != nums[i-1])
            {
                int target = -nums[i];
                int low = i+1, high = nums.Length - 1;
                while(low < high)
                {
                    if(nums[low] + nums[high] == target)
                    {
                        triplets.Add(new List<int>(){nums[i], nums[low++], nums[high--]});
                        while(low < high && nums[low] == nums[low-1]) ++low;
                        while(low < high && nums[high] == nums[high+1]) --high;
                    }
                    else if(nums[low] + nums[high] < target)
                    {
                        ++low;
                    }
                    else
                    {
                        --high;
                    }
                }
                
            }
        }
        return triplets;
    }
    
}