using System;

namespace QualityTest.Models
{
    public enum StudentStatus: int
    {
        Active = 1,
        Deactive = 0
    }
    public class Student
    {
        public string RollNumber { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday  { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public StudentStatus Status { get; set; }


        public bool IsNewStudent()
        {
            return DateTime.Now.CompareTo(CreatedAt.AddMonths(2)) <= 0;
        }

        public bool IsDeactive()
        {
            return Status == StudentStatus.Deactive;
        }
        
        public void printInfo()
        {
              Console.WriteLine($"{RollNumber, -15} {"|", -5 } {FullName, -30} {"|", -5 } {Email, -30 } {"|", -15 }" +
                                      $"{PhoneNumber, -15} {"|", -5} {IsNewStudent(), -20} {"|", -5 } {Status, -15} ");;
        }
    }
}