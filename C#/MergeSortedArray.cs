public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int i = m, j = n;
        while(i > 0 && j > 0)
        {
            if(nums1[i - 1] > nums2[j - 1])
            {
                nums1[i + j -1] = nums1[i - 1];
                --i;
            }
            else
            {
                nums1[i + j - 1] = nums2[j - 1];
                --j;
            }
        }
        while(j > 0)
        {
            nums1[j -1] = nums2[j - 1];
            --j;
        }
    }
}