// See https://aka.ms/new-console-template for more information
using Homework01;

List<Course> courses = new List<Course>();
courses.Add(new Course());
courses.Add(new Course());

Student x = new Student
{
	firstName = "Adrian",
	lastName = "Mincu",
	dateOfBirth = "13.06.2003",
	courses = courses
};

x.WriteLine();
