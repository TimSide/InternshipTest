using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Institution
{
    public class University
    {
        private readonly string _name;
        private readonly List<Student> _students = new List<Student>();
        
        // Constructor
        public University(string name)
        {
            _name = name;
        }

        // Accept students to university (Method gets one or more parameters)
        public void AddStudents(params Student[] students)
        {
            foreach (var student in students)
            {
                _students.Add(student);
            }
        }
        
        // Print all students of university
        public List<Student> GetStudents()
        {
            return _students;
        }
    }
}
