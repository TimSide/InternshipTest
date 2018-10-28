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
            // Create universities
            var chdtu = new University("Черкаський державний технолонічний університет");
            var chnu = new University("Черкаський національний університет");
            var bk = new University("Черкаський державний бізнес-коледж");
            
            // Create student - First way    (Without setting knowledge)
            var timofyiSide = new Student("Timofyi Kirkicha");
            timofyiSide.SetKnowledge(85);
            
            // Create student - Second way   (With setting knowledge)
            var mariaKarpova = new Student("Maria Karpova", 72);
            var petroPoroshenko = new Student("Petro Poroshenko", 78);
            var donaldTrump = new Student("Donald Trump", 92);
            var olegLyashko = new Student("Oleg Lyashko", 50);
            var igorVovk = new Student("Igor Vovk", 63);
            
            // Add students to universities
            chdtu.AddStudents(timofyiSide, mariaKarpova, donaldTrump, olegLyashko, igorVovk);
            chnu.AddStudents(petroPoroshenko,donaldTrump);
            
            // Get students from certain university
            chdtu.PrintStudents();
            chnu.PrintStudents();
            bk.PrintStudents();
            
            // Print all students in base
            PersonsBase.GetAllStudentsFromBase();

            // Create InterLink internship
            var interLink = new Internship("Interlink - InCamp");
            
    // !!!====ENTER your knowledge requirements here===!!!
            Console.Write("\n\nENTER your knowledge requirements here = ");
            var knowledgeRequirements = Convert.ToInt16(Console.ReadLine());
            
            // Formation of a list of students by level of knowledge
            interLink.FormationInterns(PersonsBase.GetAllStudentsFromBase(), knowledgeRequirements);
            
            // Congratulations for these students ;)
            interLink.PrintStudentsOfInternship();
        }
    }
}
