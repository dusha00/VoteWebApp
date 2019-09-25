using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VoteWebApp.Common;
using VoteWebApp.Models;

namespace VoteWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly VoteClient _voteClient;
        public HomeController(VoteClient voteClient)
        {
            _voteClient = voteClient;
        }
        public async Task<IActionResult> Index()
        {
            //var res = await _voteClient.LoadData();
            DapperHelper.test();
            List<Person> list = new List<Person>();
            list.Add(new Person() { Name = "David" });
            list.Add(new Person() { Name = "LiLei" });
            list.Add(new Person() { Name = "HanMeiMei" });
            list.Add(new Person() { Name = "David" });
            list.Add(new Person() { Name = "LiLei" });
            list.Add(new Person() { Name = "HanMeiMei" });
            list.Add(new Person() { Name = "David" });
            list.Add(new Person() { Name = "LiLei" });
            list.Add(new Person() { Name = "HanMeiMei" });
            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
