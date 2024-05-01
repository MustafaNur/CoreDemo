using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        
        Message2Manager mm = new Message2Manager(new EfMessage2Rpository());
        
        public IActionResult InBox()
        {
            int id = 1;
            var values = mm.GetInboxListByWriter(id);
            return View(values);
        }
    }
}
