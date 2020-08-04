--create table Cohort (
--	Id integer not null primary key identity,
--	Name varchar(55) not null
--);

--create table Exercise (
--	Id integer not null primary key identity,
--	Name varchar(55) not null,
--	Language varchar(55) not null
--);

--create table Instructor (
--	Id integer not null primary key identity,
--	FirstName varchar(55) not null,
--	LastName varchar(55) not null,
--	SlackHandle varchar(55) not null,
--	Specialty varchar(55) not null,
--	CohortId integer not null,
--	constraint FK_Instructor_Cohort foreign key(CohortId) references Cohort(Id)
--);

--create table Student (
--	Id integer not null primary key identity,
--	FirstName varchar(55) not null,
--	LastName varchar(55) not null,
--	SlackHandle varchar(55) not null,
--	CohortId integer not null,
--	constraint FK_Student_Cohort foreign key(CohortId) references Cohort(Id)
--);

--create table ExerciseStudent (
--	Id integer not null primary key identity,
--	ExerciseId integer not null,
--	StudentId integer not null,
--	constraint FK_ExerciseStudent_Exercise foreign key(ExerciseId) references Exercise(Id),
--	constraint FK_ExerciseStudent_Student foreign key(StudentId) references Student(Id)
--);

---- Add some data to the tables
--insert into Cohort (Name) values ('Cohort 1');
--insert into Cohort (Name) values ('Cohort 2');
--insert into Cohort (Name) values ('Cohort 3');

--insert into Exercise (Name, Language) values ('Calculator', 'JavaScript');
--insert into Exercise (Name, Language) values ('Daily Journal', 'JavaScript');
--insert into Exercise (Name, Language) values ('Nutshell', 'JavaScript');
--insert into Exercise (Name, Language) values ('Plan Your Heist', 'C#');
--insert into Exercise (Name, Language) values ('Generics', 'C#');

--insert into Instructor (FirstName, LastName, SlackHandle, Specialty, CohortId) values ('Jordan', 'Castelloe', '@BearWatcher', 'Explaining complicated things', 1);
--insert into Instructor (FirstName, LastName, SlackHandle, Specialty, CohortId) values ('Tommy', 'Spurlock', '@TommyTerrific', 'Motivating students', 2); 
--insert into Instructor (FirstName, LastName, SlackHandle, Specialty, CohortId) values ('Jen', 'Johnson', '@NewGurl', 'Setting examples', 3); 
--insert into Instructor (FirstName, LastName, SlackHandle, Specialty, CohortId) values ('Kim', 'Preece', '@AustinsMom', 'Putting people at east', 1);

--insert into Student (FirstName, LastName, SlackHandle, CohortId) values ('Sidney', 'Wait', '@TrailRunner', 1);
--insert into Student (FirstName, LastName, SlackHandle, CohortId) values ('Jacob', 'Perry', '@GiantGamer', 2);
--insert into Student (FirstName, LastName, SlackHandle, CohortId) values ('Devin', 'Conroy', '@TallAndHandsome', 3);
--insert into Student (FirstName, LastName, SlackHandle, CohortId) values ('Sarah', 'Brooks', '@BookBurner', 3);
--insert into Student (FirstName, LastName, SlackHandle, CohortId) values ('Austin', 'Preece', '@RestInPreece', 3);

--insert into ExerciseStudent (ExerciseId, StudentId) values (1, 1);
--insert into ExerciseStudent (ExerciseId, StudentId) values (2, 1);
--insert into ExerciseStudent (ExerciseId, StudentId) values (3, 2);
--insert into ExerciseStudent (ExerciseId, StudentId) values (4, 1);
--insert into ExerciseStudent (ExerciseId, StudentId) values (5, 3);
--insert into ExerciseStudent (ExerciseId, StudentId) values (1, 4);
--insert into ExerciseStudent (ExerciseId, StudentId) values (2, 5);
--insert into ExerciseStudent (ExerciseId, StudentId) values (1, 3);

--delete from ExerciseStudent where Id = 4;
--select * from ExerciseStudent;

--Write a query to return student first and last names with their cohort's name only for a single cohort.
--select Student.FirstName, Student.LastName, Cohort.Name from Student
--join Cohort on Cohort.Id = Student.CohortId
--where CohortId = 3;


--Write a query to return all instructors ordered by their last name. 
--select * from Instructor
--order by LastName;

--Write a query to return a list of unique instructor specialties.
--select distinct Specialty 
--from Instructor;

--Write a query to return a list of all student names along with the names of the exercises they have been assigned. If an exercise has not been assigned, it should not be in the result. 
--select Student.FirstName, Student.LastName, Exercise.Name
--from Student
--join ExerciseStudent on ExerciseStudent.StudentId = Student.Id 
--join Exercise on Exercise.Id = ExerciseStudent.ExerciseId;

--Return a list of student names along with the count of exercises assigned to each student.
--select Student.FirstName, Student.LastName, Count(*) as 'Number of Exercises'
--from Student
--join ExerciseStudent on ExerciseStudent.StudentId = Student.Id 
--join Exercise on Exercise.Id = ExerciseStudent.ExerciseId
--group by Student.FirstName, Student.LastName;

--select * from ExerciseStudent;







