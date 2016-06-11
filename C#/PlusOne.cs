public class Solution {
    public int[] PlusOne(int[] digits) {
        if(null == digits) return null;
        int carray = 1;
        List<int> ans = new List<int>();
        for(int i = digits.Length - 1; i >=0; --i)
        {
            carray += digits[i];
            ans.Add(carray % 10);
            carray /= 10;
        }
        if(carray >0)
        {
            ans.Add(carray);
        }
        ans.Reverse();
        return ans.ToArray();
    }
}