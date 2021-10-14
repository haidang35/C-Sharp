namespace T2009M.session4
{
    public delegate void ShowString(string s); // khai bao mot delegate dai dien co cac ham return void va tham so string
    
    public class Program
    {
        public static ShowString ss = new ShowString(DemoDelegate.ShowMsg);
        
        public static void Main(string[] args)
        {
            /*DemoDelegate.ShowMsg("Hello world! ");
            DemoDelegate dmo = new DemoDelegate();
            dmo.ShowInfo("Show me what you got");*/
            DemoDelegate dmos = new DemoDelegate();
            ss += new DemoDelegate().ShowInfo;
            ss += DemoDelegate.ShowMsg;
            ss += DemoDelegate.ShowMsg;
            ss("Xin chao cac ban"); // chay delegate

            DemoDelegate dd = new DemoDelegate();
            dd.Running();


        }
    }
}