public class Solution {
    public bool IsPowerOfThree(int n) {
        int powerValue = (int)Math.Pow(3, (int)(Math.Log(int.MaxValue)/Math.Log(3)));
        return powerValue % n == 0;
    }
}