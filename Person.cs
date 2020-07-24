using System;
using System.Collections.Generic;

namespace student_exercises
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Id { get; set; }

        public string SlackHandle { get; set; }

        public int CohortId { get; set; }

        public Cohort Cohort { get; set; }

    }

}