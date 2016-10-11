public class Solution {
    public string FractionToDecimal(int numerator, int denominator) {
        if(denominator == 0) return null;
        bool positive = numerator >= 0 && denominator > 0 || numerator <= 0 && denominator < 0;
        long a = Math.Abs((long)numerator), b = Math.Abs((long)denominator);
        StringBuilder sb = new StringBuilder(positive ? "" : "-");
        sb.Append(a / b);
        a %= b;
        if(a == 0) return sb.ToString();
        Dictionary<long, int> dict = new Dictionary<long, int>();
        List<long> fractional = new List<long>();
        sb.Append(".");
        while(a != 0 && !dict.ContainsKey(a))
        {
             fractional.Add( a * 10 / b);
             dict.Add(a, fractional.Count - 1);
             a = a * 10 % b;
        }
        if(a == 0)
        {
            fractional.ForEach(f => sb.Append(f));
        }
        else
        {
            int start = dict[a];
            for(int i = 0; i < start; ++i)
            {
                sb.Append(fractional[i]);
            }
            sb.Append('(');
            for(int i = start; i < fractional.Count; ++i)
            {
                 sb.Append(fractional[i]);
            }
            sb.Append(')');
        }
        return sb.ToString();
    }
}