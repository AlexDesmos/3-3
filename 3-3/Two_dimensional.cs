using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    sealed class Two_dimensional : Dad_class, ITwoDim
    {
        int[,] array;
        Random rnd = new Random();
        public Two_dimensional(bool person, int length, int width)
        {
            Initialization(person, length, width);
        }
        private void Initialization(bool person, int length, int width)
        {
            array = new int[length, width];

            if (person)
                userFill();
            else
                rndFill();
            getmid();
            print();
        }
        public override void userFill()
        {


            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine($"X: {j} Y: {i}");
                    int input = int.Parse(Console.ReadLine());
                    array[i, j] = input;

                }
            }


        }
        public override void rndFill()
        {


            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    array[i, j] = rnd.Next(-100, 100);

                }
            }


        }
        public void second()
        {
            Console.WriteLine("Second:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i + 1 % 2 == 0)
                {


                    for (int j = array.GetLength(1) - 1; j > 0; j--)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
        public override void getmid()
        {
            int array_sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array_sum += array[i, j];
                }
            }
            Console.WriteLine("Mid num of your array:");
            Console.WriteLine(array_sum / (array.GetLength(0) * array.GetLength(1)));
        }
        public void recreation(bool person, int length, int width)
        {
            Initialization(person, length, width);
        }
        public override void print()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    Console.Write(array[i, j] + "\t");
                }
            }
        }
    }
}
