using System;
using System.Collections.Generic;
using QualityTest.Controllers;
using QualityTest.Models;

namespace QualityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateMenu();            
        }

        static void GenerateMenu()
        {
            List<Student> studentList = new List<Student>();
            var studentController = new StudentController();
            var option = 1;
            var isContinue = true;
            do
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Create new student");
                Console.WriteLine("2. Show student list");
                Console.WriteLine("3. Exit");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Select menu item: ");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        var student = studentController.CreateStudent();
                        studentList.Add(student);
                        break;
                    case 2:
                        studentController.PrintListStudent(studentList);
                        break;
                    case 3:
                        Console.WriteLine("Goodbye !!");
                        isContinue = false;
                        break;
                    default:
                        Console.WriteLine("Menu item does not exist, please choose again");
                        break;
                }
            } while ( isContinue);

        }

       
    }
}