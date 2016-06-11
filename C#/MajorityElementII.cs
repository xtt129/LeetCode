public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        IList<int> elements = new List<int>();
        if(null == nums || nums.Length == 0) return elements;
        int x = 0, xCount = 0, y = 1, yCount = 0;
        foreach(int num in nums)
        {
            if(num == x)
            {
                ++xCount;
            }
            else if(num == y)
            {
                ++yCount;
            }
            else if(xCount == 0)
            {
                ++xCount;
                x = num;
            }
            else if(yCount == 0)
            {
                ++yCount;
                y = num;
            }
            else
            {
                --xCount;
                --yCount;
            }
        }
        xCount = 0; yCount = 0;
        foreach(int num in nums)
        {
            xCount += num == x ? 1 : 0;
            yCount += num == y ? 1 : 0;
        }
        if(xCount > nums.Length / 3)
        {
            elements.Add(x);
        }
        if(yCount > nums.Length / 3)
        {
            elements.Add(y);
        }
        return elements;
        
    }
}