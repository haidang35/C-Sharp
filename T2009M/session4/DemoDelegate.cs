using System;
using T2009M.lab.s4;

namespace T2009M.session4
{
    public class DemoDelegate

    {
       // public event ShowString ShowEvent;

        public DemoDelegate()
        {
            //Program.ss += ShowMsg;
            SayHello("jinner");
          
        }
        
        public void SayHello(string s)
        {
         Console.WriteLine("msf: " + s);       
        }
        public static void ShowMsg(string msg)
        {
            Console.WriteLine("Show message: " + msg);
        }

        public void ShowInfo(string info)
        {
            Console.WriteLine("Info: " + info);
        }

        /*public void Running()
        {
            if (ShowEvent == null)
            {
                ShowEvent += ShowMsg;
                ShowEvent += ShowInfo;
            }

            ShowEvent("Toi vua phat ra mot event");
        }*/
        
        
    }
}