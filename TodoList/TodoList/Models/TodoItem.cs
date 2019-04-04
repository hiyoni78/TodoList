using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Models
{
    public class TodoItem
    {
        public DateTime Id { get; set; }
        public string Objective { get; set; }
        public DateTime CompleteOn { get; set; }
        public List<SelectListItem> Priority
        {
            get
            {
                return new List<SelectListItem> {
                    new SelectListItem { Text = "High", Value = "High" },
                    new SelectListItem { Text = "Medium", Value = "Medium" },
                    new SelectListItem { Text = "Low", Value = "Low" }
                };
            }
        }
        public List<SelectListItem> Status
        {
            get
            {
                return new List<SelectListItem>
                {
                    new SelectListItem { Text = "Completed", Value = "Completed" },
                    new SelectListItem { Text = "In progress", Value = "In progress" },
                    new SelectListItem { Text = "Not started", Value = "Not started" },
                    new SelectListItem { Text = "Suspended", Value = "Suspended" }
                };
            }
        }
    }
}
