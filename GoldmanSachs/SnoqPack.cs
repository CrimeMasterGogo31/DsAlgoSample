namespace DemoConsole.Gs{
    public class SnowPack
    {
        public int Calculate(int[] arr)
        {
            int s = 0;
            int e = arr.Length -1;
            int leftmax = 0 , rightmax = 0;
            var tap = 0;
            while(s < e)
            {
                if(arr[s] < arr[e])
                {
                    if(arr[s] > leftmax)
                        leftmax = arr[s];
                    else 
                        tap += (leftmax - arr[s]);
                    s++;
                }
                else
                {
                    if(arr[e] > rightmax)
                        rightmax = arr[e];
                    else 
                        tap += (rightmax - arr[e]);
                    e--;   
                }
            }
            return tap;
        }
    }
}