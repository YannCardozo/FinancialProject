
using System;


namespace FinancialProject.Client.Shared
{
    public class Despesa
    {
        public Despesa()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public CategoriaDespesa Categoria { get; set; }
        public decimal Valor { get; set; }
    }
}