using System;
using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest
{
    /*    This class contains all persons (Students)
     *    that were created in the program
     */
    public static class PersonsBase
    {
        // This is the base
        private static readonly List<Student> PersonBase = new List<Student>();

        // Add person to base
        public static void AddPersonToBase(Student student)
        {
            PersonBase.Add(student);
//            Console.WriteLine("Student " + student.GetName() + " added to Base");
        }

        // Returns all persons (students) from base
        public static List<Student> GetAllStudentsFromBase()
        {
            return PersonBase;
        }
        
        //===========
        // Print all persons (students) from base  (!!! Command prompt only)
        public static void PrintAllStudentsFromBase()
        {
            Console.WriteLine("\n=========STUDENT BASE=========");
            foreach (var student in PersonBase)
            {
                Console.WriteLine("Name " + student.GetName() + "; knowledge = " + student.GetKnowledge());
            }
        }
    }
}