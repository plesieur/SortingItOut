using System;

namespace Sorting_It_Out_Template
{
    class RndArray
    {
        private const int _maxSize = 50;
        private int[] _arrayOfNumbers = new int[_maxSize];  //Array to sort
        private int[] _arrayOriginal = new int[_maxSize];   //Do NOT touch this array
        private int _count;
        private Random rand;

        public RndArray()
        {
            _count = 0;
            for (int i = 0; i < _maxSize; i++)
            {
                _arrayOfNumbers[i] = -1;
                _arrayOriginal[i] = -1;
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

        //Set _arrayOfNumbers to original and prepare to sort 
        public void refreshList()
        {
            for (int i = 0; i < _maxSize; i++)
            {
                _arrayOfNumbers[i] = _arrayOriginal[i];
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
                _arrayOriginal[i] = rand.Next(max);
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
            // Sort _arrayOfNumbers[] using a Bubble Sort
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
            numList.refreshList();
            numList.printCells();
            numList.bubbleSort();
            Console.WriteLine("Bubble Sorted:");
            numList.printCells();

            Console.WriteLine("Hit any key to exit.");
            Console.ReadKey();

        }
    }
}
