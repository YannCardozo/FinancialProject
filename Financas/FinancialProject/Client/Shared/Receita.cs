
using System;

namespace FinancialProject.Client.Shared
{
    public class Receita
    {
        public Receita()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public CategoriaReceita Categoria{ get; set; }
        public decimal Valor { get; set; }
    }
}