using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ComponentLibrary;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComponentTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Test_ComponentMethod()
		{
			List<List<int>> temp = new List<List<int>> {
				new List<int>() { 5, 8, 4 },
				new List<int>() { 9, 2, 5 },
				new List<int>() { 21, 3 },
				new List<int>() { 5, 8, 2, 1, 4 }
			};

			ComponentLibrary.Models.ListOfListsViewModel listOfListsView = new ComponentLibrary.Models.ListOfListsViewModel(temp);
			Assert.AreEqual(listOfListsView.GetResultString(), "1,2,3,4,5,8,9,21");
		}
	}
}
