public class NumArray {

    public class SegmentTreeNode
    {
        public int left, right;
        public SegmentTreeNode leftNode = null, rightNode = null;
        public int val;
        public SegmentTreeNode()
        {
        }
        
        public void Update(int val, int index)
        {
            if(this.left == this.right)
            {
                if(this.left == index)
                {
                    this.val = val;
                }
                return;
            }
            if(this.left > index || this.right < index) return;
            this.leftNode.Update(val, index);
            this.rightNode.Update(val, index);
            this.val = this.leftNode.val + this.rightNode.val;
        }
        
        public int SumRange(int left, int right)
        {
            if(right < this.left || this.right < left) return 0;
            if(left <= this.left && right >= this.right) return this.val;
            if(this.left != this.right)
            {
                return this.leftNode.SumRange(left, right) + this.rightNode.SumRange(left, right);
            }
            return 0;
        }
        
        public void BuildTree(int left, int right)
        {
            this.left = left;
            this.right = right;
            if(left == right) return;
            int m = (left + right) / 2;
            this.leftNode = new SegmentTreeNode();
            this.leftNode.BuildTree(left, m);
            this.rightNode = new SegmentTreeNode();
            this.rightNode.BuildTree(m+1 , right);
        }
    }
    
    private SegmentTreeNode root;


    public NumArray(int[] nums) {
        root = new SegmentTreeNode();
        if(nums!= null && nums.Length > 0)
        {
            root.BuildTree(0, nums.Length - 1);
            for(int i = 0 ; i < nums.Length ; ++i)
            {
                root.Update(nums[i], i);
            }
        }
    }

    public void Update(int i, int val) {
        root.Update(val, i);
    }

    public int SumRange(int i, int j) {
        return root.SumRange(i, j);
    }
}


// Your NumArray object will be instantiated and called as such:
// NumArray numArray = new NumArray(nums);
// numArray.SumRange(0, 1);
// numArray.Update(1, 10);
// numArray.SumRange(1, 2);