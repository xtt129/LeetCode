public class Solution {
    public string SimplifyPath(string path) {
        if(null == path) return path;
        string[] paths = path.Split(new char[1]{'/'}, StringSplitOptions.RemoveEmptyEntries);
        Stack<string> stack = new Stack<string>();
        foreach(string p in paths)
        {
            if(p == ".") continue;
            if(p == "..") 
            {
                if(stack.Count > 0) stack.Pop();
                continue;
            }
            stack.Push(p);
        }
        paths = stack.ToArray();
        Array.Reverse(paths);
        return "/" + string.Join("/", paths);
    }
}