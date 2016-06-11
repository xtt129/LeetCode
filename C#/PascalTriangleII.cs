public class Solution {
    public IList<int> GetRow(int rowIndex) {
        IList<int> row = new List<int>();
        row.Add(1);
        for(int i = 1; i <=rowIndex; ++i)
        {
            int previous = 0;
            for(int j = 0; j < i; ++j)
            {
                int temp = row[j];
                row[j] = previous + temp;
                previous = temp;
            }
            row.Add(1);
        } 
        return row;
    }
}