using System;

namespace _5Jul_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p=new Person();
            p.Greet();

            Student myst=new Student();
            myst.SetAge(35);
            myst.Greet();
            myst.ShowAge();
            myst.Study();
            Teacher myTeacher=new Teacher();
            myTeacher.SetAge(45);
            myTeacher.Greet();
            myTeacher.Explain();

            Console.Read();
        }
    }
    public class Person{
        protected int age;
        public void Greet(){
            Console.WriteLine("Hello");
        }
        public void SetAge(int b){
            age=b;
        }
    }
    class Student:Person{
        public void Study(){
            Console.WriteLine("I am Studying");
        }
        public void ShowAge(){
            Console.WriteLine("My age is {0} old years ago ",age);
        }
    }
    class Teacher:Person{
        public void Explain(){
            Console.WriteLine("I'am explaining");
        }
    }
}
/*output
Hello
Hello
My age is 35 old years qgo
i am studying
hello
I'am explaining
*/