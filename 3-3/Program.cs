using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write 'true' if you want to make array by yourself, 'false' if random:");
            bool person = bool.Parse(Console.ReadLine());
            

                Console.WriteLine("Write length of your array:");
                int one_length = int.Parse(Console.ReadLine());

                One_dimensional one_dimensional = new One_dimensional(person, one_length);


                
                one_dimensional.third();

                Console.WriteLine("Write length of your array:");
                one_length = int.Parse(Console.ReadLine());
                one_dimensional.recreation(person, one_length);

            
  
            
            Console.WriteLine("Write length of your array:");
            int two_length = int.Parse(Console.ReadLine());
            Console.WriteLine("Write width of your array:");
            int two_width = int.Parse(Console.ReadLine());
            Two_dimensional two_dimensional = new Two_dimensional(person, two_length, two_width);
            two_dimensional.second();
            Console.WriteLine("Write length of your array:");
            two_length = int.Parse(Console.ReadLine());
            Console.WriteLine("Write width of your array:");
            two_width = int.Parse(Console.ReadLine());
            two_dimensional.recreation(person, two_length, two_width);
            
            
            Console.WriteLine("Write width of your array:");
            int step_width = int.Parse(Console.ReadLine());
            Step_dimensional step_dimensional = new Step_dimensional(person, step_width);
            step_dimensional.third();
            Console.WriteLine("Write width of your array:");
            step_width = int.Parse(Console.ReadLine());
            step_dimensional.recreation(person, step_width);
            
            IPrinter[] mass = new IPrinter[4];
            IBaseInterface[] mass1 = new IBaseInterface[3];
            mass[0] = one_dimensional;
            mass1[0] = one_dimensional;
            mass[1] = two_dimensional;
            mass1[1] = two_dimensional;
            mass[2] = step_dimensional;
            mass1[2] = step_dimensional;
            mass[3] =new Week();
            for (int i = 0; i < mass.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Весь массив одномерных");
                }
                mass[i].print();
            }
            for (int i = 0; i < mass1.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Среднее значение одномерных");
                }
                mass1[i].getmid();
            }
        }
    }
}
