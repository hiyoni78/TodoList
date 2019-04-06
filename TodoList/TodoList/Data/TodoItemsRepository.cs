﻿using System;
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
            return Data.TodoList;
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
            int nextId = Data.TodoList.Max(c => c.Id) + 1;
            item.Id = nextId;
            Data.TodoList.Add(item);
            return;
        }
    }
}
