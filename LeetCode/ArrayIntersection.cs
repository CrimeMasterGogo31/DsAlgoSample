using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class ArraysIntersectionClass
    {


    public IList<int> ArraysIntersection(int[] arr1, int[] arr2, int[] arr3) {
            int f=0, s=0,t=0;
            var res  = new List<int>();
            while((f < arr1.Length) && (s< arr2.Length) && (t< arr3.Length))
            {
                if(arr1[f] == arr2[s] && arr1[f] == arr3[t])
                {
                    res.Add(arr1[f]);
                    f++;
                    s++;
                    t++;
                    continue;
                }
                if(arr1[f] < arr2[s] || arr1[f] < arr3[t])
                {
                    f++;
                    continue;
                }
                if(arr2[s] < arr1[f] || arr2[s] < arr2[t])
                {
                    s++;
                    continue;
                }    
                if(arr3[t] < arr1[f] || arr3[t] < arr2[s])
                { 
                    t++;
                    continue;
                }
            
            }
            return res;
        }
    }
}