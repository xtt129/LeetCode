public class Solution {
    public int CountPrimes(int n) {
        if(n <= 2) return 0;
        List<int> primes = new List<int>(){2};
        for(int i = 3; i <n; ++i)
        {
             bool isPrime = true;
             for(int j =0; j < primes.Count && primes[j] * primes[j] <=i; ++j)
             {
                 if(i % primes[j] ==0)
                 {
                     isPrime = false;
                     break;
                 }
             }
             if(isPrime) primes.Add(i);
        }
        return primes.Count;
    }
}


public class Solution {
    public int CountPrimes(int n) {
        if(n <= 2) return 0;
        bool[] isPrimes = new bool[n + 1];
        for(int i = 2; i <= n; ++i)
        {
            isPrimes[i] = true;
        }
        for(int i = 2; i * i < n ; ++i)
        {
            if(isPrimes[i])
            {
                int j = i * i;
                while(j < n)
                {
                    isPrimes[j] = false;
                    j = j + i;
                }
            }
        }
        int count = 0;
        for(int i = 2; i < n; ++i)
        {
            count += isPrimes[i]? 1 : 0;
        }
        return count;
    }
}