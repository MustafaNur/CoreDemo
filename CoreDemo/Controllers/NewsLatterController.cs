using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	[AllowAnonymous]
	public class NewsLatterController : Controller
	{
		NewsLatterManager nm = new NewsLatterManager(new EfNewsLatterRepository());
		[HttpGet]
		public PartialViewResult SubscribeMail()
		{
			return PartialView();
		}
		[HttpPost]
		public IActionResult SubscribeMail(NewsLatter p)
		{
			p.MailStatus = true;
			nm.AddNewsLatter(p);
			return RedirectToAction("Index", "Blog");
        }
	}
}
