using System;
using System.Collections.Generic;
using System.Linq;

namespace WizeTest3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 9 };
            int[] reverse = array;
            Array.Reverse(reverse);
            int sum = 1;

            List<int> arrayten = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                arrayten.Add(reverse[i]* xtimesten(i));
            }

            foreach (int i in arrayten)
            {
                sum += i;
            }

            int[] result = GetIntArray(sum);

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }

        static int xtimesten(int k)
        {
            int ten = 1;
            for (int i = 0; i < k; i++)
            {
                ten *= 10;
            }
            return ten;
        }

        static int[] GetIntArray(int num)
        {
            List<int> listOfInts = new List<int>();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }
            listOfInts.Reverse();
            return listOfInts.ToArray();
        }
    }
}
