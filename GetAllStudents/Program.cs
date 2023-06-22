using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GetAllStudents
{
	class Program
	{
		static void Main(string[] args)
		{
			var classes = new[]
			{
			   new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
			   new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
			   new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
		   };
			var allStudents = GetAllStudents(classes);

			Console.WriteLine(string.Join(" ", allStudents));
		}

		static string[] GetAllStudents(Classroom[] classes)
		{

			var students = classes.SelectMany(e => e.Students).ToArray();

			return students;
		}

		public class Classroom
		{
			public List<string> Students = new List<string>();
		}
	}
}
