using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Models
{
    public class TodoItem
    {
        public enum PriorityLevel
        {
            Low,
            Medium,
            High
        }

        public enum StatusOption
        {
            Completed,
            InProgress,
            NotStarted,
            Suspended
        }

        public int Id { get; internal set; }
        public string CreatedOn { get; set; }
        public string Objective { get; set; }
        public string CompleteOn { get; set; }
        public PriorityLevel Priority { get; set; }
        public StatusOption Status { get; set; }

        public TodoItem()
        {

        }

        public TodoItem(int id, string createdOn, string objective, string completeOn, PriorityLevel priority, StatusOption status)
        {
            Id = id;
            CreatedOn = createdOn;
            Objective = objective;
            CompleteOn = completeOn;
            Priority = priority;
            Status = status;
        }
    }
}
