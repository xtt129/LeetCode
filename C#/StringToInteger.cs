public class Solution {
    public int MyAtoi(string str) {
        if(null == str) return 0;
        int value = 0;
        bool positive = true;
        int index = 0;
        while(index < str.Length && str[index] == ' ') ++index;
        if(index == str.Length) return 0;
        if(str[index] == '+')
        {
            positive = true;
            ++index;
        }
        else if(str[index] == '-')
        {
            positive = false;
            ++index;
        }
        else if(str[index] > '9' || str[index] < '0')
        {
            return 0;
        }
        while(index < str.Length && str[index] >= '0' && str[index] <= '9')
        {
            int offset = str[index++] - '0';
            if(value > ((int.MaxValue - offset) / 10))
            {
                return positive? int.MaxValue : int.MinValue;
            }
            value = value * 10 + offset;
        }
        return positive? value : -1 * value;
    }
}