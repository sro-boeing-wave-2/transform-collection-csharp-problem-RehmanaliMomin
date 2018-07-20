using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{

    public delegate int mapdel(int y); 

    public static class Transform 
    {

        public static List<int> Map(int[] input, mapdel operation)
        {
            List<int> trans = new List<int>();
            foreach (var item in input)
            {
                trans.Add(operation(n));
            }

            return trans;

        }
    }
}
