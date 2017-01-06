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
            if (a > b)
            {
                Largest = a;
            }
            if (a < b)
            {
                Largest = b;
            }
            return Largest;
        }

        //3. 
        void order(int a, int b, int c, int d, int e)
        {
            int Highest = 0;
            int High = 0;
            int Middle = 0;
            int Low = 0;
            int Lowest = 0;
            int temp = 0;
            List<int> Numbers = new List<int>();
            Numbers.Add(a);
            Numbers.Add(b);
            Numbers.Add(c);
            Numbers.Add(d);
            Numbers.Add(e);
            for (int i = 0; i < 5; i++)
            {
                if (Numbers[i] > Highest)
                {
                    temp = Highest;
                    Highest = Numbers[i];
                    High = temp;
                }
                if (Numbers[i] > High && Numbers[i] < Highest)
                {
                    temp = High;
                    High = Numbers[i];
                    Middle = temp;
                }
                if (Numbers[i] > Middle && Numbers[i] < High)
                {
                    temp = Middle;
                    Middle = Numbers[i];
                    Low = temp;
                }
                if (Numbers[i] > Low && Numbers[i] < Middle)
                {
                    temp = Low;
                    Low = Numbers[i];
                    Lowest = temp;
                }
                else
                {
                    Lowest = Numbers[i];
                }
            }
            int total = a + b + c + d + e;
            if (total > 0)
            {
                Console.WriteLine(Lowest);
                Console.WriteLine(Low);
                Console.WriteLine(Middle);
                Console.WriteLine(High);
                Console.WriteLine(Highest);
            }
            if (total < 0)
            {
                Console.WriteLine(Highest);
                Console.WriteLine(High);
                Console.WriteLine(Middle);
                Console.WriteLine(Low);
                Console.WriteLine(Lowest);
            }
            if (total == 0)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(d);
                Console.WriteLine(e);
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

            //4.
            int choice = 2;
            switch (choice)
            {
                case 1:
                    Console.WriteLine(1);
                    break;
                case 2:
                    Console.WriteLine(2);
                    break;
                case 3:
                    Console.WriteLine(3);
                    break;
                case 4:
                    Console.WriteLine(4);
                    break;
            }

            //5.
            y = (x == 0) ? 0 : 10 / x;

            //6.
            int a = 5;
            int b = 2;
            int result = 0;
            char sign = '+';
            switch (sign)
            {
                case '+':
                    result = a + b;
                    break;

                case '-':
                    result = a - b;
                    break;

                case '*':
                    result = a * b;
                    break;

                case '/':
                    result = a / b;
                    break;

                case '%':
                    result = a % b;
                    break;
            }

            //7.
            int month = 2;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine(31);
                    break;
                case 2:
                    Console.WriteLine(28);
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine(30);
                    break;                  
            }
        }
        }
    }