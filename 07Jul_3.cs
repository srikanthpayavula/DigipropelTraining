
/* 3.Create a new C # project with three classes plus another class to test the logic in your code */
    using System;
    namespace Assmt_July
{ 
    public class StudentAndTeacherTest
    {
        public static void Main()
        {
            Person myPerson = new Person();
            myPerson.Greet();
     
            Student myStudent = new Student();
            myStudent.SetAge(21);
            myStudent.Greet();
            myStudent.ShowAge();
            myStudent.Study();
     
            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(30);
            myTeacher.Greet();
            myTeacher.Explain();
        }
    }
     
    public class Person
    {
        protected int age;
     
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
     
        public void SetAge(int n)
        {
            age = n;
        }
    }
     
    public class Student : Person
    {
        public void Study() 
        {
            Console.WriteLine("I'm studying");
        }
     
        public void ShowAge()
        {
            Console.WriteLine("My age is {0} years old", age);
        }
    }
     
    public class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
}

/*
Output
Hello!
Hello!
My age is 21 years old
I'm studying
Hello!
I'm explaining
*/
