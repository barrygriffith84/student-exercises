using System;
using System.Collections.Generic;

namespace student_exercises
{

    public class Student : Person
    {

       
        public Student(string firstNameParam, string lastNameParam, string slackParam)
        {
            
            FirstName = firstNameParam;
            LastName = lastNameParam;
            SlackHandle = slackParam;
        }

        
        

        public int Grade { get; set; }

      

        public List<Exercise> AssignedExercises {get; set;} = new List<Exercise>();


    }
}