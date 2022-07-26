
using FinancialProject.Client.Shared;
using System;
using System.ComponentModel.DataAnnotations;

namespace FinancialProject.Client.Components
{
    public class ReceitaDTO
    {
        [Required]
        public DateTime Data { get; set; }
        [Required]
        [StringLength(80)]
        public string Descricao { get; set; }
        [Required]
        public CategoriaReceita Categoria { get; set; }
        [Required]
        public decimal Valor { get; set; }
    }
}