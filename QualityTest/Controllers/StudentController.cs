using System;
using System.Collections.Generic;
using QualityTest.Models;

namespace QualityTest.Controllers
{
    public class StudentController
    {
        public void PrintListStudent(List<Student> students)
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"{"Rollnumber", -15} {"|", -5 } {"Fullname", -30} {"|", -5 } {"Email", -30 } {"|", -15 }" +
                              $"{"Phone", -15} {"|", -5 } {"Is New Student", -20} {"|", -5 } {"Status", -15} ");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            foreach (var student in students)
            {
               student.printInfo();
            }
        }

        public Student CreateStudent()
        {
            Console.WriteLine("Please enter rollnumber");
            var rollNumber = Console.ReadLine();
            Console.WriteLine("Please enter fullname");
            var fullName = Console.ReadLine();
            Console.WriteLine("Please enter birthday YYYY-mm-dd");
            var birthday = DateTime.Parse(Console.ReadLine()) ;
            Console.WriteLine("Please enter email");
            var email = Console.ReadLine();
            Console.WriteLine("Please enter phone");
            var phoneNumber = Console.ReadLine();
            Console.WriteLine("Please enter status ( 1- Active, 2- Deactive)");
            var status = (StudentStatus)int.Parse(Console.ReadLine());
            var newStudent = new Student
            {
                RollNumber = rollNumber,
                FullName = fullName,
                Birthday = birthday,
                Email = email,
                PhoneNumber = phoneNumber,
                CreatedAt = DateTime.Now,
                Status = status,
            };
            return newStudent;

        }
    }
}