using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            [Display(Name ="In Progress")]
            InProgress,
            [Display(Name ="Not Started")]
            NotStarted,
            Suspended
        }

        public int Id { get; internal set; }

        [Required, Display(Name = "Added on"), DisplayFormat(DataFormatString ="{0:d}")]
        public DateTime CreatedOn { get; set; }

        [Required, Display(Name = "Task")]
        public string Objective { get; set; }

        [Required, Display(Name = "Complete By"), DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime CompleteOn { get; set; }
        public PriorityLevel Priority { get; set; }
        public StatusOption Status { get; set; }

        public TodoItem()
        {

        }

        public TodoItem(int id, DateTime createdOn, string objective, DateTime completeOn, PriorityLevel priority, StatusOption status)
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
