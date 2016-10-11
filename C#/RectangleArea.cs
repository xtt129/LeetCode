public class Solution {
    
    public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H) {
        int lowerTop = Math.Min(D, H);
        int higherBottom = Math.Max(B, F);
        int lefterRight = Math.Min(C, G);
        int rigterLeft = Math.Max(A, E);
        bool overlap  = lefterRight > rigterLeft && lowerTop > higherBottom;
        int area1 = Math.Abs(A - C) * Math.Abs(B - D);
        int area2 = Math.Abs(E - G) * Math.Abs(F - H);
        int over = overlap ? Math.Abs(lowerTop - higherBottom) * Math.Abs(lefterRight - rigterLeft) : 0;
        return area1 + area2 - over;
    }
}