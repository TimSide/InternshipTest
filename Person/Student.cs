using System;
using internshiptest.Person;

namespace InternshipTest.Person
{
    public class Student : Knowledge
    {
        private readonly string _name;
        
        // Create student without knowledge
        public Student(string name) : base(0)
        {
            _name = name;
            PersonsBase.AddPersonToBase(this);
        }
        
        // Create student with knowledge
        public Student(string name, int levelOfKnowledge)  : base(levelOfKnowledge)
        {
            _name = name;
            SetKnowledge(levelOfKnowledge);
            PersonsBase.AddPersonToBase(this);
        }

        // Getters

        public string GetName()
        {
            return _name;
        }
    }
}