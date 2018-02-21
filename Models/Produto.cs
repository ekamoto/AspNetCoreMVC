using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreMVC.Models
{
    public class Produto
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}