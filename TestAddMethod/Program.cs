using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAddMethod {
	public class Program {
		public static int Add(string nbrs) {
			var strArray = nbrs.Split(',');

			List<int> ints = new List<int>();
			foreach(var str in strArray) {
				int i;
				var success = int.TryParse(str, out i);
				if(!success) {
					Console.WriteLine("Some term is not an integer");
					return -1;
				}
				ints.Add(i);

			}
			var sum = ints.Sum();
			return sum;
		}
		public static int Multiply(string nbrs) {
			var strArray = nbrs.Split(',');

			List<int> ints = new List<int>();
			foreach(var str in strArray) {
				int i;
				var success = int.TryParse(str, out i);
				if(!success) {
					Console.WriteLine("Some term is not an integer");
					return -1;
				}
				ints.Add(i);
			}

			var sum = 1;
				foreach(var i in ints) {
				sum *= i;
			}
			return sum;
		}

		static void Main(string[] args) {

			Console.WriteLine($"Enter numbers to add:");
			var response = Console.ReadLine();
			var answer = Multiply(response);
			Console.WriteLine($"Add({response}) is {answer}");

		}
	}
}
