using System;
namespace DemoOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var temp = a;
            var d = temp++;
            var b = 20;
            var c = 30;
            //Arithmetic
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a/b);
            Console.WriteLine(a % b);
            Console.WriteLine($"{temp}and{d}\n");
            //comparison
            Console.WriteLine(a>b);//false
            Console.WriteLine(a < b);//true
            Console.WriteLine(a == b);//false
            Console.WriteLine(a!=b);//true
            Console.WriteLine(a>=b);//false
            Console.WriteLine(a <= b);//true
            Console.WriteLine("\n");
            //assignment
            Console.WriteLine(a = 10);
            Console.WriteLine(a +=1 );
            Console.WriteLine(a -=1);
            Console.WriteLine(a*=2);
            Console.WriteLine(a /= 2);
            Console.WriteLine("\n");
            //logical(&&,||,!)
            Console.WriteLine(c>a &&c>b);
            //bitwise(&,|)





            


        }
    }
}