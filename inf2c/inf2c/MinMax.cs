using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    public class MinMax
    {

        public static int FindMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }

            return min;
        }

        public static int FindMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }

            return max;
        }
    }
}
