using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Data
{
    public class Data
    {
        public static List<TodoItem> TodoList { get; set; }

        static Data()
        {
            InitiateDate();
        }

        private static void InitiateDate()
        {
            var todoList = new List<TodoItem>()
            {
                new TodoItem
                (
                    1, 
                    DateTime.Today,
                    "Finish this website",
                    DateTime.Today.AddDays(1),
                    TodoItem.PriorityLevel.High,
                    TodoItem.StatusOption.InProgress
                ),
                new TodoItem
                (
                    2,
                    DateTime.Today,
                    "Continue working on Ecan website",
                    DateTime.Today.AddDays(3),
                    TodoItem.PriorityLevel.Medium,
                    TodoItem.StatusOption.Suspended
                )
            };
            TodoList = todoList;
        }
    }
}
