using System;
using System.Collections;
using System.Collections.Generic;

namespace lab_2
{
    public class Student : Person, IDateAndCopy
    {

        private Person person;
        private Education education;
        private int n_Group;
        private List<Exam> exams = new List<Exam>();
        private List<Test> tests = new List<Test>();
        public Student(Person person, Education education, int n_Group)
        {
            Person = person;
            this.education = education;
            this.n_Group = n_Group;
        }
        public Student()
        {
            Person = new Person();
            this.education = Education.Вachelor;
            this.n_Group = 61;
        }
        public Person Person
        {
            get { return (Person) this; }
            set
            {
                Name = value.Names;
                Surname = value.Surnames;
                datetime = value.datetime;
            }
        }
        public Education edu
        {
            get { return education; }
            set { education = value; }
        }

        public int Group
        {
            get { return n_Group; }
            set
            {
                if (value <= 100 || value > 599)
                    throw new ArgumentOutOfRangeException("Error! GroupNumber out of range(100, 599).");
                n_Group = value;
            }
            
        }

        public Exam[] exam
        {
            get { return exams.ToArray(); }
        }
        public Test[] test
        {
            get { return tests.ToArray(); }
        }
        public void AddExams(params Exam[] exams)
        {
            this.exams.AddRange(exams);
        }
        public void AddTest(params Test[] tests)
        {
            this.tests.AddRange(tests);
        }
        public double AverageExam
        {
            get
            {
                double sum = 0;
                foreach (Exam coolMark in exams)
                {
                    sum += coolMark.Mark;
                }
                return sum / exams.Count;
            }
        }
        public bool this[Education index]
        {
            get { return this.education == index; }
        }
        public IEnumerable GetResults()
        {
            foreach (var exam in exams)
                yield return exam;
            foreach (var test in tests)
                yield return test;
        }
        public IEnumerable ExamsOver(int minRate)
        {
            foreach (var exam in exams)
            {
                Exam ex = (Exam)exam;
                if (ex.Mark > minRate)
                    yield return exam;
            }
        }
        public override string ToString()
        {
            return
                $"{base.ToString()}\nобразования:{education}\nGroup:{n_Group}\nExam:{string.Join(",", exams)}\nTest:{string.Join(",", tests)}";
        }

        public override string ToShortString()
        {
            return $"Person:{Person}\n Education:{education}\n Group:{n_Group}\nAverage:{AverageExam}";
        }
        public object DeepCopy()
        {
            Student student = new Student((Person) this, education, n_Group);
            return student;

        }
    }
}