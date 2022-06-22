using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FirstProject.Linq
{           

    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();
            universities.Add(new University { Id = 1, Name = "Mumbai" });
            universities.Add(new University { Id = 2, Name = "Pune"});
            students.Add(new Student { Id = 1, Name = "Siddharth", Gender = "Male", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Singh", Gender = "Male", Age = 20, UniversityId = 2 });
            students.Add(new Student { Id = 3, Name = "Harsh", Gender = "Male", Age = 19, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "Linda", Gender = "Female", Age = 22, UniversityId = 1 });


        }
        public void MaleStudent()
        {
            IEnumerable<Student> maleStudent = from student in students where student.Gender == "Male" select student;
            Console.WriteLine("Male-Student");
            foreach (Student student in maleStudent)
            {
                student.Print();
            }
        }
    }
    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Print()
        {
            Console.WriteLine("University {0} with id{1}",Name,Id);
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        //foreign key
        public int UniversityId { get; set; }
        public void Print()
        {
            Console.WriteLine("Student{0} with Id{1},Gender{2} and Age{3} from University with the Id{4}",Name,Id,Gender,Age,UniversityId);
        }
    }
}
