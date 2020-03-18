using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int birthyear;
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello "+ name);
            Console.WriteLine("Enter your Birth year: " );
            birthyear = Int32.Parse(Console.ReadLine());
            int age;
            age = 2020 - birthyear;
            Console.WriteLine("you are "+ age+" years old");

            Console.ReadKey();
        }
    }
}
