// See https://aka.ms/new-console-template for more information
using Homework01;

List<Course> courses = new List<Course>();
courses.Add(new Course());
courses.Add(new Course());

Student x = new Student("x","y","z",courses);

x.WriteLine();