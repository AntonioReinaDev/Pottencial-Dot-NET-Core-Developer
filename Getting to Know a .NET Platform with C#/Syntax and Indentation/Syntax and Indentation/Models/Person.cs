using System;

namespace SyntaxAndIndentation.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Presentation()
        {
            Console.WriteLine($"Hello, my name in {Name} and I am {Age} year old.");
        }
    }
}