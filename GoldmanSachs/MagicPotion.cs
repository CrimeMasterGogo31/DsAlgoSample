using System;

namespace  DemoConsole.Gs
{
    public class MagicPotion
    {
        public int MinimumStep(string ingredients)
        {
            var len = ingredients.Length;

            string res = "";
            while(len >0)
            {
                if(0 == (len % 2))
                {
                    if(IsRepeated(len, ingredients))
                    {
                        res = "*" + res;
                        len /=2;
                        continue;
                    }
                    else 
                    {
                        res = ingredients[len-1].ToString() + res;
                    }
                }
                else 
                    res = ingredients[len -1].ToString() + res;
                len--;
            }
            Console.WriteLine(res);
            return res.Length ;
        }

        bool IsRepeated(int len , string ingredients)
        {
            int s =0, m =len/2;
            while(m < len)
            {
                if(ingredients[s++] != ingredients[m++])
                    return false;
            }
            return true;
        }
    }
    
}