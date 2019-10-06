﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual List<Role> Roles { get; set; }
        public string Password { get; set; }
        [Required]
        public virtual Company Company { get; set; }
    }
}
