public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0) return false;
        int reverse = 0;
        for(int i = x; i >0; reverse = reverse * 10 + i % 10,  i /= 10);
        return x == reverse;
    }
}