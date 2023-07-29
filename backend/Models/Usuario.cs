﻿using System.ComponentModel.DataAnnotations;

namespace APIsTrainME.Models
{
    public class Usuario
    {
        [Key]
        public int UserId { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        

    }
}
