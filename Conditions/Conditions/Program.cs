using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task 1
            // 1.User gives 2 numbers a and b. If a>b then output a+b, if a=b then output a*b, if a<b then a-b.
            //Console.WriteLine("Enter a,b: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //if(a>b)
            //{
            //    Console.WriteLine(a+b);
            //}
            //else if(a==b)
            //{
            //    Console.WriteLine(a*b);
            //}
            //else
            //{
            //    Console.WriteLine(a - b);
            //}
            #endregion
            #region Task 2
            //2.User gives 2 numbers x and y. Find out coordinate quarter of point with location (x,y).
            //Console.WriteLine("Enter x, y: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());
            //if(x > 0 && y > 0)
            //{
            //    Console.WriteLine("1'st quarter");
            //}
            //else if(x < 0 && y > 0)
            //{
            //    Console.WriteLine("2'nd quarter");
            //}
            //else if(x < 0 && y < 0)
            //{
            //    Console.WriteLine("3'rd quarter");
            //}
            //else
            //{
            //    Console.WriteLine("4'th quarter");
            //}
            #endregion
            #region Task 3
            //3.User gives 3 numbers a, b, c. Output them in the ascending order. 
            //Console.WriteLine("Enter a, b, c: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //if(a>=b && a>=c)
            //{
            //    if(b>c)
            //    {
            //        Console.WriteLine($"{c} {b} {a}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{b} {c} {a}");
            //    }
            //}
            //else if (b >= a && b >= c)
            //{
            //    if (a > c)
            //    {
            //        Console.WriteLine($"{c} {a} {b}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{a} {c} {b}");
            //    }
            //}
            //else if (c >= a && c >= b)
            //{
            //    if(b>a)
            //    {
            //        Console.WriteLine($"{a} {b} {c}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{b} {a} {c}");
            //    }
            //}

            #endregion
            #region Task 4
            //4.User gives 3 numbers a, b, c. Find out solution of quadratic equation ax^2+bx+c=0. 
            //Console.WriteLine("Please enter a, b, c: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //double D = Math.Pow(b, 2) - 4 * a * c;
            //double x1 = (-1 * b + Math.Sqrt(D)) / 2 * a;
            //double x2 = (-1 * b - Math.Sqrt(D)) / 2 * a;
            //Console.WriteLine($"Roots are: x1 -> {x1}, x2 -> {x2}");
            #endregion
            #region Task 5 
            // 5.User gives 2-digit number. Output the world according to this number. F.e. : 13 – thirteen, 25 – twenty five and so on.
            //Console.WriteLine("Enter 2 digit number: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //if(n>=10 && n<=19)
            //{
            //    switch (n)
            //    {
            //        case 10:
            //            Console.WriteLine("ten");
            //            break;
            //        case 11:
            //            Console.WriteLine("eleven");
            //            break;
            //        case 12:
            //            Console.WriteLine("twelve");
            //            break;
            //        case 13:
            //            Console.WriteLine("thirteen");
            //            break;
            //        case 14:
            //            Console.WriteLine("fourteen");
            //            break;
            //        case 15:
            //            Console.WriteLine("fifteen");
            //            break;
            //        case 16:
            //            Console.WriteLine("sixteen");
            //            break;
            //        case 17:
            //            Console.WriteLine("seventeen");
            //            break;
            //        case 18:
            //            Console.WriteLine("eighteen");
            //            break;
            //        case 19:
            //            Console.WriteLine("nineteen");
            //            break;
            //    }
            //}

            //else
            //{
            //    int a = n / 10;
            //    int b = n % 10;
            //    switch(a)
            //    {
            //        case 2:
            //            Console.Write("Twenty");
            //            break;
            //        case 3:
            //            Console.Write("Thirty");
            //            break;
            //        case 4:
            //            Console.Write("Forty");
            //            break;
            //        case 5:
            //            Console.Write("Fifty");
            //            break;
            //        case 6:
            //            Console.Write("Sixty");
            //            break;
            //        case 7:
            //            Console.Write("Seventy");
            //            break;
            //        case 8:
            //            Console.Write("Eighty");
            //            break;
            //        case 9:
            //            Console.Write("Ninety");
            //            break;
            //    }
            //    switch (b)
            //    {
            //        case 1:
            //            Console.WriteLine(" one");
            //            break;
            //        case 2:
            //            Console.WriteLine(" two");
            //            break;
            //        case 3:
            //            Console.WriteLine(" three");
            //            break;
            //        case 4:
            //            Console.WriteLine(" four");
            //            break;
            //        case 5:
            //            Console.WriteLine(" five");
            //            break;
            //        case 6:
            //            Console.WriteLine(" six");
            //            break;
            //        case 7:
            //            Console.WriteLine(" seven");
            //            break;
            //        case 8:
            //            Console.WriteLine(" eight");
            //            break;
            //        case 9:
            //            Console.WriteLine(" nine");
            //            break;
            //    }
            //}
            #endregion
            #region Task 6
            //6.User gives 3 numbers x, y, r. Find out if point with location (x,y) is inside the circle with radius r?
            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());
            //int r = Convert.ToInt32(Console.ReadLine());
            //if(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) <= r)
            //{
            //    Console.WriteLine("Point is inside of circle!");
            //}
            //else
            //{
            //    Console.WriteLine("Point is out of circle!");
            //}
            #endregion
            #region Task 7         
            //7.Write a program with 4 different options. Below you’ll see what should happen if user will choose one of those options:
            //a.Take a 3 - digit number as input, and say if square of this number equals sum of all it’s digits to the power of 3.
            //b.Take a 4 - digit number and say if sum of first two digits equals sum of last 2 digits.
            //c.Take a 3 - digit number as input.Say if there any 2 similar digits in it.
            //d.Take a float number. Say if first 3 digits after comma contains 0.

            #region Task 7.a
            //7.a
            //int n = Convert.ToInt32(Console.ReadLine());
            //int a = n / 100;
            //int b = (n / 10) % 10;
            //int c = n % 10;
            //if (Math.Pow(n, 2) == Math.Pow(a + b + c, 3))
            //{
            //    Console.WriteLine("It is equal!");
            //}
            //else
            //{
            //    Console.WriteLine("It is not equal!");
            //}
            #endregion
            #region Task 7.b
            //int n = Convert.ToInt32(Console.ReadLine());
            //int a = n / 1000;
            //int b = (n / 100) % 10;
            //int c = (n / 10) % 10;
            //int d = n % 10;
            //if(a+b == c+d)
            //{
            //    Console.WriteLine("It is equal!");
            //}
            //else
            //{
            //    Console.WriteLine("It is not equal!");
            //}
            #endregion
            #region Task 7.c
            //int n = Convert.ToInt32(Console.ReadLine());
            //int a = n / 100;
            //int b = (n / 10) % 10;
            //int c = n % 10;
            //if(a==b||a==c||b==c)
            //{
            //    Console.WriteLine("There are similiar digits");
            //}
            //else
            //{
            //    Console.WriteLine("There are no similar digits");
            //}
            #endregion
            #region Task 7.d
            //decimal n = Convert.ToDecimal(Console.ReadLine());
            //decimal r = n * 1000;
            //if(r % 10 < 1 || (r / 10) % 10 < 1 || (r / 100) % 10 < 1)
            //{
            //    Console.WriteLine("Number contains zero!");
            //}
            //else
            //{
            //    Console.WriteLine("Number does not contain zero!");
            //}
            #endregion
            #endregion
        }
    }
}
