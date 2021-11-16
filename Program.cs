using System;
using System.Collections.Generic;

namespace Planeـpassengers
{
    class Program
    {


        static void Main(string[] args)
        {
            List<mosaferan> listms = new list<mosaferan>();

            for (int i = 1; i < 5; i++)
            {
                mosaferan ms = new mosaferan();

                System.Console.WriteLine($"Please enter name {i} :");
                ms.name = Console.ReadLine();

                System.Console.WriteLine($"please enter {ms.name} lastname :");
                ms.lastname = (Console.ReadLine());

                System.Console.WriteLine($"please enter {ms.name} {ms.lastname} gensiat :");
                ms.gensiat = Console.ReadLine();


                System.Console.WriteLine($"please enter {ms.name} {ms.lastname} age :");
                ms.age = int.Parse(Console.ReadLine());

                listms.Add(ms);
            }


            foreach (var item in listms)
            {
                System.Console.WriteLine(item.name);
                System.Console.WriteLine(item.lastname);
                System.Console.WriteLine(item.gensiat);
                System.Console.WriteLine(item.age);
                System.Console.WriteLine("*****************");
            }
            int max = int.MinValue;
            foreach (var item in listms)
            {
                if (item.gensiat == "mard")
                {
                    if (item.age > max)
                    {
                        max = item.age;
                    }
                    else
                    {
                        System.Console.WriteLine("Error mard");
                    }
                }
            }
            System.Console.WriteLine("*****************");
            System.Console.WriteLine("The Max Age Mardan : " + max);
            System.Console.WriteLine("*****************");
            int max1 = int.MinValue;
            foreach (var item in listms)
            {
                if (item.gensiat == "zan")
                {
                    if (item.age > max1)
                    {
                        max1 = item.age;
                    }
                }

            }
            System.Console.WriteLine("*****************");
            System.Console.WriteLine("The Max Age zanan : " + max1);
            System.Console.WriteLine("*****************");
        }
    }

    class mosaferan
    {
        public string name;
        public string lastname;
        public string gensiat;
        public int age;

        // public int check_maxAge { get{return age;} 
        // set{
        //     if (genist)
        //     {

        //     }


        // ;} 
        // }





    }
}
