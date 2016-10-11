public class Solution {
    
    public int RomanToInt(string s) {
        Dictionary<char, int> chars = new Dictionary<char,int>()
        {
            {'M', 1000},
            {'C', 100},
            {'D', 500},
            {'X', 10},
            {'L', 50},
            {'I', 1},
            {'V', 5}
        };
        int value = 0, previous = 0;
        foreach(char ch in s)
        {
            int digit =  chars[ch];
            value += digit;
            if(digit > previous) value -= 2* previous;
            previous = digit;
        }
        return value;
    }
}