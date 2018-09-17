using System.Collections.Generic;
using System.Threading.Tasks;
using ComponentLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComponentLibrary.ViewComponents
{
	public class ListViewComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync(List<List<int>> lists)
		{
			return View(await Task.FromResult((new ListOfListsViewModel(lists)).GetResultString()));
		}
	}
}
