using System.Collections.Generic;
using System.Threading.Tasks;
using ComponentLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComponentLibrary.Components
{
	public class ListComponent : ViewComponent
	{
		public IViewComponentResult Invoke(List<List<int>> lists)
		{
			return View((new ListOfListsViewModel(lists)).GetResultString());
		}
	}
}
