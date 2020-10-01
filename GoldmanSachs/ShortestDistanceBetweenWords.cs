using System;
namespace DemoConsole.Gs{

    public class ShortestDistanceClass
    {
        public double ShortestDistance(string document, string word1, string word2) // handle comma and dot at the end of the word
        {
            if(string.IsNullOrEmpty(document) || string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2))
                return 0;
            var arr = document.Split(" ");
            double mid1 =0, mid2 =0;
            double cur =0, min = double.MaxValue;
            
            foreach(var word in arr)
            {
                if(word.Equals(word1))
                {
                    mid1 = cur + ((double)word1.Length/2);
                }
                else if(word.Equals(word2))
                {
                    mid2 = cur + ((double)word2.Length/2);
                }
                if(mid1 >0 && mid2 >0)
                    min = Math.Min(min, Math.Abs(mid1 - mid2));
                cur += word.Length + 1;
            }

            return min;
        }
    }
}