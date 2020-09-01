using System;

namespace Week2_Examples
{
    class Program
    {
        public const int MAX_SPEED = 65; // naming const.

        static void Main(string[] args)
        {
            // Commenting
            // for commenting line
            // /* ...... */ commenting multiple lines
            // /// documentation


            // declaring a variable
            //int x;
            // naming should never start with digits: int 1x
            // name with multiple words -> use camel casing
            //int bigBonus; // underscores are allowed but hyphens are not
            // c# is case sensitive
            // rate Rate RATE are all different variables
            // be mindful of using keywords as variable names


            // Data Types
            // know each memory type and how much memory they take
            //byte      1
            //short     2
            //int       4
            //long      8
            //sbyte     1
            //ushort    2
            //uint      4
            //ulong     8
            //char      2
            //float     4
            //double    8
            //decimal   16
            //bool      true, false

            /*
            //short test = 32768; //you are off by one
            char favoriteLetter = 'c';
            favoriteLetter = '&';
            Console.WriteLine(favoriteLetter);
            int num = 5;
            */

            // Assignment Statement
            //int area;
            //int length = 5;
            //area = length * length;
            //area = length * 8;

            // Assignment Compatibility
            //int x = 2.99; // this is wrong -> you need a double initializer

            // Constants
            // between the class and the main method 
            // public const int MAX_SPEED = 65; // naming const.

            // Precedence Rules
            // base + rate = hours = base + (rate * hours)
            // always add parenthesis
            //int result1 = 2 + 3 * 4;
            //int result2 = (2 + 3) * 4;
            //Console.WriteLine(result1);
            //Console.WriteLine(result2);

            // Additional Operators
            // we have +, -, * and /
            // we also have %
            // this operator computes the remainder from division
            //int result = 7 % 5; // is equal to 2
            //Console.WriteLine(result);
            // 1 % 5 would be equal to 1

            // Increment and Decrement
            /*
            int num = 5;
            ++num;
            Console.WriteLine("num is: " + num);

            // 2nd Example
            int n1 = 2;
            int valueProduced = 2 * (++n1);
            Console.WriteLine("valueProduced is: " + valueProduced);
            Console.WriteLine(n1);

            // 3rd Example
            int m1 = 2;
            int valueProduced2 = 2 * (m1++);
            Console.WriteLine("valueProduced2 is: " + valueProduced2);
            Console.WriteLine(m1);
            */

            // User Input
            // Console.ReadLine(); // reads text, make sure to convert, Int32.Parse

            /*
            // Type Casting
            int n = 9, m = 2;
            double ans = n / m;
            Console.WriteLine(ans); // this gives 4
            ans = n / (double) m;
            Console.WriteLine(ans); // this gives 4.5

            // String Class
            String name = "stephanie zacharias";
            Console.WriteLine(name.ToUpper());

            String a = "Hello";
            int b = a.IndexOf('o');
            Console.WriteLine(b);


            // Insert
            String x = "Hello";
            String y = x.Insert(2, "_World_");
            Console.WriteLine(y);

            // Substring
            String w = "Hello";
            String q = w.Substring(2);
            Console.WriteLine(q);
            */





        }
}
}
