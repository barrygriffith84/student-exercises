using System;
using System.Collections.Generic;

namespace student_exercises
{

    public class Instructor
    {

        public Instructor(string firstNameParam, string lastNameParam)
        {
            FirstName = firstNameParam;
            LastName = lastNameParam;
        }

        public string FirstName { get; set;}

        public string LastName { get; set;}

        public int Id { get; set;}


        public string SlackHandle { get; set; }

        public int CohortId { get; set; }

         public Cohort Cohort { get; set; }

        public string Specialty { get; set; }

        public List<Exercise> ExerciseList = new List<Exercise>();

        public void AssignExerciseToStudent(Student victim, Exercise exerciseToAssign){

            victim.AssignedExercises.Add(exerciseToAssign);

            exerciseToAssign.assignedStudents.Add(victim);
    }
}