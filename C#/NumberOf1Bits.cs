public class Solution {
    public int HammingWeight(uint n) {
        int count = 0;
        for(; n>0 ; n &= (n - 1), ++count);
        return count;
    }
}