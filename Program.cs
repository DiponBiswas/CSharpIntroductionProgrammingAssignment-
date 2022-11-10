using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Circle();

            //Swapping();

            //Sum();
            
            //Topper();
            
            //Console.WriteLine("Enter two numbers");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Output----------");
            //Calculator calculator = new Calculator();
            //calculator.Add(a, b);
            //calculator.Substract(a, b);
            //calculator.Multiply(a, b);
            //calculator.Divide(a, b);
        }



        public static void Circle()
        {
            Console.WriteLine("Enter the radius");
            int rad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Area of Circle : {0}", Math.PI * rad * rad);
            Console.WriteLine("Circumference of Circle : {0}", 2*Math.PI * rad);
        }

        public static void Swapping()
        {
            Console.WriteLine("Enter 2 integers");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());

            int c = a1;
            a1 = a2;
            a2 = c;

            Console.WriteLine("After swapping the integers are : {0} , {1}", a1, a2);
        }

        public static void Sum()
        {
            Console.WriteLine("Enter number of integers");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            int[] param = new int[n];
            Console.WriteLine("Enter {0} integers", n);
            for (int i = 0; i < param.Length; i++)
            {
                param[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < param.Length; i++)
            {
                s = s + param[i];
            }
            Console.WriteLine("Sum of all integers : {0}", s);
        }

        public static void Topper()
        {
            Console.WriteLine("Enter average marks of 5 students");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int a3 = Convert.ToInt32(Console.ReadLine());
            int a4 = Convert.ToInt32(Console.ReadLine());
            int a5 = Convert.ToInt32(Console.ReadLine());

            int[] marks = new int[] { a1, a2, a3, a4, a5 };
            int max = 0;
            for (int i = 0; i < 5; i++)
            {
                if (marks[i] > max)
                    max = marks[i];
            }

            Console.WriteLine("Highest Marks : {0}", max);
        }

    }

    
    class Calculator
    {
        public void Add(int a,int b)
        {
            Console.WriteLine("Addition : {0}", a + b);
        }
        public void Substract(int a,int b)
        {
            Console.WriteLine("Substraction : {0}", Math.Abs(a - b));
        }
        public void Multiply(int a,int b)
        {
            Console.WriteLine("Multiplication : {0}", a* b);
        }
        public void Divide(int a,int b)
        {
            double div=0;
            try
            {
                div =  a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Division : {0}", div);
        }
    }

}
