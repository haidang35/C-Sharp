using System;

namespace s1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int i;
            var b = 0;
            long c = 123_456_789;
            Console.WriteLine("b= " + c);
            // string path = "C:\Jinner\hello"; --> cach viet sai
            string path2 = "C:\\Jinner\\hello"; //--> cach viet dung
            string path3 = @"C:\JInner\hello"; // correct
        }
    }
}