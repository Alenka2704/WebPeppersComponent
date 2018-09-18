using System.Collections.Generic;
using ComponentLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComponentLibrary.ViewComponents
{
	public class ListViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke(List<List<int>> lists)
		{
			return View((new ListOfListsViewModel(lists)).GetResultString());
		}
	}
}
