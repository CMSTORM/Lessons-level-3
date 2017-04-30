using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int b = Int32.MaxValue;
            //Console.WriteLine(b);
            //int a = b + 1;
            //Console.WriteLine(a);
            //Console.ReadLine();


            //bool i = true;
            //Console.WriteLine(!i);
            //Console.ReadLine();

            //bool c = true;
            //bool d = false;
            //Console.WriteLine(c && d);
            //Console.WriteLine(c||d);
            //Console.WriteLine(c^!d);
            //Console.WriteLine(!d);
            //Console.ReadLine();

            //                                              PRIMER 
            //int value = 413;
            //Console.WriteLine(Convert.ToString(value,8));
            //Console.ReadLine();


            //                                                      ZADACHI


            //                                                          1
            //int number = int.Parse(Console.ReadLine());
            //var newNumber = number % 2;
            //Console.WriteLine( newNumber > 0 ? "ODD" : "even");

            //                                                          2 
            //int number = int.Parse(Console.ReadLine());
            //bool result = number % 5 == 0 && number % 7 == 0;
            //Console.WriteLine(result);

            //                                                          3



            //int thenumber = int.Parse(Console.ReadLine());
            //int newnumber = thenumber / 100;
            //bool result = newnumber % 10 == 7;
            //Console.WriteLine(result);

            //                                                          4


            //ulong a = ulong.Parse(Console.ReadLine());
            //ulong b = a >> 2;
            //Console.WriteLine(b % 2 == 0 ? "false" : "true");


            //                                                          5

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //Console.WriteLine(((a+b)/2)*c);

            //                                                          6

            //int height = int.Parse(Console.ReadLine());
            //int width = int.Parse(Console.ReadLine());
            //Console.WriteLine("Area: {0}", height*width);
            //Console.WriteLine("Perimeter: {0}" , 2*height + 2*width);


            //                                                          7

            //Console.WriteLine("enter mass: ");
            //double mass = double.Parse(Console.ReadLine());
            //double g = 9.8;
            //double moon = (9.8 * 17) / 100;
            //double result = moon * mass;
            //Console.WriteLine("G= {0}*{1} = {2}" , mass, moon, result);


            //                                                          8
            //Console.Write("enter value for x: " );
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("Enter value for y: ");
            //double y = double.Parse(Console.ReadLine());
            //int radius = 5;
            //double c = (x * x) + (y * y);
            //bool answer = c <= 5 ? true : false ;
            //Console.WriteLine(answer);
            //                                                          9



            //Console.Write("enter value for x: ");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("Enter value for y: ");
            //double y = double.Parse(Console.ReadLine());
            //int radius = 5;
            //double c = (x * x) + (y * y);
            //bool answer = Math.Sqrt(c) <= radius ? true : false;
            //Console.WriteLine("Tochkata e v okrujnostta: {0}",answer);
            //bool square = false;
            //if((x>5 || x<-1) || (y>5||y<1))
            //{
            //    Console.WriteLine("Tochkata e  izvun kvadrata");
            //    square = true;
            //}
            //else
            //{
            //    Console.WriteLine("Tochkata e  v kvadrata");
            //}
            //bool finalResult = answer&&square;
            //Console.WriteLine("Izpulneno li e uslovieto:{0}", finalResult);


            //                                                              10     


            //                                                              11


            //int n = int.Parse(Console.ReadLine());
            //int p = int.Parse(Console.ReadLine());
            //int b = n >> p; 

            //Console.WriteLine(b % 2 == 0 ? "0" : "1");


            //                                                              12

            //int n =int.Parse(Console.ReadLine());
            //int p = int.Parse(Console.ReadLine());
            //int mask = n >> p;
            //Console.WriteLine(mask % 2 == 0 ? 0 : 1);


            //                                                              13


            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double firstSide = Math.Max(x1, x2) - Math.Min(x1, x2);
            double secondSide = Math.Max(y1, y2) - Math.Min(y1, y2);
            Console.WriteLine(firstSide*secondSide);























            Console.ReadLine();









        }
    }
}
