using System;
namespace DemoConsole.Gs{

    public class WalkingRobot
    {
        public int[] Walk(string path) 
        {
            int x =0, y =0;
            if(string.IsNullOrEmpty(path))
                return new int[] {x, y};

            foreach(var ch in path)
            {
                switch(ch)
                {
                    case 'U':
                        y++;
                        break;
                    case 'R':
                        x++;
                        break;
                     case 'D':
                        y--;
                        break;
                    case 'L':
                        x--;
                        break;
                    default:
                        break;
                }
            }
            return new int[]{x, y};
        
        }

    }
}