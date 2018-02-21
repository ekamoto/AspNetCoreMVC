using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreMVC.Models
{
    public class Produto
    {
        [Required(ErrorMessage="Campo obrigatório")]
        [Range(1,int.MaxValue, ErrorMessage="Campo tem que estar entre 1 e max int")]
        public int? Id { get; set; }

        [Required(ErrorMessage="Campo Nome é obrigatório")]
        [MaxLength(10, ErrorMessage = "Quantidade máxima de caracteres é 10")]
        public string Name { get; set; }

        [Required(ErrorMessage="Campo preço é obrigatório",AllowEmptyStrings=false)]
        [Range(1, 9999999999999999.99, ErrorMessage = "Preço não pode ser zero e nem superior 9999999999999999.99")]
        public decimal? Price { get; set; }
    }
}