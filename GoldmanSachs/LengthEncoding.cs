namespace DemoConsole.Gs
{
    public class LengthEncoding
    {
        public string RLE(string input)
        {
            if(string.IsNullOrEmpty(input))
                return "";

            int s=0, e=1;
            string res ="";
            while(s < input.Length && e < input.Length)
            {
                if(input[s] != input[e])
                {
                    res += input[s].ToString() + (e-s).ToString();
                    s = e;
                }
                e++;
            }
            res += input[s].ToString() + (e-s).ToString();
            return res;
        }
    }
}