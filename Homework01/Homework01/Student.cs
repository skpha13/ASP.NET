using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
	internal class Student
	{
		private static int idCounter = 0;
		private int id;
		private string lastName;
		private string firstName;
		private string dateOfBirth;
		private List<Course> courses;

		public Student(string firstName = "Unnamed", string lastName = "Unnamed", string dateOfBirth = "Unknown", List<Course> courses = default) { 
			this.lastName = lastName;
			this.firstName = firstName;	
			this.dateOfBirth = dateOfBirth;
			this.id = idCounter++;
			this.courses = courses;
		}

		// getters and setters with property
		public string LastName { 
			get { return lastName; }
			set { this.lastName = value; }
		}
		public string FirstName
		{
			get { return firstName; }
			set { this.firstName= value; }
		}
		public string DateOfBirth
		{
			get { return dateOfBirth; }
			set { this.dateOfBirth = value; }
		}
		public int ID
		{
			get { return id; }
		}
		public List<Course> Courses { get { return courses; } }

		// ToString override
		public void WriteLine()
		{
			Console.WriteLine(string.Format("ID: {0}\nFirst Name: {1}\nLast Name: {2}\nDate of birth: {3}\n", id, firstName, lastName, dateOfBirth));
			Console.WriteLine($"\tCourses for student with ID:{id}\n");
			for (int i = 0; i < courses.Count; i++)
			{
				Console.WriteLine(courses[i]);
			}
		}
		public override String ToString()
		{
			return string.Format("ID: {0}\nFirst Name: {1}\nLast Name: {2}\nDate of birth: {3}\n", id, firstName, lastName, dateOfBirth);
		}
	}
}
