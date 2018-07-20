using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{

    public delegate int mapdel(int y); 

    public static class Transform 
    {
        public static List<int> Map(this int[] input, mapdel operation)
        {
            List<int> trans = new List<int>();
            foreach (int item in input)
            {
                trans.Add(operation(item));
            }
            return trans;
        }
    }
}
