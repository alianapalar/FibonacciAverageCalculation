﻿public class Average
    {
        public static int Calculate(int n)
        {

        
        int[] fib=new int[n+1];
        fib[0] = 0;
        fib[1] = 1;
        int sum = fib[0] + fib[1];
        for (int i = 2; i <=n; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
            sum+= fib[i];
        }
        return sum;



    }
    }

