using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
	internal class Student
	{
		public static int idCounter { get; set; } = 0;
		public int id { get; set; }
		public string lastName { get; set; }
		public string firstName { get; set; }
		public string dateOfBirth { get; set; }
		public List<Course> courses { get; set; }

		public Student()
		{
			id = idCounter++;
			courses = new List<Course>();
		}

		// ToString override
		public void WriteLine()
		{
			Console.WriteLine(string.Format("ID: {0}\nFirst Name: {1}\nLast Name: {2}\nDate of birth: {3}\n", id, firstName, lastName, dateOfBirth));
			if(courses.Count > 0 ) {
				Console.WriteLine($"\tCourses for student with ID:{id}\n");
				for (int i = 0; i < courses.Count; i++)
				{
					Console.WriteLine(courses[i]);
				}
			}
			else Console.WriteLine("No current courses");
			
		}
		public override String ToString()
		{
			return string.Format("ID: {0}\nFirst Name: {1}\nLast Name: {2}\nDate of birth: {3}\n", id, firstName, lastName, dateOfBirth);
		}
	}
}
