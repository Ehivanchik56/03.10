using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string a = Console.ReadLine();
            //string b = Console.ReadLine();
            Console.WriteLine(calc(43434,234234,235235,234234,235325));

        }


        static public float calc(float a, float b)
        {
            return 2 * a * b * (a + b);

        }


        static public float calc(float a, float b,float c)
        {
            return 2 * a * b * (a + b);

        }

        static public float calc(params float[] chisla)
        {
            float sum = 0;

            foreach (var item in chisla)
            {
                sum = sum - item * Convert.ToInt64(Math.PI);
            }
            return sum;

        }



        static public string  calc(string a, string b)
        {
            float s = Convert.ToInt64(a);
            float d = Convert.ToInt64(b);

            return $"Результат {s * s + d * s}";      
        }














    }
}
