public class Solution {
    public string AddBinary(string a, string b) {
        if(null == a || null == b) return null;
        int resLen = Math.Max(a.Length, b.Length);
        int carry = 0;
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < resLen; ++i)
        {
            int num1 = a.Length - i - 1 >= 0 ? a[a.Length - i - 1] - '0' : 0;
            int num2 = b.Length - i - 1 >= 0 ? b[b.Length - i - 1] - '0' : 0;
            int sum = num1 + num2 + carry;
            carry = sum  / 2;
            sb.Append(sum % 2);
        }
        if(carry > 0)
        {
            sb.Append(carry);
        }
        char[] chars = sb.ToString().ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
        
    }
}