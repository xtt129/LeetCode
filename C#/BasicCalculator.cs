public class Solution {    

    private string ExtractToken(string s, ref int start)
    {
        while(start < s.Length && s[start] == ' ') ++start;
        if(start >= s.Length) return null;
        if(s[start] == '+' || s[start] == '-' || s[start] == '(' || s[start] == ')')
        {
            start ++;
            return s[start - 1].ToString();
            
        }
        int previous = start;
        while(start < s.Length && s[start] >= '0' && s[start] <= '9') ++ start;
        return s.Substring(previous, start - previous);
    }    

    public int Calculate(string s) {
        if(null == s) return 0;
        Stack<int> stack = new Stack<int>();
        int start = 0, sign = 1, result = 0;
        for(string token = ExtractToken(s, ref start); null != token; token = ExtractToken(s, ref start))
        {
            if(token[0] >= '0' && token[0] <='9') result += sign * int.Parse(token);
            if(token == "+") sign = 1;
            if(token == "-") sign = -1;
            if(token == "(")
            {
                stack.Push(result);
                stack.Push(sign);
                sign = 1;
                result = 0;
            }
            if(token == ")")
            {
                result = stack.Pop() * result + stack.Pop();
            }
        }
        return result;
    }
}