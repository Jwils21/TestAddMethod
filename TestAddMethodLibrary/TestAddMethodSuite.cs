using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAddMethod;

namespace TestAddMethodLibrary {

	[TestClass]
	public class TestAddMethodSuite {

		[TestMethod]
		public void TestAdd() {
			var test4 = "a,2";
			var actual = Program.Add(test4);
			Assert.AreEqual(-1, actual);


			var test5 = "2,3";
			actual = Program.Add(test5);
			Assert.AreEqual(4, actual);

		}
		[TestMethod]
		public void TestMore() {
			var str = "";
			var result = Program.Add(str);
			Assert.AreEqual(-1, result);
		}

	}
}
