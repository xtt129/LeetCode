public class Solution {
    
    
    private int GetNumber(string num, int startIndex, int length)
    {
        int number = 0;
        for(int i = startIndex; i < Math.Min(startIndex + length, num.Length); ++i)
        {
            number = number * 10 + (int)(num[i] - '0');
        }
        return number;
    }
    
    public bool IsAdditiveNumber(string num) {
        if(null == num || num.Length < 3) return false;
        for(int first = 1; first < num.Length; ++first)
        {
            if(num[0] == '0' && first > 1) continue;
            for(int second = 1; num.Length - first - second >= Math.Max(first, second); ++second)
            {
                if(num[first] == '0' && second > 1 || num[first + second] == '0') continue;
                int num1 = GetNumber(num, 0, first);
                int num2 = GetNumber(num, first, second);
                int index = first + second;
                while(index < num.Length)
                {
                    int sum = num1 + num2;
                    int digits = sum.ToString().Length;
                    int num3 = GetNumber(num, index, digits);
                    if(num3 != sum) break;
                    num1 = num2;
                    num2 = num3;
                    index += digits;
                }
                if(index >= num.Length) return true;
            }
        }
        return false;
    }
}