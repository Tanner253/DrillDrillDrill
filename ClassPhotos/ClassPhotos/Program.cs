using System;
using System.Collections.Generic;

namespace ClassPhotos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> red = new List<int>();
            List<int> blue = new List<int>();
            red.Add(5);
            red.Add(8);
            red.Add(1);
            red.Add(3);
            red.Add(4);

            blue.Add(5);
            blue.Add(8);
            blue.Add(1);
            blue.Add(3);
            blue.Add(4);
            var result = ClassPhotos(blue, red);
            Console.WriteLine($"{result}");
        }
        public static bool ClassPhotos(List<int> blueTeamHeights, List<int> redTeamHeights)
        {
            redTeamHeights.Sort((a, b) => b.CompareTo(a));
            blueTeamHeights.Sort((a, b) => b.CompareTo(a));

            string BackRow = (redTeamHeights[0] > blueTeamHeights[0]) ? "RED" : "BLUE";
            for (int i = 0; i < redTeamHeights.Count; i++)
            {
                if (BackRow == "RED")
                {
                    if (blueTeamHeights[i] >= redTeamHeights[i])
                    {
                        return false;
                    }
                    else if (redTeamHeights[i] > blueTeamHeights[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
