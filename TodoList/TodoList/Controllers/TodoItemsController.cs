using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoList.Data;

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
            var todoItem = _todoItemsRepository.GetTodoItem();
            return View(todoItem);
        }

        public IActionResult Add()
        {
            return View();
        }

        [ActionName("Add"), HttpPost]
        public IActionResult AddPost()
        {
            return View();
        }
    }
}