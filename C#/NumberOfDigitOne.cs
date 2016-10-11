public class Solution {

    private int CountFor9s(int n)
    {
        if(n <= 0) return 0;
        if(n < 10) return 1;
        int factor = 1;
        for(int temp = n / 10; temp > 0; temp /= 10, factor *= 10);
        return CountFor9s(n % factor) * 10 + factor;
    }
    
    public int CountDigitOne(int n) {
        if(n <= 0) return 0;
        if(n < 10) return 1;
        int factor = 1;
        for(int temp = n / 10; temp > 0; temp /= 10, factor *= 10);
        int x = n / factor;
        if(x == 1)
        {
            return CountFor9s(factor - 1) + n % factor + 1 + CountDigitOne(n % factor);
        }
        else
        {
            return CountFor9s(factor - 1) * x + factor + CountDigitOne(n % factor);
        }
    }
}