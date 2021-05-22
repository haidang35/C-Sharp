using System;

namespace T2009M.session2
{
    public /* sealed */ class Mamal : Animal, IAnimalInterface, IMamalInterface
    {
        
        
        public void Sound()
        {
            
        }

        public void Hit()
        {
            
        }

        public void Running()
        {
            base.Eat();
            Console.WriteLine("Running ...");
        }

        public void Running(string n)
        {
            Console.WriteLine(n);
        }

        public void Running(int n)
        {
            Console.WriteLine(n);
        }

        public override void Eat()
        {
            Console.WriteLine("ABC");
        }
    }
}