using System;
using System.Collections.Generic;

namespace T2009M.Assignment.BluePrint_Garments
{
    public class TrendSetting : Clothing
    {
        private List<string> materials = new List<string>();

        public TrendSetting()
        {
            materials.Add("Cotton Polyester");
            materials.Add("Rayon");
            materials.Add("Linen");
            materials.Add("Satin");
            materials.Add("Georgette");
            materials.Add("Moss Crepe");
            materials.Add("Net");
            materials.Add("Lace");
            materials.Add("Jacquard Velvet");
        }
        public override void Sales()
        {
            Console.WriteLine("All the places who bring in the maximun sale: ");
            Console.Write("VietNam, Thailand, France, Korea, China");
            Console.WriteLine("All the places that bring in average sale: ");
            Console.Write("India, Germany, England, Japan ");
            Console.WriteLine("All the places who were responsible for low sale: ");
            Console.Write("Laos, The Philippines, North Korea, Australia");
            throw new System.NotImplementedException();
        }

        public override void Materials()
        {
            foreach (string item in materials)
            {
                Console.WriteLine("Materials: ");
                Console.WriteLine(item + ", ");
            }
            
            throw new System.NotImplementedException();
            
        }

        public override void CommonWear()
        {
            Console.WriteLine("Common wear: ");
            Console.WriteLine("ABC Clothes, DES Clothes, ...");
            throw new System.NotImplementedException();
        }
    }
}