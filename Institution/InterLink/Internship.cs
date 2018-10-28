using System;
using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        private string _name;
        private readonly List<Student> _interns = new List<Student>();
        
        // Constructor
        public Internship(string name)
        {
            _name = name;     
        }

        // Formation of a list of students by level of knowledge
        public void FormationInterns(List<Student> students, int knowledgeMinLevel)
        {
            _interns.Clear(); // Reset intern-list
            foreach (var student in students)
            {
                if (student.GetKnowledge() > knowledgeMinLevel)
                {
                    AddMember(student);
                }
            }
            Console.WriteLine("\nRequirements of knowledge > " + knowledgeMinLevel);
        }

        // Add person (Student) to internship
        private void AddMember(Student student)
        {
            _interns.Add(student);
        }
        
        // Get all persons (students) from internship
        public List<Student> GetStudentsOfInternship()
        {
            return _interns;
        }
        
        //===========
        // Print all persons (students) from internship  (!!! Command prompt only)
        public void PrintStudentsOfInternship()
        {
            Console.WriteLine("\n!!!=== Students of internship ===!!!");
            foreach (var student in _interns)
            {
                Console.WriteLine(student.GetName() + ", knowledge = " + student.GetKnowledge());
            }
            Console.WriteLine("\nCongratulations! ;)");
        }
    }
}
