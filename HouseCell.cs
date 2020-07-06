using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoConsole
{
    //public class HouseCell
    //{
    //    public List<int> Run(List<int> sequence, int days)
    //    {
    //        var allowedSpace = new List<int>() { };
    //        var dict = new Dictionary<int, List<KeyValuePair<int, int>>>();
    //        List<int> packagesSpace = new List<int>() { };
    //        for (int i = 0; i < packagesSpace.Count; i++)
    //        {
    //            if (!dict.ContainsKey(packagesSpace[i]))
    //            {
    //                if (allowedSpace > packagesSpace[i])
    //                {
    //                    dict.Add(allowedSpace - packagesSpace[i],
    //                    new List<KeyValuePair<int, int>>(){
    //                new KeyValuePair<int,int>(i,packagesSpace[i])


    //                         }
    //                        );
    //                }
    //            }
    //            else
    //            {
    //                var value = dict[packagesSpace[i]];
    //                value.Add(new KeyValuePair() { i, packagesSpace[i] });
    //                dict[packagesSpace[i]] = value;
    //            }

    //        }


	                
    //        foreach (var v in dict2)
    //        {
    //            var t = v.Value.Count;
    //        }
    //        Dictionary<int, int> dict = new Dictionary<int, int>();
    //        int count = 1;
    //        foreach (var val in sequence)
    //        {
    //            dict.Add(count++, val);
    //        }
    //        while (days != 0)
    //        {

    //            var tempdict = new Dictionary<int, int>();
    //            tempdict.ContainsKey(2);
    //            int prevCellValue = 0;
    //            int nextCellValue = 0;

    //            for (int i = 1; i <= 8; i++)
    //            {
    //                prevCellValue = i - 1 == 0 ? 0 : dict[i - 1];
    //                nextCellValue = i + 1 == 9 ? 0 : dict[i + 1];
    //                tempdict[i] = ComputeCellValue(prevCellValue, nextCellValue);
    //            }
    //            dict = tempdict;
    //            days--;


    //        }

    //        return dict.Values.ToList();
    //    }

    //    private int ComputeCellValue(int prev, int next)
    //    {
    //        int result;
    //        switch (prev + next)
    //        {
    //            case 2:
    //            case 0:
    //                result = 0;
    //                break;
    //            case 1:
    //                result = 1;
    //                break;
    //            default:
    //                result = 0;
    //                break;
    //        }
    //        return result;
    //    }
    //}
}
