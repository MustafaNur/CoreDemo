using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class RegisterController : Controller
	{
		/*
          Ekleme işlemi yapılırken httpget ile httppost attributelerinin tanımlandığı metotların isimleri aynı olmak zorundadır
          HttpGet -> Sayfa Yüklenince
          HttpPost-> Sayfa buton tetiklenince
         */
		
		WriterManager wm = new WriterManager(new EfWriterRepository());
		[HttpGet]
		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Writer p)
		{
			p.WriterStatus = true;
			p.WriterAbout = "DEneme Test";
			wm.WriterAdd(p);
			return RedirectToAction("Index","Blog");
		}
	}
}
