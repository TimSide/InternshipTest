# InternshipTest
Test task for entering InCamp internship

1. Class Students extend class Knowledge - because all students have knowledge
2. When we create instance of the class Student (enter name, level of knowledge), it added to PersonsBase.
  PersontBase - is a class that contains all the created Students. This class is designed to easily get all created students.
3. Class Internships have a list of interns (_interns) and method FormationInterns(), that gets list of all students (from PersonsBase)
  and value of minimal knowledge (int knowledgeMinLevel). This method (FormationInterns() ) forms a list of students who can be admitted to an internship,
  with their level of knowledge.
