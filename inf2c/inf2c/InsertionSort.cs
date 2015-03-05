using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    /// <summary>
    /// Insertionsort
    /// </summary>
    public class InsertionSort
    {
        public static T[] InertionSort<T>(T[] array) where T : IComparable
        {
            int upper = array.Length - 1;
            int inner;
            T temp;

            for(int outer = 1; outer <= upper; outer++)
            {
                temp = array[outer];
                inner = outer;

                while (inner > 0 && array[inner - 1].CompareTo(temp) >= 0)
                {
                    array[inner] = array[inner - 1];
                    inner -= 1;
                }
                array[inner] = temp;
            }

            return array;
        }
    }
}
