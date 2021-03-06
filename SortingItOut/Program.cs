﻿using System;

namespace Sorting_It_Out_Template
{
    class RndArray
    {
        private const int _maxSize = 50;
        private int[] _arrayOfNumbers = new int[_maxSize];
        private int _count;
        private Random rand;

        public RndArray()
        {
            _count = 0;
            for (int i = 0; i < _maxSize; i++)
            {
                _arrayOfNumbers[i] = -1;
            }
            rand = new Random();
        }

        public int MaxSize
        {
            get
            {
                return _maxSize;
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        /* createRnd - Fill array with random numbers 
         *    input: size - numbers of cells to populate
         *           max - generate random number maximum value
         *    output: number of cells populated
         */
        public int createRnd(int size, int max)
        {
            int temp;

            if (size > _maxSize)
                temp = _maxSize;
            else
                temp = size;

            for (int i = 0; i < temp; i++)
            {
                _arrayOfNumbers[i] = rand.Next(max);
            }
            _count = temp;

            return temp;
        }

        /* printCells - Print populated cells of array
         *    input: none
         *    output: none
         */
        public void printCells()
        {
            int iTemp = _count / 10;
            int jTemp = _count % 10;
            int temp = 0;

            for (int i = 0; i < iTemp; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("{0,4:D} ", _arrayOfNumbers[temp++]);
                }
                Console.WriteLine();
            }
            if (jTemp > 0)
            {
                for (int j = 0; j < jTemp; j++)
                {
                    Console.Write("{0,4:D} ", _arrayOfNumbers[temp++]);
                }
                Console.WriteLine();
            }
        }

        public void bubbleSort()
        {
            Console.WriteLine("**Bubble Sort goes here**");
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            RndArray numList = new RndArray();
            int size;

            size = numList.createRnd(10, 100);
            Console.WriteLine("Created List of {0} items", size);
            numList.printCells();
            numList.bubbleSort();
            Console.WriteLine("Bubble Sorted:");
            numList.printCells();

            Console.WriteLine("Hit any key to exit.");
            Console.ReadKey();

        }
    }
}
