public class Solution {
    public bool IsValid(string s) {
        if(null == s) return true;
        Stack<char> brackets = new Stack<char>();
        foreach(char ch in s)
        {
            if(ch == '(' || ch =='[' || ch =='{') brackets.Push(ch);
            else
            {
                if(brackets.Count == 0) return false;
                char acture = brackets.Pop();
                char expected = ' ';
                switch(ch)
                {
                    case ')': expected = '('; break;
                    case '}': expected = '{'; break;
                    case ']': expected = '['; break;
                }
                if(acture != expected) return false;
            }
        }
        return brackets.Count == 0;
    }
}