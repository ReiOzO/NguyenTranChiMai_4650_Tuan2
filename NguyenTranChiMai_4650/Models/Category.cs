﻿using System.ComponentModel.DataAnnotations;

namespace NguyenTranChiMai_4650.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
    }
}
