using System;
using System.Collections.Generic;

namespace student_exercises
{

    public class Instructor : Person
    {

        public Instructor(string firstNameParam, string lastNameParam)
        {
            FirstName = firstNameParam;
            LastName = lastNameParam;
        }


        public string Specialty { get; set; }

        public List<Exercise> ExerciseList = new List<Exercise>();

        public void AssignExerciseToStudent(Student victim, Exercise exerciseToAssign){

            victim.AssignedExercises.Add(exerciseToAssign);

            exerciseToAssign.assignedStudents.Add(victim);
    }
}
}