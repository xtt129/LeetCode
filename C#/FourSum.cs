public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        IList<IList<int>> qdlets = new List<IList<int>>();
        if(null == nums) return qdlets;
        Array.Sort(nums);
        for(int i = 0; i < nums.Length - 3; ++i)
        {
            if(i ==0 || nums[i] != nums[i-1])
            {
                for(int j = i+1; j < nums.Length - 2; ++j)
                {
                    if( j== i+1 || nums[j] != nums[j-1])
                    {
                        int low = j+1, high = nums.Length -1;
                        while(low < high)
                        {
                            int addup = nums[i] + nums[j] + nums[low] + nums[high];
                            if(addup == target)
                            {
                                qdlets.Add(new List<int>(){nums[i], nums[j], nums[low++], nums[high--]});
                                while(low < high && nums[low] == nums[low-1]) ++low;
                                while(low < high && nums[high] == nums[high+1]) --high;
                            }
                            else if(addup < target)
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
            }
        }
        return qdlets;
    }
}