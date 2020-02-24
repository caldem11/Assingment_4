using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_4
{
    class Controler
    {
        public void control()
        {
            foreach (int n in EvenSequence(1, 64))
            {
                Console.Write(n.ToString() + " ");
            }
            Console.ReadKey();
        }
        public static IEnumerable<int>
             EvenSequence(int fNumber, int lNumber)
        {
            
            for (int num = fNumber; num <= lNumber; num++)
            {
                if (num % 2 == 0)
                {
                    yield return num;
                }
            }
        }
    }
}
