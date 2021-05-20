using System;

namespace T2009M.session1
{
    public class Student
    {
        public string name;
        public int age;

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Ten sinh vien: "+name);
            Console.WriteLine("Lop "+ age);
        }
    }
}