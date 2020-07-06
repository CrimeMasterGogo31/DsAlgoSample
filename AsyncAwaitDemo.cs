using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoConsole
{
    class AsyncAwaitDemo
    {
        public async Task DoOperaiton()
        {
             var res = await DoAynchronously();
            Console.WriteLine("After calling sleep method");
            
        }
        public async Task<demo> DoAynchronously() {
            Thread.Sleep(4000);
            Console.WriteLine("After 4 minutes delay");
            var result = new demo();
            return result;
        }
    }
     public class demo {
       public int id;
    }

    
}
