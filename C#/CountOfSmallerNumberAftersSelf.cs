public class Solution {

    public class BSTNode{
        public BSTNode left = null, right = null;
        public int value;
        public int count;
        public int dup;
        public BSTNode(int val)
        {
            this.value = val;
            this.count = 0;
            this.dup = 1;
        }
    }

    private BSTNode InsertBSTNode(BSTNode root, int value)
    {
        if(root == null) return new BSTNode(value);
        if(value == root.value)
        {
            root.dup ++;
        }
        else if(value < root.value)
        {
           root.left = InsertBSTNode(root.left, value);
           root.count ++;
        }
        else
        {
           root.right = InsertBSTNode(root.right, value);
        }
        return root;
    }

    private int GetCount(BSTNode root, int value)
    {
        if(root == null) return 0;
        if(root.value  == value) return root.count;
        if(value < root.value) return GetCount(root.left, value);
        return root.count + root.dup + GetCount(root.right, value);
    }

    public IList<int> CountSmaller(int[] nums) {
        IList<int> ans = new List<int>();
        if(nums == null || nums.Length == 0) return ans;
        BSTNode root = null;
        for(int i = nums.Length - 1; i >= 0; --i)
        {
            root = InsertBSTNode(root, nums[i]);
            ans.Add(GetCount(root, nums[i]));
        }
        return ans.Reverse().ToList();    
    }
}





public class Solution2 {
    private void Update(int[] nums, int index)
    {
        while(index < nums.Length)
        {
            nums[index] ++;
            index = index + Lowbit(index);
        }
    }
    
    private int Sum(int[] nums, int index)
    {
        int count = 0 ;
        while(index > 0)
        {
            count += nums[index];
            index = index - Lowbit(index);
        }
        return count;
    }  

    private int Lowbit(int n)
    {
        return n & (-n);
    }  

    public IList<int> CountSmaller(int[] nums) {
        if(null == nums || nums.Length == 0) return new List<int>();
        SortedDictionary<int, int> dict = new SortedDictionary<int, int>();
        foreach(int num in nums)
        {
            if(!dict.ContainsKey(num)) dict.Add(num, 0);
            dict[num] ++;
        }
        int count = 1;
        foreach(var key in dict.Keys.ToList())
        {
            dict[key] = count ++;
        }
        int[] bit = new int[count];
        IList<int> ans = new List<int>();
        for(int i = nums.Length - 1; i >= 0; --i)
        {
            ans.Add(Sum(bit, dict[nums[i]] - 1));
            Update(bit, dict[nums[i]]);
        }
        return ans;
    }
}