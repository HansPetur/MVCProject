using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class Event
    {
        public string eventName { get; set; }
        [Required]
        public string owner { get; set; }
    }
}