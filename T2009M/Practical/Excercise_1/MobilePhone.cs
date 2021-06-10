namespace T2009M.Practical
{
    public class MobilePhone : Phone
    {
        public MobilePhone()
        {
        }
        
        public MobilePhone(string phoneName, string phoneType, float phonePrice) : base(phoneName, phoneType, phonePrice)
        {
            this.phoneType = "Mobile";
        }

        public void Display()
        {
            base.Display();
        }
        
        
    }
}