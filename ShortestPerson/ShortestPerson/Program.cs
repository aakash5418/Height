using System;

namespace shortestPerson
{
    class Program
    {
        public static void Main()
        {
            try
            {
                int numericValue;
                double height1 = 0;

                double height2 = 0, height3;
                string person1;
                Console.WriteLine("enter the name: ");
                person1 = Console.ReadLine();
                bool isNumber = int.TryParse(person1, out numericValue);
                if (isNumber)
                {
                    Console.WriteLine("Please Enter only letters");
                    Main();
                }
                else
                {
                    Console.WriteLine("enter the height: " + person1);
                    height1 = Convert.ToDouble(Console.ReadLine());
                }


                string person2;
                Console.WriteLine("enter the name: ");
                person2 = Console.ReadLine();
                bool isNumber1 = int.TryParse(person2, out numericValue);
                if (isNumber)
                {
                    Console.WriteLine("Please Enter only letters");
                    Main();
                }
                Console.WriteLine("enter the height: " + person2);
                height2 = Convert.ToDouble(Console.ReadLine());

                string person3;
                Console.WriteLine("enter the name: ");
                person3 = Console.ReadLine();
                bool isNumber2 = int.TryParse(person3, out numericValue);
                if (isNumber)
                {
                    Console.WriteLine("Please Enter only letters");
                    Main();
                }
                Console.WriteLine("enter the height: " + person3);
                height3 = Convert.ToDouble(Console.ReadLine());

                if (height1 < height2 && height1 < height3)
                {
                    Console.WriteLine(person1 + " " + "is a shortest person");

                }
                else if (height2 < height3 && height2 < height1)
                {
                    Console.WriteLine(person2 + " " + "is a shortest person");
                }
                else if (height3 < height1 && height3 < height2)
                {
                    Console.WriteLine(person3 + " " + "is a shortest person");
                }
                else
                {
                    Console.WriteLine("invalid height");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("please enter valid input");
                Main();
            }


        }



    }
}



