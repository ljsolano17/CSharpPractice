﻿using System;
using System.Collections.Generic;

namespace EjerciciosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            PrintHello();
            /*  Console.Write("Segundo Ejercicio"+"\n"+Sum(10,10));
              Console.Write("\n Tercer Ejercicio" + "\n" + Division(10, 3));
              Console.Write("\n Cuarto Ejercicio" + "\n" + Operate((10-+8)*9));
              Console.Write("\n Quinto Ejercicio" + "\n");
              var lista = SwapNum(4, 6);
              Console.Write("4"+'\n' + '6'+"\n");
              lista.ForEach(Console.WriteLine);

              Console.Write("\n Sexto Ejercicio" + "\n" + Multipl());
              Console.Write("\n Setimo Ejercicio" + "\n" + Operations(5,6));
              Console.Write("\n Octavo Ejercicio" + "\n");
              multTable();
            Console.Write("\n Noveno Ejercicio" + "\n");
            Promediar();
            
            Console.Write("\n Decimo Ejercicio" + "\n");
            OperacionCombinada();
            Console.Write("\n Ejercicio 11" + "\n");
            LookOlderThan();

            Console.Write("\n Ejercicio 12" + "\n");
            Rows();
            Console.Write("\n Ejercicio 13" + "\n");
            Rectangle();
            Console.Write("\n Ejercicio 14" + "\n");
            ConvertDegrees();


            Console.Write("\n Ejercicio 15" + "\n");
            Console.WriteLine(RemoveChar("w3resource",1));
            
            Console.Write("\n Ejercicio 16" + "\n");
            ChangeOrder();

            Console.Write("\n Ejercicio 17" + "\n");
            RepetirLetra();
            */
            Console.Write("\n Ejercicio 18" + "\n");
            Console.WriteLine(CheckNumber());

        }
        /// <summary>
        /// Ejercicio 1
        /// </summary>
        static void PrintHello()
        {
            Console.WriteLine("Primer Ejercicio");
            Console.WriteLine("Hello World!");

        }
        /// <summary>
        /// Ejercicio 2
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static long Sum(long x, long y)
        {
            return x + y;
        }
        /// <summary>
        /// Ejercicio 3
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static long Division(long x, long y)
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                return 0;
            }
           

        }
        /// <summary>
        /// Ejercicio 4
        /// </summary>
        /// <param name="Operation"></param>
        /// <returns></returns>
        static int Operate(int Operation)
        {
            return Operation;
        }

        /// <summary>
        /// Ejercicio 5
        /// </summary>
        /// <param name="primero"></param>
        /// <param name="segundo"></param>
        /// <returns></returns>
        static List<int> SwapNum(int primero, int segundo)
        {

            int tempVar = primero;
            primero = segundo;
            segundo = tempVar;

            List<int> nums = new List<int>();

            nums.Add(primero);
            nums.Add(segundo);
            return nums;

        }
        /// <summary>
        /// Ejercicio 6
        /// </summary>
        /// <returns></returns>
        static int Multipl()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            return x * y * z;
        }

        /// <summary>
        /// Ejercicio 7
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>

        static string Operations(int x, int y)
        {
        
            Console.WriteLine(x.ToString()+"+"+y.ToString()+"="+(x+y).ToString()+"\n");
            Console.WriteLine(x.ToString() + "-" + y.ToString() + "=" + (x + y).ToString() + "\n");
            Console.WriteLine(x.ToString() + "/" + y.ToString() + "=" + (x / y).ToString() + "\n");
            Console.WriteLine(x.ToString() + "*" + y.ToString() + "=" + (x * y).ToString() + "\n");

            return "done";

        }
        /// <summary>
        /// Ejercicio 8
        /// </summary>
        static void multTable()
        {

            int x = int.Parse(Console.ReadLine());
           // int y = int.Parse(Console.ReadLine());

            for(int i = 0; i <= 9; i++)
            {
                Console.WriteLine(x.ToString()+" * "+i.ToString()+" = "+(x*i).ToString());
            }

        }

        /// <summary>
        /// Ejercicio 9
        /// </summary>
        static void Promediar()
        {

            decimal[] Nums = new decimal[4];
            decimal promedio = 0;
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter the "+(i+1).ToString()+ "° number");
                Nums[i] = decimal.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 4; i++)
            {
                promedio = Nums[i]+promedio;
            }

            Console.WriteLine("The average is: "+promedio/4);

        }
        /// <summary>
        /// Ejercicio 10
        /// </summary>
        static void OperacionCombinada()
        {

            decimal[] Nums = new decimal[3];
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the " + (i + 1).ToString() + "° number");
                Nums[i] = decimal.Parse(Console.ReadLine());
            }

            decimal x = 5;
            decimal y = 6;
            decimal z = 7;



            Console.WriteLine("Result of specified numbers"+Nums[0]+","+Nums[1]+"," + Nums[2] + " (x+y).z is " +(Nums[0]+Nums[1])*Nums[2]+" and x.y + y.z is "+ (x*y)+(y*z));

            Console.WriteLine((Nums[2]));

        }

        /// <summary>
        /// Ejercicio 11
        /// </summary>
        static void LookOlderThan()
        {
            Console.Write("\n Ingrese su edad" + "\n");
            int age = int.Parse(Console.ReadLine());

            if(age < 0)
            {
                age = age * -1;
            }

            Console.WriteLine("You look older than "+age);

        }
        /// <summary>
        /// Ejercicio 12
        /// </summary>
        static void Rows()
        {

            int num;

            Console.WriteLine("Enter a digit: ");
            num = int.Parse(Console.ReadLine());

           
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.WriteLine();

           
            Console.Write(num);
            Console.Write(num);
            Console.Write(num);
            Console.WriteLine(num);
            Console.WriteLine();

            //Cambia los 0 por num
            Console.WriteLine("{0} {0} {0} {0}", num);
            Console.WriteLine("{0}{0}{0}{0}",    num);

        }
        /// <summary>
        /// Ejercicio 13
        /// </summary>
        static void Rectangle()
        {

            string x = Console.ReadLine();
            Console.WriteLine(x + x + x);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(x + " " + x);
               
            }
            Console.WriteLine(x + x + x);

        }
        /// <summary>
        /// Ejercicio 14
        /// </summary>
        static void ConvertDegrees()
        {

            decimal cDegree = decimal.Parse(Console.ReadLine());
            decimal fDegree = cDegree * 9 / 5 + 32;

            Console.WriteLine(fDegree+ "°F");


        }
        /// <summary>
        /// Ejercicio 15
        /// </summary>
        /// <param name="word"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        static string RemoveChar(string word, int pos)
        {


            return word.Remove(pos, 1);

        }
        /// <summary>
        /// Ejercicio 16
        /// </summary>
        static void ChangeOrder()
        {

            var word = "Python";

            var temp = word[0];
            /*  word = word.Remove(word.Length - 1);
              word = word.Remove(0, 1)+temp;*/
             word = word.Substring(1);
             word = word[word.Length-1]+word;
             word = word.Remove(word.Length-1);
             word = word + temp;
            
            Console.WriteLine(word);
         //   word=word[word.Length-1]
        }
        /// <summary>
        /// Ejercicio 17
        /// </summary>
        static void RepetirLetra()
        {
            string phrase= "The quick brown fox jumps over the lazy dog.";
            phrase = phrase[0] + phrase + phrase[0];
            Console.WriteLine(phrase);
        }

        /// <summary>
        /// Ejercicio 18
        /// </summary>
        /// <returns></returns>
        static bool CheckNumber()
        {

            decimal x = int.Parse(Console.ReadLine());
            decimal z = int.Parse(Console.ReadLine());
            if (x < 0 && z>0 || x>0 && z<0)
            {
                return true;
            }else
            {
                return false;
            }

        }
        /// <summary>
        /// Ejercicio 19
        /// </summary>
        /// <returns></returns>

        static decimal MultiSum()
        {

            decimal x = int.Parse(Console.ReadLine());
            decimal z = int.Parse(Console.ReadLine());

            if (x == z)
            {
                return (x + z) * 3;
            }
            else
            {
                return x + z;
            }

        }
        /// <summary>
        /// Ejrecicio 20
        /// </summary>
        /// <returns></returns>
        static decimal Absolute()
        {

            decimal x = int.Parse(Console.ReadLine());
            decimal z = int.Parse(Console.ReadLine());
            if (x > z)
            {
                return (x - z) * 2;
            }
            else
            {
                return z - x;
            }
        }

    }
}
