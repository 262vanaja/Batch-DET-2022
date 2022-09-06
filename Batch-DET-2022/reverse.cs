using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_DET_2022
{
    internal class reverse
    {
        static void Sample_Reverse_Lambda()
        {
            char[] characters = { 's', 'a', 'm', 'p', 'l', 'e' };

            var result = characters.Reverse();

            Debug.WriteLine("Characters in reverse order:");
            foreach (char character in result)
                Debug.WriteLine(character);
        }
    }
}
