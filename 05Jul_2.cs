using System;

namespace _5jul_2
{
   public class ConstructorPgm
{
    public static void Main(string[] args)
    {
        Person[] persons = new Person[3];
        Console.WriteLine("Input : ");
        for (int i = 0; i < persons.Length; i++)
        {
            persons[i] = new Person(Console.ReadLine());
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
        public Person(string a){
            Name=a;
        }
 
        public override string ToString()
        {
            return "Name " + Name;
        }
        ~Person(){
            Name=string.Empty;
        }
    }
}
}