using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase2
{
    class AverageHeight
    {
        public static void Display()
        {
            try
            {
                double average;
                Console.WriteLine("Enter The Person Count:");
                var PersonCount = int.Parse(Console.ReadLine());
                double[] height = new double[PersonCount];
                string[] Persons = new string[PersonCount];
                for (int i = 0; i < Persons.Length; i++)
                {
                    Console.WriteLine("Enter The Name:");
                    Persons[i] = Console.ReadLine();
                    Console.WriteLine("Enter The Height:");
                    height[i] = Convert.ToDouble(Console.ReadLine());
                }
                double sum = height.Sum();
                Console.WriteLine("Sum of all Person Heigth " + "" + sum);
                average = sum / height.Length;
                Console.WriteLine("Average Heigth of all Person:" + average);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Please Enter Matching Input");
                Display();
            }
        }
    }




}






