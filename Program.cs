using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Solution solu=new Solution();
            int[] prices=new int[]{7, 1, 5, 3, 6, 4};
            var result=solu.MaxProfit(prices);

            Console.WriteLine(result);
        }
    }
    
    public class Solution {
        public int MaxProfit(int[] prices) {
            int MaxProfit=0;
            
            
            if(prices.Length==0 || prices.Length==1)
            {
                return 0;
            }else
            {
                int Lowest=prices[0];
                for(var i=1;i<prices.Length;i++)
                {
                   if(prices[i]<Lowest)
                   {
                       Lowest=prices[i];
                   }
                   
                   if(prices[i]-Lowest>MaxProfit)
                   {
                       MaxProfit=prices[i]-Lowest;
                   }
                }
                return MaxProfit;
            }
            
        }
    }
}
