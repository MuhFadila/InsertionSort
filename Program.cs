using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsertionSort
{
    class Program
    {
        static public void InsertionSorting()
        {
            Console.Write("\nProgram for sorting a numeric array using Insertion Sorting");
            Console.Write("\n\nEnter number of elements: ");
            int max = Convert.ToInt32(Console.ReadLine());
            int[] numarray = new int[30];
            for (int i = 0; i < max; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                numarray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Input int array   :   ");
            for (int k = 0; k < max; k++)
                Console.Write(numarray[k] + " ");
            Console.Write("\n");
            for (int i = 1; i < max; i++)
            {
                int MF = i;
                while (MF > 0)
                {
                    if (numarray[MF - 1] > numarray[MF])
                    {
                        int temp = numarray[MF - 1];
                        numarray[MF - 1] = numarray[MF];
                        numarray[MF] = temp;
                        MF--;
                    }
                }
            }
        }   
    }
}

