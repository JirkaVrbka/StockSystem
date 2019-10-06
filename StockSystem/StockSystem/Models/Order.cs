﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Models
{
    public class Order
    {
        public int Id { get; set; }
        public virtual List<ItemAmount> Items { get; set; }
        [Required]
        public virtual Company Company { get; set; }
    }
}
