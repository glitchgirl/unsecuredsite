using RSI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RSI.Controllers
{
    public class CommentsController : Controller
    {
        // GET: Comments
        public ActionResult Index()
        {
            var comment = new Comments() { CommentText ="test", UserId="test1"};
            return View(comment);
        }
    }
}