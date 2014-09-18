﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToDoList.Models
{
    public class Event
    {
        [Required]
        [HiddenInput(DisplayValue=false)]
        public int EventID{ get; set; }
        [Required]
        public string EventName { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        public DateTime Deadline { get; set; }
    }
}