using System;

namespace lab_2
{
   public class Test : IDateAndCopy
    {
        string subject { get; set; }
        bool check { get; set; }
        DateTime dateTime;
        public Test(string subject, bool check, DateTime dateTime)
        {
            this.subject = subject;
            this.check = check;
            this.dateTime = dateTime;
        }
        public Test()
        {
            subject = "Art";
            check = true;
            dateTime = new DateTime(2022, 10, 10);
        }
        public DateTime Date
        {
            get { return dateTime; }
            set { dateTime = value; }
        }
        public override string ToString()
        {
            return $"subject= { subject} check={check} date= {dateTime.ToShortDateString()}";
        }
        public object DeepCopy()
        {
            Test test = new Test(subject, check, dateTime);
            return test;
        }
    }
}