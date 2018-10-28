using System.Collections.Generic;
using internshiptest.Person;
using InternshipTest.Person;

namespace InternshipTest.Institution.InterLink
{
    public class Internship : Knowledge
    {
        private string _name;
        private readonly List<Student> _interns = new List<Student>();
        
        public Internship(string name) : base(0)
        {
            _name = name;     
        }

        public void AddMember(Student student)
        {
            _interns.Add(student);
        }
        
        public List<Student> GetStudents()
        {
            return _interns;
            // return "Andrew Maslenko\nJulia Veselkina\n";
        }
    }
}
