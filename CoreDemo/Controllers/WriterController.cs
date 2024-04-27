﻿using BusinessLayer.Concrete;
using CoreDemo.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;

namespace CoreDemo.Controllers
{
	public class WriterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());
        
        [Authorize]
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult WriterProfile()
		{
			return View();
		}
		public IActionResult WriterMail()
		{
			return View();
		}
		
		public IActionResult Test()
		{
			return View();
		}
       
        public PartialViewResult WriterSidebar()
		{
			return PartialView();
		}
       
        public PartialViewResult WriterFooterPartial()
		{
			return PartialView();
		}
        
		[HttpGet]
		public IActionResult WriterEditProfile()
		{
            Context c = new Context();
            var username = User.Identity.Name;
			var usermail = c.Users.Where(x=>x.UserName == username).Select(y=>y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var writervalues = wm.TGetById(writerID);

			return View(writervalues);
		}
        
        [HttpPost]
		public IActionResult WriterEditProfile(Writer p)
		{
			wm.TUpdate(p);
			return RedirectToAction("Index", "Dashboard");
		}
        
		[HttpGet]
		public IActionResult WriterAdd()
		{
			return View();
		}
        
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
			Writer w = new Writer();
			if (p.WriterImage != null)
			{
				var extension = Path.GetExtension(p.WriterImage.FileName);
				var newimagename = Guid.NewGuid()+extension;
				var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newimagename);
				var stream = new FileStream(location, FileMode.Create);
				p.WriterImage.CopyTo(stream);
				w.WriterImage = newimagename;
			}
			w.WriterMail = p.WriterMail;
			w.WriterName = p.WriterName;
			w.WriterPassword= p.WriterPassword;
			w.WriterStatus= p.WriterStatus;
			w.WriterAbout= p.WriterAbout;
			wm.TAdd(w);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
