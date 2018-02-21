using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreMVC.Models
{
    public class Produto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string Name { get; set; }

        [Required]
        [Range(1, 9999999999999999.99)]
        public Decimal Price { get; set; }
    }
}