using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ComponentLibrary.Models
{
	public class ListOfListsViewModel
	{
		public List<int> TotalList { get; private set; }

		/// <summary>
		/// puts all lists together and generates result string
		/// </summary>
		/// <param name="totalList"></param>
		public ListOfListsViewModel(List<List<int>> totalList)
		{
			TotalList = new List<int>();
			totalList.ForEach(item => TotalList.AddRange(item));
			TotalList.Sort();
		}

		private List<int> GetSortedDistincts()
		{
			return TotalList.Distinct().ToList();
		}

		public string GetResultString()
		{
			StringBuilder result = new StringBuilder();
			GetSortedDistincts().ForEach(item => result.Append(",").Append(item));
			return result.Remove(0, 1).ToString();
		}
	}
}
