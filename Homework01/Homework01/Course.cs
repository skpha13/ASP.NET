using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
	internal class Course
	{
		private string name;
		private int nrOfCredits;
		private int nrOfHours;
		private string professor;

		public Course(string name = "Unnamed", int nrOfCredits = 0, int nrOfHours = 0, string professor = "Unknown") {
			this.name = name;
			this.nrOfCredits = nrOfCredits;
			this.nrOfHours = nrOfHours;
			this.professor = professor;
		}	

		// getters and setters
		public string Name {  get { return name; } set { this.name = value; } }
		public int NrOfCredits {  get { return nrOfCredits; } set { this.nrOfCredits = value; } }
		public int NrOfHours{  get { return nrOfHours; } set { this.nrOfHours = value; } }
		public string Professor{  get { return professor; } set { this.professor = value; } }

		public override String ToString()
		{
			return string.Format("Course name: {0}\nProfessor: {1}\nNumber of credits: {2}\nNumber of hours: {3}\n", name, professor, nrOfCredits, nrOfHours);
		}
	}
}
