using SyntaxAndIndentation.Models;
using System;

namespace SyntaxAndIndentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Antonio";
            person.Age = 22;
            person.Presentation();
            Console.ReadKey();
        }
    }
}
