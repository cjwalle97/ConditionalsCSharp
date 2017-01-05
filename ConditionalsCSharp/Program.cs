using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsCSharp
{
    class Program
    {
        //2.
        int ReturnLarger(int a, int b)
        {
            int Largest = 0;
            if(a>b)
            {
                Largest = a;
            }
            if(a<b)
            {
                Largest = b;
            }
            return Largest;
        }

        //3. 
        int order(int a, int b, int c, int d, int e)
        {
            int total = a + b + c + d + e;
            if(total > 0)
            {

            }
        }
        static void Main(string[] args)
        {
            //1.
            int y = 0;
            int x = 0;
            if (y == 0)
            {
                x = 100;
            }

        }
    }
}