using System;

namespace lab_2
{
    public class Person : IDateAndCopy
        {
        public string Name;
        public string Surname;
        public DateTime dateTime;
        public Person(String Name, String Surname, DateTime dateTime)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.dateTime = dateTime;
        }
        public Person()
        {
            Name = "Tom";
            Surname = "Eddison";
            dateTime = new DateTime(2002, 10, 24);
        }
        public string Names
        {
            get { return Name; }
            set { Name = value; }
        }
        public string Surnames
        {
            get { return Surname; }
            set { Surname = value; }
        }
        public DateTime datetime
        {
            get
            {
                return dateTime;
            }
            set
            {
                dateTime = value;
            }

        }
        public override string ToString()
        {
            return $"Name= {Name}, Surname= {Surname}, DateTime= {dateTime.ToShortDateString()}";
        }

        public virtual string ToShortString()
        {
            return $"Name= {Name}, Surname= {Surname}";
        }

        public static bool operator ==(Person obj1, Person obj2)
        {
            bool result = true;
            if ((obj1.Name == obj2.Name) && (obj1.Surname == obj2.Surname) && (obj1.dateTime == obj2.dateTime))
                return false;
            return true;
        }
        public static bool operator !=(Person obj1, Person obj2)
        {
            bool result = false;
            if ((obj1.Name == obj2.Name) && (obj1.Surname == obj2.Surname) && (obj1.dateTime == obj2.dateTime))
                return true;
            return false;
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            var p = obj as Person;
            if ((System.Object)p == null)
            {
                return false;
            }
            return (Name == p.Name) && (Surname == p.Surname) && (datetime == p.datetime);

        }
        public override int GetHashCode()
        {
            var hash = 17;
            hash = hash * 31 + Name.GetHashCode();
            hash = hash * 31 + Surname.GetHashCode();
            hash = hash * 31 + dateTime.GetHashCode();
            return hash;
        }

        public object DeepCopy()
        {
            Person person = new Person(Name, Surname, dateTime);
            return person;
        }
        }
}