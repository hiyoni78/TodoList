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
                    "Look for a job",
                    DateTime.Today.AddDays(1),
                    TodoItem.PriorityLevel.High,
                    TodoItem.StatusOption.InProgress
                ),
                new TodoItem
                (
                    2,
                    DateTime.Parse("04-01-2019"),
                    "Continue working on projects",
                    DateTime.Today.AddDays(3),
                    TodoItem.PriorityLevel.Medium,
                    TodoItem.StatusOption.InProgress
                ),
                new TodoItem
                (
                    3,
                    DateTime.Parse("02-15-2019"),
                    "Start Working out",
                    DateTime.Today.AddDays(12),
                    TodoItem.PriorityLevel.Low,
                    TodoItem.StatusOption.NotStarted
                ),
                new TodoItem
                (
                    4,
                    DateTime.Parse("12-24-2018"),
                    "Start a new course",
                    DateTime.Today.AddDays(3),
                    TodoItem.PriorityLevel.Medium,
                    TodoItem.StatusOption.Suspended
                ),
                new TodoItem
                (
                    5,
                    DateTime.Today,
                    "push updates to git hub",
                    DateTime.Today,
                    TodoItem.PriorityLevel.High,
                    TodoItem.StatusOption.InProgress
                )
            };
            TodoList = todoList;
        }
    }
}
