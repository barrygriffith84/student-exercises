using System;
using System.Collections.Generic;

namespace student_exercises
{

    public class Cohort
    {

        public Cohort(string nameParam)
        {
            Name = nameParam;
        }

        public string Name { get; set;}

        public int Id {get; set;}
       

        
        public List<Student> StudentList = new List<Student>();
        public List<Instructor> InstructorList = new List<Instructor>();



    }

}