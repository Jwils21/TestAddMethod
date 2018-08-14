using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAddMethod;

namespace TestAddMethodLibrary {
	[TestClass]
	public class TestMultMethod {
		[TestMethod]
		public void TestMult() {
			var str = "2,3,4";
			var result = Program.Multiply(str);
			Assert.AreEqual(24, result, "The answer is not 24");
		}

	}
}
