﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Learn
{
    class Program
    {
        static void Greet(string name)
        {
            Console.WriteLine("Good Morning" + name);
        }
        static float Average(int a, int b, int c)
        {
            float sum=a+b+c;
            return sum/3;
        }
        static float Average(int a, int b)
        {
            return (a + b) / 2;
        }
        static void Main(string[] args)
        {
            // Singleline Comment
            /*
             * Multiline comment
             */
            //int Raihan = 35; //Integer Variable
            /* Data types in C#;
             * Integer - int Raihan;--  4 bytes
             * Long - long Raihan;-- 8 bytes
             * Floating point number - float that;-- 2 bytes
             * Double - double Raihan; -- 8 bytes
             * Character - Char a='A';-- 2 bytes
             * Boolean - bool is Great =true;-- 1bit
             * String inp="Raihan";-- 2 bytes per character
             */
            //string inp = Console.ReadLine();
            //Console.WriteLine(inp);
            /*
            Console.WriteLine("How are You?");
            Console.WriteLine("Good"+Raihan);
            Console.WriteLine("Ok");
            */
            //DATA TYPE EXAMPLE
            //int S = 33;
            // float A = 33F;
            // double R = 33D;
            // String inp = "Love";
            // Char I = 'U';
            // bool isGreat= true!;
            /*
            Console.WriteLine(S);
            Console.WriteLine(A);
            Console.WriteLine(R);
            Console.WriteLine(inp);
            Console.WriteLine(I);
            Console.WriteLine(isGreat);
            */


            //Type Casting
            //There are two types of type casting
            //1. Implicit Casting
            //Char to int to long to float to double
            //2. Explicit Casting
            // int x=(int) 3.5;
            //double x1=(double) 3.5;
            //Console.WriteLine(x1);
            // X = 3;
            // Y = 4;
            // Z = 'Y';
            // varr = Convert.ToInt32(3.55);
            //.ToDouble
            //.ToString
            // sx = "Random String";

            //.WriteLine(X);
            //.WriteLine(Y);
            //.WriteLine(Z);
            //**USER INPUT //
            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            //Co//nsole.WriteLine("Hey " + name);
            //Console.WriteLine("Do you like anyone?");
            //string Quention = Console.ReadLine(); 
            //Console.WriteLine("Nice! You deserve someone better than me" +( Convert.ToInt32(Quention) + 4));
            /*operators in C#
             1.Arithmatic operations
             2.Assigment operators
             3.Logical operators
             4.Comparison operators
            */
            //1.Arithmatic operations
            //int s = 33;
            //int r = 35;
            //Console.WriteLine("The value of s + r is:"+(s+r));
            //Console.WriteLine("The value of s - r is:" +(s-r));
            //Console.WriteLine("The value of s * r is:" +(s*r));
            //Console.WriteLine("The value of s / r is:" +(s/r));

            //2.Assigment operators
            //int s = 33;
            //int R = s;
            //R -= 33;
            //R+=33;
            //R *= 33;
            //R /= 33;
            // Console.WriteLine(R);

            //Logical Operators 
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);
            //
            //Console.WriteLine(false || true);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || false);
            //Console.WriteLine(!false); Console.WriteLine(!true); 

            //4.Comparison operators
            //Console.WriteLine(324 > 555);
            //Console.WriteLine(324 <= 555);
            //Console.WriteLine(324 >= 555);
            //Console.WriteLine(324 != 555);


            //MATH

            //int s = Math.Max(193, 33);
            //int a = Math.Min(193, 33);
            //double r = Math.Sqrt(33);
            //double R = Math.Abs(35);
            //Console.WriteLine(s);
            //Console.WriteLine(a);
            //Console.WriteLine(r);
            //Console.WriteLine(R);
            //string hello = "Hello world this is Raihan";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello.ToLower());
            //Console.WriteLine(hello + "You are Nice!");
            //Console.WriteLine(String.Concat(hello , "You are Nice!"));


            //String
            /*
            Console.WriteLine("Enter her name you loved");
            String name = Console.ReadLine();
            Console.WriteLine("ONE WORD TO DEDICATE HER");
            string Fuckingthought = Console.ReadLine();
            Console.WriteLine($"Her name is {name}.I wish she will get {Fuckingthought} ");
            */



            //String hello = "Hello world this is Raihan";
            //String hello = "Hello \"world \"this is Raihan"; //--   " W "
            //String hello = "Hello world \n this is Raihan";    //--   NEW LINE
            //String hello = "Hello world \t this is Raihan";    //--   FOR    SPACE
            //Console.WriteLine(hello[1]);
            //Console.WriteLine(hello.IndexOf("is"));
            //Console.WriteLine(hello.Substring(3));
            //Console.WriteLine(hello);

            //Comparison operators
            /*
                        Console.WriteLine("Enter Your age");
                        string agestr = Console.ReadLine();
                        int age=Convert.ToInt32(agestr); 
                        bool alwaysenjoy = true;
                        if (age < 2 || alwaysenjoy)
                        {
                            Console.WriteLine("You are in a good life");
                        }
                        else if (age < 18 || alwaysenjoy)
                        {
                            Console.WriteLine("Please enjoy and love yourself");
                        }
                        else if (age < 20 || alwaysenjoy)
                        {
                            Console.WriteLine("Learn any skill");
                        }
                        else
                        {
                            Console.WriteLine("Take a big risk");
                        }
            */

            //Switch case
            /*
            int age = 20;

            switch (age)
            {
                case 18: Console.WriteLine("Fllow a football team");
                    break;

                case 20: Console.WriteLine("Make a study youtube chanel always watch study video on this account");
                    break;
                default: Console.WriteLine("Enjoy");
                    break;
            }
            */

            //Loops in Csharp
            /*
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            */
            //Better Alternative-Lopps
            //While Lopps
            /*
            int i = 0;
            while (i<5000)
            {
                Console.WriteLine(i+1);
                i++;
            }
            */
            //Do Lopps
            /*
            int i = 0;
            do
            {
                Console.WriteLine(i + 1);
                i++;
            } while (i <5000);
            */
            //For Lopps
            /*
            for (int i = 0; i<5; i++)
            {

                if (i == 0)
                {
                    continue;
                }
                Console.WriteLine(i+1);
            }
            */
            
            // Break and continue
            //Break -leave this loop forever
            //continue : Leave this particular iteration of the loop

            //Methods 
            /*
            Greet("Jaohar");
            Greet("Raihan");
            Console.WriteLine(Average(2, 6, 8));
            float temp =Average(9, 3, 0);
            Console.WriteLine(temp);
            Console.WriteLine(Average(3, 3, 3));
            Console.WriteLine(Average(3, 3));
            */


                Console.ReadLine();


        }
    }
}
