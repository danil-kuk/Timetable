using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IzhCloud_Timetable.Models;
using IzhCoil_Timetable.Models;
using Microsoft.AspNetCore.Http;
using IzhCloud_Timetable.Models.Entities;

namespace IzhCloud_Timetable.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EFDBContext _context;

        public HomeController(ILogger<HomeController> logger, EFDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Entries.ToList();
            return View(model);
        }

        public IActionResult Edit()
        {
            TempData["mode"] = "edit";
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Save(string[] data)
        {
            var today = DateTime.Today;
            for (int dayIndex = 0; dayIndex < 10; dayIndex++)
            {
                var date = today.AddDays(dayIndex);
                var isEmpty = true;
                for (int i = 0; i < 8; i++)
                {
                    if (data[dayIndex * 8 + i] != null)
                    {
                        isEmpty = false;
                        break;
                    }
                }
                var checkEntry = _context.Entries.Where(d => d.Date == date).FirstOrDefault();
                if (checkEntry == default)
                {
                    if (isEmpty)
                        continue;
                    var dayEntry = new Day
                    {
                        Date = date,
                        FirstFirst = data[dayIndex * 8 + 0],
                        FirstSecond = data[dayIndex * 8 + 1],
                        SecondFirst = data[dayIndex * 8 + 2],
                        SecondSecond = data[dayIndex * 8 + 3],
                        ThirdFirst = data[dayIndex * 8 + 4],
                        ThirdSecond = data[dayIndex * 8 + 5],
                        FourthFirst = data[dayIndex * 8 + 6],
                        FourthSecond = data[dayIndex * 8 + 7]
                    };
                    _context.Entries.Add(dayEntry);
                }
                else
                {
                    checkEntry.FirstFirst = data[dayIndex * 8 + 0];
                    checkEntry.FirstSecond = data[dayIndex * 8 + 1];
                    checkEntry.SecondFirst = data[dayIndex * 8 + 2];
                    checkEntry.SecondSecond = data[dayIndex * 8 + 3];
                    checkEntry.ThirdFirst = data[dayIndex * 8 + 4];
                    checkEntry.ThirdSecond = data[dayIndex * 8 + 5];
                    checkEntry.FourthFirst = data[dayIndex * 8 + 6];
                    checkEntry.FourthSecond = data[dayIndex * 8 + 7];
                    _context.Entries.Update(checkEntry);
                }
            }
            TempData["mode"] = "";
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
