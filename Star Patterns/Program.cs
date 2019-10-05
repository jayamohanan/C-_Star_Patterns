using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Patterns
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.BuildAll(10);
            Console.ReadLine();
        }
        private void DimondPattern()
        {
            int time = 2;
            for (int i = 1; i < 12 && i >= 1; i += time)
            {
                int half = (11 - Math.Abs(i)) / 2;
                Console.WriteLine((new String('*', i)).PadLeft(i + half).PadRight(i + 2 * half));
                if (i == 11)
                    time *= -1;
            }
            
        }

        private void TriangleRightOfA(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.WriteLine(new String('*', i));
            }
        }
        private void TriangleLeftOfA(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.WriteLine(new String('*', i).PadLeft(size));
            }
        }

        private void TriangleRightOfV(int size)
        {
            for (int i = size; i >= 1; i--)
            {
                Console.WriteLine(new String('*', i));
            }
        }
        private void TriangleLeftOfV(int size)
        {
            for (int i = size; i >= 1; i--)
            {
                Console.WriteLine(new String('*', i).PadLeft(size));
            }
        }

        private void TriangleRightOfAWithSpaceInBetween(int size)
        {
            string whiteSpace = " ";

            for (int i = 1; i <= size; i++)
            {

                Console.WriteLine(whiteSpace.PadLeft(i+1, '*').PadRight(2*i+1, '*'));
            }
        }
        private void BuildRectangle(int length, int width)
        {
            int internalWidth = width - 2;
            int widthMinusOne = width - 1;
            for (int i = 1; i <= length; i++)
            {
                if(i==1 || i== length)
                {
                    Console.WriteLine(new String('*', width));
                }
                else
                {
                    Console.WriteLine(new String('*', 1).PadRight(widthMinusOne).PadRight(width, '*'));
                }
                Console.WriteLine();
            }
        }
        private void BuildAll(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.WriteLine(new String('*',i).PadRight(size)+new String('*', size-i+1).PadRight(size)+ new String('*', size - i + 1).PadLeft(size)+ new String('*', i).PadLeft(size));
            }
        }

    }
}
