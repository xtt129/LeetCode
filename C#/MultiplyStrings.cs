public class Solution {
    public string Multiply(string num1, string num2) {
        if(null == num1 || null == num2 || num1.Length ==0 || num2.Length ==0) return null;
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < num2.Length + num1.Length; ++i) sb.Append("0");
        for(int i = 0; i < num2.Length; ++i)
        {
            int number2 = num2[num2.Length - 1 - i] - '0';
            int carry = 0, start = i;
            for(int j = 0; j < num1.Length; ++j)
            {
                int number1 = num1[num1.Length - 1 - j] - '0';
                int sum = number2 * number1 + (int)(sb[start] - '0') + carry;
                sb[start++] = (char)('0' + sum % 10);
                carry = sum / 10; 
            }
            if(carry > 0)
            {
                sb[start] = (char)('0' + carry);
            }
        }
        while(sb.Length > 1 && sb[sb.Length - 1] == '0')
        {
            sb.Remove(sb.Length - 1, 1);
        }
        var chars = sb.ToString().ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}