public class Solution {
    
    private long RDivide(long dividend, long dpower)
    {
        if(dividend < dpower) return  0;
        long[] powers = new long[32];
        int index = 0;
        for(int i = 0; i < powers.Length && dpower <= dividend; ++i, dpower += dpower)
        {
            powers[i] = dpower;
            index = i;
        }
        long ret = 0;
        while(index >= 0 && dividend >= powers[0])
        {
            if(dividend >= powers[index])
            {
                dividend -= powers[index];
                ret += (long) 1 << index;
            }
            -- index;
        }
        return ret;
    }
    
    public int Divide(int dividend, int divisor) {
        if(divisor == 0 || dividend == 0) return 0;
        bool positive = dividend > 0 && divisor >0 || dividend < 0 && divisor < 0;
        long pdividend = Math.Abs((long)dividend), pdivisor = Math.Abs((long)divisor);
        long value = RDivide(pdividend, pdivisor);
        value = positive ? value : - value;
        if(value > int.MaxValue) return int.MaxValue;
        return (int)value;
    }
}