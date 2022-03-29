using System;

namespace lab_2
{
    public class Exam : IDateAndCopy
    {
        public string Subject { get; set; }
        public int Mark { get; set; }
        public DateTime dateExam { get; set; }

        public Exam(string Subject, int Mark, DateTime dateExam)
        {
            this.Subject = Subject;
            this.Mark = Mark;
            this.dateExam = dateExam;
        }
        public Exam()
        {
            Subject = "Art";
            Mark = 5;
            dateExam = new DateTime(2022, 01, 24);
        }
        public override string ToString()
        {
            return $"Subject= {Subject}, Mark= {Mark}, dateExam= {dateExam.ToShortDateString()}";
        }
        public object DeepCopy()
        {
            Exam exam = new Exam(Subject, Mark, dateExam);
            return exam;
        }
    }
}