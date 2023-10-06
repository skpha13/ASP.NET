using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
	internal class Course
	{
		public string name { get; set; }
		public int nrOfCredits { get; set; }
		public int nrOfHours { get; set; }
		public string professor { get; set; }	

		public override String ToString()
		{
			return string.Format("Course name: {0}\nProfessor: {1}\nNumber of credits: {2}\nNumber of hours: {3}\n", name, professor, nrOfCredits, nrOfHours);
		}
	}
}
