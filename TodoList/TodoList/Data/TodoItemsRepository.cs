using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Data
{
    public class TodoItemsRepository
    {
      
        public List<TodoItem> GetList()
        {
            return Data.TodoList.OrderBy(m => m.CompleteOn).ThenByDescending(m => m.Priority).ToList();
        }

        public TodoItem GetItem(int id)
        {
            foreach (var item in Data.TodoList)
            {
                if (id == item.Id)
                {
                    return item;
                }
            }
            return null;
        }

        public void AddItem (TodoItem item)
        {
            int nextId;
            if (Data.TodoList.Count != 0)
            {
                nextId = Data.TodoList.Max(c => c.Id) + 1;
            }
            else
            {
                nextId = 1;
            }
            item.Id = nextId;
            Data.TodoList.Add(item);
            return;
        }

        internal void UpdateItem(TodoItem item)
        {
            int itemIndex = Data.TodoList.FindIndex(m => m.Id == item.Id);

            if(itemIndex == -1)
            {
                throw new Exception($"{item.Id} couldn't be found in our system.");
            }
            else
            {
                Data.TodoList[itemIndex] = item;
            }
            return;
        }

        internal void DeleteItem(int id)
        {
            int itemIndex = Data.TodoList.FindIndex(m => m.Id == id);

            if (itemIndex == -1)
            {
                throw new Exception($"Can't find the file you're looking for, Please try a new search");
            }
            else
            {
                Data.TodoList.RemoveAt(itemIndex);
            }
            return;
        }
    }
}
