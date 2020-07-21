using System;
using System.Collections.Generic;
using System.Linq;

namespace student_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise dailyJournal = new Exercise("Daily Journal")
            {
                Langauge = "JavaScript"
            };
            Exercise nutshell = new Exercise("Nutshell")
            {
                Langauge = "JavaScript"
            };
            Exercise personalWebsite = new Exercise("Personal Website")
            {
                Langauge = "JavaScript"
            };
            Exercise calculator = new Exercise("Calculator")
            {
                Langauge = "JavaScript"
            };

            Cohort cohortOne = new Cohort("Cohort One");
            Cohort cohortTwo = new Cohort("Cohort Two");
            Cohort cohortThree = new Cohort("Cohort Three");

            Student austin = new Student("Austin", "Preece", "@RestInPreece")
            {
                Cohort = cohortThree
            };

            cohortThree.StudentList.Add(austin); 

            Student sarah = new Student("Sarah", "Brooks", "@BookBurner")
            {
                Cohort = cohortThree
            };

            cohortThree.StudentList.Add(sarah); 

            Student derekM = new Student("Derek", "Mayse", "@GordGuy666")
            {
                Cohort = cohortThree
            };

            cohortThree.StudentList.Add(derekM); 

            Student devin = new Student("Devin", "Conroy", "@Tall&Handsome")
            {
                Cohort = cohortThree
            };

            cohortThree.StudentList.Add(devin);

            Student sydney = new Student("Sydney", "Wait", "@TrailRunner")
            {
                Cohort = cohortOne
            };
          

            cohortOne.StudentList.Add(sydney); 

               Student jen = new Student("Jen", "Johnson", "@TeachersAide")
            {
                Cohort = cohortTwo
            };

            cohortTwo.StudentList.Add(jen); 


            Instructor jordan = new Instructor("Jordan", "Castelloe"){
                Specialty = "Explaining things",
                Cohort = cohortOne
            };
            Instructor tommy = new Instructor("Tommy", "Spurlock"){
                Specialty = "Motivating the class",
                Cohort = cohortTwo
            };
            Instructor jacob = new Instructor("Jacob", "Perry"){
                Specialty = "Giving presentations",
                Cohort = cohortThree
            };

jordan.AssignExerciseToStudent(austin, dailyJournal);
jordan.AssignExerciseToStudent(sarah, dailyJournal);
jordan.AssignExerciseToStudent(sarah, nutshell);
tommy.AssignExerciseToStudent(derekM, nutshell);
tommy.AssignExerciseToStudent(devin, nutshell);
jacob.AssignExerciseToStudent(sarah, calculator);
jacob.AssignExerciseToStudent(devin, personalWebsite);

List<Student> students = new List<Student>() {
  austin,
  sarah,
  derekM,
  devin,
  sydney,
  jen
};

List<Exercise> exercises = new List<Exercise>() {
  dailyJournal,
  nutshell,
  calculator,
  personalWebsite
};

List<Instructor> instructors = new List<Instructor>() {
  jordan,
  tommy,
  jacob
};

List<Cohort> cohorts = new List<Cohort>(){
    cohortOne,
    cohortTwo,
    cohortThree
};


exercises.Where(exercise => exercise.Langauge == "JavaScript").ToList().ForEach(exercise => Console.WriteLine(exercise.Name));
Console.WriteLine();
students.Where(student => student.Cohort == cohortOne).ToList().ForEach(student => Console.WriteLine($"{student.FirstName} {student.LastName}"));
Console.WriteLine();
instructors.Where(instructor => instructor.Cohort == cohortOne).ToList().ForEach(instructor => Console.WriteLine(instructor.FirstName));
Console.WriteLine();
students.OrderBy(student => student.LastName).ToList().ForEach(student => Console.WriteLine(student.LastName));
Console.WriteLine();
students.Where(student => student.AssignedExercises.Count() == 0).ToList().ForEach(student => Console.WriteLine(student.FirstName));
Console.WriteLine();

Console.WriteLine(students.Where(student => student.AssignedExercises.Count() == students.Max(student => student.AssignedExercises.Count())).ToList()[0].FirstName);

cohorts.ForEach(cohort => Console.WriteLine(cohort.StudentList.Count()));





        }
    }
}
