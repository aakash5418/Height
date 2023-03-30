using System;
using System.Linq;
using System.Data;


namespace averageHeight
{
    class Program
    {
        public static void Main()
        {
            // avg();
            method();
        }
        public static void avg()
        {
            int averageHeight;
            Console.WriteLine("ENTER THE PERSON COUNT:");
            int PersonCount = Convert.ToInt16(Console.ReadLine());
            int[] Height = new int[PersonCount];
            string[] Persons = new string[PersonCount];
            string per1;
            int height1;
            while (PersonCount > 0)
                for (int i = 0; i < PersonCount; i++)
                {
                    Console.WriteLine("ENTER THE NAME:");
                    per1 = Persons[i] = Console.ReadLine();
                    Console.WriteLine("ENTER THE HEIGHT:");
                    height1 = Height[i] = Convert.ToInt16(Console.ReadLine());

                }
            averageHeight = Height[1] / PersonCount;
            Console.WriteLine("average height is" + "" + averageHeight);


            // double average = Height.Average(item => item.Height);
            // Console.WriteLine(average);
        }
        public static void method()
        {
            try
            {
                double average;
                Console.WriteLine("ENTER THE PERSON COUNT:");
                var PersonCount = int.Parse(Console.ReadLine());
                double[] height = new double[PersonCount];
                string[] Persons = new string[PersonCount];
                for (int i = 0; i < Persons.Length; i++)
                {
                    Console.WriteLine("ENTER THE NAME:");
                    Persons[i] = Console.ReadLine();
                    Console.WriteLine("ENTER THE HEIGHT:");
                    height[i] = Convert.ToDouble(Console.ReadLine());
                }
                double sum = height.Sum();
                Console.WriteLine("sum of all person heigth " + "" + sum);
                average = sum / height.Length;
                Console.WriteLine("Average heigth of all person:" + average);
            }
            catch(Exception ex)
            {
                Console.WriteLine("invalid please enter matching input");
                method();
            }
        }
    }




}