using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using T2009M.session1;

namespace T2009M
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            /*int n;
            int n1 = 0;
            int n2 = 1;
            int n3;
            Console.WriteLine("Nhap vao mot so n: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; true; i++)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;

                if (n3 > n)
                {
                    Console.WriteLine("So thuoc day fibonaci gan "+n +" la: " +n1);
                    break;
                }
            }

            Student s1 = new Student("Nguyen Hai Dang", 19);
            s1.ShowInfo();

            Student[] svArray = new Student[3];
            svArray[0] = s1;
            svArray[1] = new Student("Nguyen Hai Dang", 19);
            svArray[2] = new Student("Nguyen Hai Dang", 19);
            
            //list 
            List<Student> listStudents = new List<Student>();
            listStudents.Add(new Student("Nguyen Hai Dang", 19));*/
            
            Product prod = new Product(1, "Iphone", 2000, 5, "image1", "SmartPhone");
            prod.GetInfo();
            prod.NotificationQuantity();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.AddImageToGallery();
            prod.DeleteImageInGallery();
            prod.GetInfo();

        }
    }
}