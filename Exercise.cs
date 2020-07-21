using System;
using System.Collections.Generic;

namespace student_exercises
{

    public class Exercise
    {

        public Exercise(string nameParam)
        {
            Name = nameParam;
        }

        public string Name { get; set; }

        public int Id { get; set; }

        public string Langauge { get; set; }

        public List<Student> assignedStudents { get; set; } = new List<Student>();
    }
}