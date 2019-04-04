using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Data
{
    public class TodoItemsRepository
    {
        public TodoItem GetTodoItem()
        {
            var firstItem = new TodoItem()
            {
                Id = DateTime.Now.ToShortDateString(),
                Objective = "Finish this project",
                CompleteOn = DateTime.Parse("2019-05-04").ToShortDateString()
            };
            return firstItem;
        }
    }
}
