using System;
using System.Threading;
using T2009M.lab.s3;

namespace T2009M.session5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(RunTimes); // static function
            t1.Start("Dang Jinner"); // truyen tham so cho ham
            Thread t2 = new Thread(new Program().Show20Times); // none static function
            t2.Start();
            Thread t3 = new Thread(delegate()
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine("Anonymous ... " +i);
                    try
                    {
                        Thread.Sleep(1000);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                }
            });
            t3.Start();
           lab.s4.ShowResult sm = delegate(int a, int b) { return a + b;  };
           sm(5, 6);
           /*lab.s4.ShowResult sm2 = (a, b) => return a+b;*/

        }

        public static void RunTimes(Object obj) // neu co tham so chir duoc 1 tham so object
        {
            for (int i = 0; i < 20; i++)
            {
                string msg = obj as string; // ep kieu 
                Console.WriteLine(msg + i);
                try
                {
                    Thread.Sleep(1000);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        public void Show20Times()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Show ... "+i);
                try
                {
                    Thread.Sleep(1000);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
    }
}