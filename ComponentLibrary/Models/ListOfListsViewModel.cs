using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComponentLibrary.Models
{
	public class ListOfListsViewModel
	{
		public List<int> TotalList { get; private set; }

		/// <summary>
		/// puts all lists together and sorts result
		/// </summary>
		/// <param name="totalList"></param>
		public ListOfListsViewModel(List<List<int>> totalList)
		{
			TotalList = new List<int>();
			totalList.ForEach(item => TotalList.AddRange(item));
			TotalList.Sort();
		}

		private List<int> GetDistincts()
		{
			return TotalList.Distinct().ToList();
		}

		public string GetResultString()
		{
			StringBuilder result = new StringBuilder();
			GetDistincts().ForEach(item => result.Append(",").Append(item));
			return result.Remove(0, 1).ToString();
		}
	}
}
