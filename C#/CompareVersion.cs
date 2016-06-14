public class Solution {
    public int CompareVersion(string version1, string version2) {
        if(null == version1 &&  null == version2) return 0;
        if(null == version1) return -1;
        if(null == version2) return 1;
        for(int i = 0, j = 0; i < version1.Length || j < version2.Length; ++i, ++j)
        {
            int num1 = 0, num2 = 0;
            while(i < version1.Length && Char.IsNumber(version1[i]))
            {
                num1 = num1 * 10 + (int)(version1[i] - '0');
                ++i;
            }
            while(j < version2.Length && Char.IsNumber(version2[j]))
            {
                num2 = num2 * 10 + (int)(version2[j] - '0');
                ++j;
            }
            if(num1 < num2) return -1;
            if(num1 > num2) return 1;
        }
        return 0;
    }
}