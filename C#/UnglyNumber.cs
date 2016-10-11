public class Solution {
    public bool IsUgly(int num) {
        if(num < 1) return false;
        if(num == 1) return true;
        int[] factors = new int[3]{2, 3, 5};
        foreach(var factor in factors)
        {
            while(num % factor == 0)
            {
                num /= factor;
            }
        }
        return num == 1;
    }
}