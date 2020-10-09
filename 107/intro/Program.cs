using System;
using System.Collections.Generic;

namespace intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string name = "Duane";
            int age = 34;
            float average = 38.23f;
            decimal price = 99.98m;
            bool found = false; // true

            Console.WriteLine(name);
            Console.WriteLine(age);


            Program p = new Program();
            p.Test();
            p.TestMath();

            bool res1 = p.IsItEven(33);
            System.Console.WriteLine(res1);

            decimal a = p.GetLargest(34m, 786m);
            System.Console.WriteLine(a);

            bool isIt = p.IsItPrime(11);
            System.Console.WriteLine(isIt);
        }

        int Test()
        {
            System.Console.WriteLine("Hello from a method");
            int age = 34;

            if(age < 98) {
                System.Console.WriteLine("You are still young, don't worry");
            }
            else{
                System.Console.WriteLine("Ouch, kind of getting old, sorry");
            }
            SayHello("Duane");
            return 1;
        }
        void SayHello(string name)
        {
            System.Console.WriteLine("Hello: " + name);


            for(int i=0; i<13; i++)
            {
                if(i != 3 && i != 7)
                {
                 System.Console.WriteLine(i); 
                }
            }

            // array
            string[] names = new string[20];
            names[0] = "Nick";
            names[1] = "Duane";
            names[2] = "Andrew";

            // list
            List<string> students = new List<string>();
            students.Add("Jesus");
            students.Add("Matthew");

            for(int i=0; i < students.Count; i++){
                System.Console.WriteLine(students[i]);
            }

            foreach(string person in students) {
                System.Console.WriteLine(person);
            }
        }
    
        void TestMath()
        {
            System.Console.WriteLine(21 + 21);
            System.Console.WriteLine(21 - 21);
            System.Console.WriteLine(21 * 21);
            System.Console.WriteLine(21 / 21);

            System.Console.WriteLine(21 % 21); // mod (modulus operator)
        }

        bool IsItEven(int num)
        {
            int res = num % 2;
            return res == 0;
        }

        decimal GetLargest(decimal num1, decimal num2)
        {
            if(num1 < num2) return num2;
            else return num1;
        }
    
        bool IsItPrime(float num)
        {
            for(int i=2; i<num; i++)
                if(num %i ==0)
            return false;
            return true;
        }
    }
}