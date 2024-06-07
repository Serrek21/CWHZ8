using System;


namespace CWHZ8
{

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    public static class IntExtensions
    {
        public static bool NePar(this int n)
        {
            return n % 2 != 0;
        }

        public static bool Par(this int n)
        {
            return n % 2 == 0;
        }

        public static bool IsP(this int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

        public static int Count(this string s, char[] gol)
        {
            int c = 0;
            foreach (char g in s)
            {
                if (Array.Exists(gol, gol1 => gol1 == g))
                {
                    c++;
                }
            }
            return c;
        }

        
    }

    internal class Program
    {
        private static char[] gol = { 'a', 'e', 'i', 'o', 'u' };
        private static char[] pregol = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
        private static char[] znaki = { '.', '!', '?' };
        static void Main(string[] args)
        {
            //1,2
            int n1 = 5;
            int n2 = 8;


            Console.WriteLine($"{n1} is even: {n1.NePar()}");
            Console.WriteLine($"{n2} is even: {n2.Par()}");

            //3
            int n3 = 3;

            if (n3.IsP())
            {
                Console.WriteLine($"{n3} є простим числом.");
            }
            else
            {
                Console.WriteLine($"{n3} не є простим числом.");
            }

            string text = "Hello World!";
            //4
            Console.WriteLine(text.Count(gol));
            //5
            Console.WriteLine(text.Count(pregol));
            //6
            Console.WriteLine(text.Count(znaki));


            Person[] people = new Person[]
            {
            new Person { FirstName = "Jo", LastName = "jo", Age = 30 },
             };
        }
    }
}