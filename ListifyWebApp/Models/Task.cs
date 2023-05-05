﻿using System.ComponentModel.DataAnnotations;

namespace ListifyWebApp.Models
{
    public class ItemTask
    {
        [Key]
        public int Id { get; set; }
        public string TaskDescription { get; set; }

        public ItemTask()
        {

        }
        
    }
}
