using System;

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


            Instructor jordan = new Instructor("Jordan", "Castelloe"){
                Specialty = "Explaining things"
            };
            Instructor tommy = new Instructor("Tommy", "Spurlock"){
                Specialty = "Motivating the class"
            };
            Instructor jacob = new Instructor("Jacob", "Perry"){
                Specialty = "Giving presentations"
            };

jordan.AssignExerciseToStudent(austin, dailyJournal);
jordan.AssignExerciseToStudent(sarah, dailyJournal);
tommy.AssignExerciseToStudent(derekM, nutshell);
tommy.AssignExerciseToStudent(devin, nutshell);
jacob.AssignExerciseToStudent(sarah, calculator);
jacob.AssignExerciseToStudent(devin, personalWebsite);




Console.WriteLine();



        }
    }
}
