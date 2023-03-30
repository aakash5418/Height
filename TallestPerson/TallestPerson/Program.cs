using System;
using TallestPerson;

namespace tallestPerson
{
    class Program
    {
        public static void Main()
        {
           lstaverage();
           // Persons();
            //checkingif();
        }
        public static void Persons()
        {
            int numericValue = 0;
            Persons per1 = new Persons();
            Console.WriteLine("enter your name");
            per1.Name = Console.ReadLine();
            bool isNumber = int.TryParse(per1.Name, out numericValue);
            if (isNumber)
            {
                Console.WriteLine("Please Enter only letters");
                Main();
            }
            else
            {
                Console.WriteLine("enter your height");
                per1.Height = Convert.ToInt16(Console.ReadLine());
            }

            Persons per2 = new Persons();
            Console.WriteLine("enter your name");
            per2.Name = Console.ReadLine();
            bool isNumber1 = int.TryParse(per2.Name, out numericValue);
            if (isNumber)
            {
                Console.WriteLine("Please Enter only letters");
                Main();
            }
            else
            {
                Console.WriteLine("enter your height");
                per1.Height = Convert.ToInt16(Console.ReadLine());
            }

            List<Persons> lstpersons = new List<Persons>();
            lstpersons.Add(per1);
            lstpersons.Add(per2);
            for(int i = 0;i<lstpersons.Count;i++)
            {
                if (per1.Height < per2.Height)

                {
                    Console.WriteLine(per2.Name + " is a tallest person");

                }
                else if (per2.Height < per1.Height)
                {
                    Console.WriteLine(per1.Name + " is a tallest  person");

                }
                else
                {
                    Console.WriteLine("both are equal please insert your enteries");
                }
            }



            foreach (Persons person in lstpersons)
            {
                Console.WriteLine(person.Name + "" + person.Height);
            }

            if (per1.Height < per2.Height)

            {
                Console.WriteLine(per2.Name + " is a tallest person");

            }
            else if (per2.Height < per1.Height)
            {
                Console.WriteLine(per1.Name + " is a tallest  person");

            }
            else
            {
                Console.WriteLine("both are equal please insert your enteries");
            }
        }
        public static void lstaverage()
        {
            Console.WriteLine("ENTER THE PERSON COUNT:");
            int personCount = Convert.ToInt16(Console.ReadLine());
            var list = new List<Persons>();
            List<double> lstHeight = new List<double>();
            var person = new Persons();
            while (list.Count < personCount)
            {
                int numericValue;
                Console.WriteLine("Please Enter Your Name");
                person.Name = Console.ReadLine();
                bool isNumber = int.TryParse(person.Name, out numericValue);
                if (isNumber)
                {
                    Console.WriteLine("Please Enter only letters");
                    Main();
                }
                Console.WriteLine("Please Enter Your Height");
                person.Height = Convert.ToDouble(Console.ReadLine());
                list.Add(person);
                lstHeight.Add(person.Height);
            }
            
            for (int i = 0;i<= personCount;i++)
            {                
                if (lstHeight[i] > lstHeight[i+1])
                {
                    Console.WriteLine(lstHeight[i + 1] + "is a tallest person");
                }
                else
                {
                    Console.WriteLine(lstHeight[i] + "is a tallest person");
                }
            }
           // double average = lstHeight.Average();
          //  Console.WriteLine("average value is " + average);
            /* for(int i=0; i<list.Count;i++)
             {
                 for (int j = 1; j < lstheight.Count; j++)
                 {
                     if (list[i].Height < lstheight[j] || lstheight[j] > list[i].Height)
                     {
                         int hght = list[i].Height < lstheight[j] ? list[i].Height: list[i].Height > lstheight[j] ? list[i].Height : 0;
                         Console.WriteLine(hght + "is a tallest person");
                     }
                 }
             }



            // double average = list.Average(item => item.Height);
             //var nearest = list.MinBy(x => x.Height - average);
             //Console.WriteLine(nearest);
             //foreach(var lst in list)
             //{
             //    Console.WriteLine(lst.Name +" "+lst.Height);
             //}
         }

         public static void checkingif()
         {
             int averageHeight;
             Console.WriteLine("ENTER THE PERSON COUNT:");
             int PersonCount = Convert.ToInt16(Console.ReadLine());
             int[] Height = new int[PersonCount];
             string[] Persons = new string[PersonCount];
             List<int> lstheight = new List<int>();
             for (int i = 0; i < PersonCount; i++)
             {
                 Console.WriteLine("ENTER THE NAME:");
                 Persons[i] = Console.ReadLine();
                 Console.WriteLine("ENTER THE HEIGHT:");
                 Height[i] = Convert.ToInt16(Console.ReadLine());
                 lstheight.Add(Height[i]);
             }
         }*/

        }
    }
    
}