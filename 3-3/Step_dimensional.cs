using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    sealed class Step_dimensional : Dad_class, IStepDim
    {
        private int[][] array;
        static private Random rnd = new Random();

        public Step_dimensional(bool person, int width)
        {
            Initialization(person, width);
        }
        private void Initialization(bool person, int width)
        {

            array = new int[width][];
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
                Console.WriteLine("Write length of the line:");
                int length = int.Parse(Console.ReadLine());
                array[i] = new int[length];
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    Console.WriteLine($"X: {j} Y: {i}");
                    int num = int.Parse(Console.ReadLine());
                    array[i][j] = num;
                }

            }



        }
        public override void rndFill()
        {


            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Write length of the line:");
                int length = int.Parse(Console.ReadLine());
                array[i] = new int[length];
                for (int j = 0; j < length; j++)
                    array[i][j] = rnd.Next(-100, 100);
            }


        }
        public void third()
        {
            Console.WriteLine("new array:");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {


                    if (array[i][j] % 2 == 0)
                    {
                        array[i][j] = i * j;
                        Console.Write(array[i][j] + "\t");
                    }
                    else
                    {
                        Console.Write(array[i][j] + "\t");
                    }
                }
                Console.WriteLine();
            }
        }
        public override void getmid()
        {
            int line_num = 0;
            int array_num = 0;
            int sum_num = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum_num += array[i][j];
                    array_num += 1;
                    line_num += array[i][j];
                }
                Console.WriteLine($"mid num of the line {i}:");
                Console.WriteLine(line_num / array[i].Length);
                line_num = 0;
            }
            Console.WriteLine($"mid num of the array:");
            Console.WriteLine(sum_num / array_num);
        }
        public void recreation(bool person, int width)
        {
            Initialization(person, width);
        }
        public override void print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {

                    Console.Write(array[i][j] + "\t");
                }
            }
        }
    }
}
