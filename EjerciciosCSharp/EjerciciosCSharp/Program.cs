using System;
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
            */
            Console.Write("\n Decimo Ejercicio" + "\n");
            OperacionCombinada();









        }
        /// <summary>
        /// Primer Ejercicio
        /// </summary>
        static void PrintHello()
        {
            Console.WriteLine("Primer Ejercicio");
            Console.WriteLine("Hello World!");

        }
        /// <summary>
        /// Segundo Ejercicio
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static long Sum(long x, long y)
        {
            return x + y;
        }
        /// <summary>
        /// Tercer Ejercicio
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
        /// Cuarto Ejercicio
        /// </summary>
        /// <param name="Operation"></param>
        /// <returns></returns>
        static int Operate(int Operation)
        {
            return Operation;
        }

        /// <summary>
        /// Quinto Ejercicio
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
        /// Sexto Ejercicio
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
        /// Setimo Ejercicio
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
        /// Octavo Ejercicio
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
        /// Noveno Ejercicio
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




    }
}
