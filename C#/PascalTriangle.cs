public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> triangle = new List<IList<int>>();
        if(numRows == 0) return triangle;
        triangle.Add(new List<int>(){1});
        for(int i = 2; i <= numRows; ++i)
        {
            IList<int> row = new List<int>(){1};
            for(int j = 1; j <= i - 2; ++j)
            {
                row.Add(triangle[i-2][j] + triangle[i-2][j-1]);
            }
            row.Add(1);
            triangle.Add(row);
        }
        return triangle;
    }
}