using System.Collections.Generic;

namespace T2009M.session3
{
    public class Student : Human
    {
        private string name;
        private int age;
        private string birthday;
        private string nickName;
        private string cannang;

        /*public string[] gallery = new string[3];*/
        public List<string> phoneNumber = new List<string>(2);
        
        
        

        public override string Weight
        {
            get => cannang;
            set => cannang = value;
        }
        public Student()
        {
            
        }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            phoneNumber.Add("a");
            phoneNumber.Add("b");
        }

        /*public string this[int index] //indexer la bien doi tuong duoc su dung nhu 1 array
        {
            get => gallery[index];
            set => gallery[index] = value;
        }*/

        public string this[int index]
        {
            get => phoneNumber[index];
            set => phoneNumber[index] = value;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public string Birthday
        {
            get => birthday;
        }

        public string NickName
        {
            set => nickName = value;
        }
    }
}