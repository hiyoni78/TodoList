using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TodoList.Controllers
{
    public class TodoItemsController : Controller
    {
        public IActionResult Items()
        {
            return View();
        }
    }
}