using System;

namespace Section_02_Assignment
{
    class Program
    {
        static void Main()
        {
            Compare2Numbers();
            Compare4Numbers();
            Factorial();
        }


        public static void Compare2Numbers()
        {
            Console.WriteLine("Please enter two numbers to find out the biggest:\n");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("The number {0} is bigger than the number {1}.", a, b);
            }

            else if (b > a)
            {
                Console.WriteLine("The number {0} is bigger than the number {1}.", b, a);
            }

            Console.ReadKey();
        }


        public static void Compare4Numbers()
        {
            Console.WriteLine("\nPlease enter four numbers to find out the biggest:\n");
   
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            if (a > b || a > c || a > d) 
            {
                Console.WriteLine("The biggest number is {0}\n", a);
            }

            else if (b > a || b > c || b > d)
            {
                Console.WriteLine("The biggest number is {0}\n", b);
            }

            else if (c > a || c > b || c > d)
            {
                Console.WriteLine("The biggest number is {0}\n", c);
            }

            else if (d > a || d > b || d > c)
            {
                Console.WriteLine("The biggest number is {0}\n", d);
            }            

                Console.ReadKey();
        }
        

        public static void Factorial()
        {

            Console.WriteLine("Please enter a number to calculate it's factorial:");
            int num;
            int n;
            
            num = int.Parse(Console.ReadLine());
            n = num;

            for (int i = n - 1; i > 0; i--)
            {
                n *= i;
            }
                
            Console.WriteLine("The factorial of number {0} is: {1}", num, n);

            Console.ReadKey();
        }
        
    }
}
