public class Solution {
    private string[] thousands = new string[4]{"", "Thousand", "Million", "Billion"};
    private string[] tens = new string[]{"", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};
    private string[] basic = new string[]{"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
    
    
    private string IntToString(int num)
    {
        if(num == 0) return  "";
        StringBuilder sb = new StringBuilder(" ");
        if(num / 100 > 0)
        {
            sb.Append(basic[num / 100]).Append(" Hundred").Append(IntToString(num % 100));
        }
        else if(num < basic.Length)
        {
            sb.Append(basic[num]);
        }
        else
        {
            sb.Append(tens[num / 10]).Append(IntToString(num % 10));
        }
        return sb.ToString();
    }
    
    public string NumberToWords(int num) {
        if(num == 0) return "Zero";
        StringBuilder str = new StringBuilder();
        int unit = 0;
        while(num > 0)
        {
            if(num % 1000 != 0)
            {
                int under1000 = num % 1000;
                string numStr = IntToString(under1000);
                str.Insert(0, thousands[unit]).Insert(0, " ").Insert(0, numStr);
            }
            num /= 1000;
            ++unit;
        }
        return str.ToString().Trim();
    }
}