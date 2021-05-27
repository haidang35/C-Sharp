using System;

namespace T2009M.lab.s4
{
    public class CalcInt
    {
        public CalcInt()
        {
            
        }

       

        public static int PhepCong(int a, int b)
        {
            return a + b;
        }

        public int PhepTru(int a, int b)
        {
            int result = 0;
            if (a > b)
            {
                 result = a -b;
            }
            if (a < b)
            {
               result = b - a;
            }

            return result;
        }

        public int PhepNhan(int a, int b)
        {
            return a * b;
        }

        public int PhepChia(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
    }
}