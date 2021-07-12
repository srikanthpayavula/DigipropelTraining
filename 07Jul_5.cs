﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace July_5
{
    abstract class Course
    {
        protected string name;
        protected int duration;
        protected int coursefee;

        public Course(string name, int duration, int coursefee)
        {
            this.name = name;
            this.duration = duration;
            this.coursefee = coursefee;
        }

        public virtual void Print()
        {
            Console.WriteLine(name);
            Console.WriteLine(duration);
            Console.WriteLine(coursefee);
        }

        public abstract int GetTotalFee();
    }

    class ParttimeCourse : Course
    {
        private string timings;

        public ParttimeCourse(string name, int duration, int coursefee, string timings) : base(name, duration, coursefee)
        {
            this.timings = timings;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(timings);
        }

        public override int GetTotalFee()
        {
            return (int)(coursefee * 0.90); // 10% discount
        }

    }

    class OnsiteCourse : Course
    {
        private string company;
        private int nostud;

        public OnsiteCourse(string name, int duration, int coursefee, string company, int nostud)
            : base(name, duration, coursefee)
        {
            this.company = company;
            this.nostud = nostud;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(company);
            Console.WriteLine(nostud);
        }

        public override int GetTotalFee()
        {
            return (int)(coursefee * 1.1);  // 10% more
        }

    }

    class TestCourse
    {

        //public static void Main()
        //{
        //    Course c = new OnsiteCourse("VB.NET", 30, 6000, "ABC Tech", 10);
        //    c.Print();
        //    Console.WriteLine(c.GetTotalFee());

        //    c = new ParttimeCourse("C#", 30, 3000, "11-12am");
        //    c.Print();
        //    Console.WriteLine(c.GetTotalFee());
        //    Console.Read();
        //}


    }
}
/*
  output
 VB.NET
30
6000
ABC Tech
10
5500
C#
30
3000
11-12am
2700
    */
