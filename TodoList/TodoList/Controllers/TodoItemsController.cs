using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoList.Data;
using TodoList.Models;

namespace TodoList.Controllers
{
    public class TodoItemsController : Controller
    {
        private TodoItemsRepository _todoItemsRepository;

        public TodoItemsController()
        {
            _todoItemsRepository = new TodoItemsRepository();
        }
        public IActionResult Items()
        {
            var todoItem = _todoItemsRepository.GetList();
            return View(todoItem);
        }

        public IActionResult Add()
        {
            var item = new TodoItem()
            {
                CreatedOn = DateTime.Today.ToShortDateString(),
                CompleteOn = DateTime.Today.AddDays(1).ToShortDateString()
            };
            return View(item);
        }

        [HttpPost]
        public IActionResult Add(TodoItem item)
        {
            if (ModelState.IsValid)
            {
                _todoItemsRepository.AddItem(item);

                return RedirectToAction("items");
            }
            return View(item);
        }
    }
}