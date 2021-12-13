using System;

namespace Laba3
{
    class Person
    {
        public string name { get; set; }
        int age;
        public int setAge
        {
            set { age = value; }
        }
        public int Greet
        {
            get { return age; }
        }
    }
    class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }
        public void ShowAge(int x)
        {
            Console.WriteLine($"My age is: " + x + " years old");
        }
    }
    class Professor : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
    class StudentProfessorTest
    {
        string name { get; }
        public StudentProfessorTest(string _name)
        {
            name = _name;
        }
        public void Main()
        {
            Console.WriteLine("Good day " + name);

            var student = new Student();
            student.setAge = 19;
            student.name = "Ivan";
            Console.WriteLine("Hello my name " + student.name + ". I am studant ");
            student.ShowAge(student.Greet);

            var teacher = new Professor();
            teacher.setAge = 36;
            teacher.name = "Jhon";
            Console.WriteLine("Good day, i am " + teacher.name + ", I am " + teacher.Greet + " yers old");
            teacher.Explain();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var test = new StudentProfessorTest("Steven");
            test.Main();
        }
    }
}
