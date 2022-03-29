using System;
namespace lab_2
{
    public enum Education
    {
        Specialist,
        Вachelor,
        SecondEducation
    }
    
    class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("1 задание:");
                var student1 = new Person("Lilia", "Abulkhanova", new DateTime(2002, 10, 10));
                var student2 = new Person("Lilia", "Abulkhanova", new DateTime(2002, 10, 10));
                Console.WriteLine($"==:{student1==student2}");
                Console.WriteLine($"!=:{student1!=student2}");
                Console.WriteLine($"HashCode {student1.GetHashCode()} {student2.GetHashCode()}");
                Console.WriteLine($"Equals:{student1.Equals(student2)}");
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("2 задание:");
                var student3 = new Student(new Person("Lilia", "Abulkhanova", new DateTime(2002, 10, 10)), Education.Вachelor, 103);
                student3.AddExams(new Exam("OOP", 5, new DateTime(2022, 1, 23)), new Exam("Art", 3, new DateTime(2023, 2, 13)));
                student3.AddTest(new Test("Physic", true, new DateTime(2022, 1, 23)), new Test("English", false, new DateTime(2022, 10, 23)));
                Console.WriteLine(student3.ToString());
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("3 задание:");
                Console.WriteLine(value: student3.Person.Names + " " + student3.Person.Surnames + " " + student3.Person.datetime.ToShortDateString());
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("4 задание:");
                Student studentTest = new Student(new Person("Tom", "Edisson", new DateTime(2002, 10, 10)),
                    Education.Specialist, 104);
                Student student4 = (Student)studentTest.DeepCopy();
                Console.WriteLine($"Обьект у которого скопировали данные {studentTest.ToString()}");
                Console.WriteLine($"Копируемый обьект {student4.ToString()}");
                Console.WriteLine("Изменим копируемый обьект");
                student4.Names = "Kamilla";
                Console.WriteLine($"Обьект у которого скопировали данные {studentTest.ToString()}");
                Console.WriteLine($"Копируемый обьект {student4.ToString()}");
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("5 задание:");
                try
                {
                    student3.Group = 90;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("6 задание:");
                foreach (var task in student3.GetResults())
                    Console.WriteLine(task.ToString());
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("7 задание:");
                foreach (var task in student3.ExamsOver(3))
                    Console.WriteLine(task.ToString());
               

               
                
            }
        }
    }
