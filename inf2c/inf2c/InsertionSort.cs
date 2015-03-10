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
        /// <summary>
        /// Quote from book:
        /// "I take the cards back to my office, clear off my desk, and take the first card.
        /// The name on the card is Smith. I place it at the top left position of the desk
        /// and take the second card. It is Brown. I move Smith over to the right and
        /// put Brown in Smith’s place. The next card is Williams. It can be inserted at
        /// the right without having to shift any other cards. The next card is Acklin.
        /// It has to go at the beginning of the list, so each of the other cards must be
        /// shifted one position to the right to make room"
        /// </summary>
        /// <typeparam name="T">Type of array objects, needs to implement IComparable interface</typeparam>
        /// <param name="array">Array to sort</param>
        /// <returns>Sorted array</returns>
        public static T[] InertionSort<T>(T[] array) where T : IComparable
        {
            // upper
            int upper = array.Length - 1;
            int inner;
            T tempElement;

            // outer loop moves element by element through the array
            for(int outer = 1; outer <= upper; outer++)
            {
                tempElement = array[outer];
                inner = outer;

                // inner loop compares the element chosen in the outer loop to the element next to it
                while (inner > 0 && array[inner - 1].CompareTo(tempElement) >= 0)
                {
                    // move element
                    array[inner] = array[inner - 1];
                    inner -= 1;
                }
                
                // place temp element
                array[inner] = tempElement;
            }

            // return the sorted array
            return array;
        }
    }
}
