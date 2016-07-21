public class Solution {
    public bool IsValidSerialization(string preorder) {
        if(string.IsNullOrEmpty(preorder)) return false;
        string[] nodes = preorder.Split(new char[1]{ ',' });
        int degree = -1;
        foreach(string node in nodes)
        {
            ++degree;
            if(degree > 0) return false;
            if(!"#".Equals(node)) degree -= 2;
        }
        return degree == 0;
    }
}