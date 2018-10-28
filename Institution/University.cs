using System;
using System.Collections.Generic;
using System.Linq;
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
        public void /*List<Student>*/ GetStudents()
        {
            Console.WriteLine("\nStudents of " + _name + ":");

            if (_students.Count().Equals(0))    // Students not accepted to university
            {
                Console.WriteLine("---No students---");
            }
            else    // Print students of university
            {
                foreach (var student in _students)
                {
                    Console.Write(student.GetName());
                    Console.WriteLine(", knowledge = " + student.GetKnowledge());
                }
            }

            //return _students;
        }
    }
}
