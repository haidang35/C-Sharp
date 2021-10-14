using System;

namespace s1.Delegate
{
    public class Program
    {
        public delegate void ShowLog(string message);
        
        public static void Main(string[] args)
        {
            
        }

        public static void Info(string s)
        {
            Console.WriteLine(s);
        }

        public static void Alert(string s)
        {
            Console.WriteLine(s);
        }
    }
}