using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_DET_2022
{
    internal class iterators
    {
        static void Main()
        {
            foreach (int number in EvenSequence(5, 18))
            {
                Console.Write(number.ToString() + " ");
            }
           
            Console.ReadKey();
        }

        public static System.Collections.Generic.IEnumerable<int>
            EvenSequence(int firstNumber, int lastNumber)
        {
            //Yield even numbers in the range.
            for (int number = firstNumber; number <= lastNumber; number++)
            {
                if (number % 2 == 0)
                {
                    yield return number;
                }
            }
        }
    }
}
