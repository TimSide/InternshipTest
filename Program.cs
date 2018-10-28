using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var chdtu = new University("Черкаський державний технолонічний університет");
            var chnu = new University("Черкаський національний університет");
            var bk = new University("Черкаський державний бізнес-коледж");

            // Create student - First way
            var timofyiSide = new Student("Timofyi Side");
            timofyiSide.SetKnowledge(85);

            // Create student - Second way
            var mariaKarpova = new Student("Maria Karpova", 72);
            var petroPoroshenko = new Student("Petro Poroshenko", 78);
            var donaldTrump = new Student("Donald Trump", 82);

            // Add students to universities
            chdtu.AddStudents(timofyiSide, mariaKarpova, donaldTrump);
            chnu.AddStudents(petroPoroshenko, donaldTrump);

            Console.WriteLine(chdtu.GetStudents());


//            var s = new Student("Alex");
//            University university = new University("CH.U.I.");
//            university.AddStudent(new Student("Andrew Kostenko"));
//            university.AddStudent(new Student("Julia Veselkina"));
//            university.AddStudent(new Student("Maria Perechrest"));
//
//            Internship internship = new Internship("Interlink");
//            Console.WriteLine("List of internship's students:");
//            Console.WriteLine(internship.GetStudents());
        }
    }
}