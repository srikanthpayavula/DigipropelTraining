using System;

namespace _5Jul_1
{
   public class FirstPgm
{
    public static void Main(string[] args)
    {
        Person[] persons = new Person[3];
         Console.WriteLine("Input : ");
        for (int i = 0; i < persons.Length; i++)
        {
            persons[i] = new Person() {
                Name = Console.ReadLine()
            };
        }
 
        for (int i = 0; i < persons.Length; i++)
        {
            Console.WriteLine(persons[i].ToString());
        }
 
        Console.ReadLine();
    }
 
    public class Person
    {
        public string Name { get; set; }
 
        public override string ToString()
        {
            return "Name " + Name;
        }
    }
}
}
