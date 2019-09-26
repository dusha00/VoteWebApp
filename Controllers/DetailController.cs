using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VoteWebApp.Models;
using VoteWebApp.Repository;

namespace VoteWebApp.Controllers
{
    public class DetailController : Controller
    {
        private readonly CommentRepository _commentRepository;
        public DetailController(CommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Content(IFormCollection form)
        {
            CommentModel model = new CommentModel();
            model.TopicID = 2;
            model.Content = Request.Form["content"];
            model.CreateTime = DateTime.Now;
            _commentRepository.Add(model);
            return View("Index");
        }
    }
}