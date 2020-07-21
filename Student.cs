using System;
using System.Collections.Generic;

namespace student_exercises
{

    public class Student
    {

       
        public Student(string firstNameParam, string lastNameParam, string slackParam)
        {
            
            FirstName = firstNameParam;
            LastName = lastNameParam;
            SlackHandle = slackParam;
        }

        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Id { get; set; }

        public string SlackHandle { get; set; }

        public int CohortId { get; set; }

        public int Grade { get; set; }

        public Cohort Cohort {get; set;}

        public List<Exercise> AssignedExercises {get; set;} = new List<Exercise>();


    }
}