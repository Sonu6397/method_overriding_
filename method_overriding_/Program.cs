using System;

namespace method_overriding_
{
    class Employee
    {
        public virtual void  Show(int a ,int b)
        {
            Console.WriteLine("this method is parent class="+ a +" " + b);
        }

    }

    class Student : Employee
    {
        public override void Show(int a, int b)
        {
            base.Show(a, b);
            Console.WriteLine("this method is child class ="+ a + " " + b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student S = new Student();
            S.Show(1, 2);
            Console.ReadLine();
        }
    }
}
