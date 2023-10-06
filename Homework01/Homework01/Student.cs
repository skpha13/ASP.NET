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

		public Student(string lastName = "Unnamed", string firstName = "Unnamed", string dateOfBirth = "Unknown") { 
			this.lastName = lastName;
			this.firstName = firstName;	
			this.dateOfBirth = dateOfBirth;
			this.id = idCounter++;
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

		// ToString override
		public override String ToString()
		{
			return string.Format("ID: {0}\nFirst Name: {1}\nLast Name: {2}\nDate of birth: {3}\n",id,firstName,lastName,dateOfBirth);
		}
	}
}
