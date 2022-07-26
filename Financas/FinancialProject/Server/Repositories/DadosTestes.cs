using FinancialProject.Client.Shared;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace FinancialProject.Server.Repositories
{
    public static class DadosTestes
    {
        public static void AddReceitasRepository(this IServiceCollection services)
        {
            var hoje = DateTime.Today;
            var ultimoMes = DateTime.Today.AddMonths(-1);
            var mesAnterior = DateTime.Today.AddMonths(-2);
            var receitaRepository = new MemoryRepository<Receita>();

            receitaRepository.Add(new Receita { Data = new DateTime(mesAnterior.Year, mesAnterior.Month, 25), Valor = 2480, Categoria = CategoriaReceita.Salário, Descricao = "Salário mensal" });
            receitaRepository.Add(new Receita { Data = new DateTime(mesAnterior.Year, mesAnterior.Month, 12), Valor = 440, Categoria = CategoriaReceita.Vendas, Descricao = "Vendas" });
            receitaRepository.Add(new Receita { Data = new DateTime(ultimoMes.Year, ultimoMes.Month, 25), Valor = 2480, Categoria = CategoriaReceita.Salário, Descricao = "Salário mensal" });
            receitaRepository.Add(new Receita { Data = new DateTime(ultimoMes.Year, ultimoMes.Month, 12), Valor = 790, Categoria = CategoriaReceita.Vendas, Descricao = "Vendas" });
            receitaRepository.Add(new Receita { Data = new DateTime(ultimoMes.Year, ultimoMes.Month, 4), Valor = 387, Categoria = CategoriaReceita.Lucros, Descricao = "Dividendos" });
            receitaRepository.Add(new Receita { Data = new DateTime(hoje.Year, hoje.Month, 25), Valor = 2480, Categoria = CategoriaReceita.Salário, Descricao = "Salário mensal" });
            receitaRepository.Add(new Receita { Data = new DateTime(hoje.Year, hoje.Month, 14), Valor = 680, Categoria = CategoriaReceita.Vendas, Descricao = "Vendas" });
            receitaRepository.Add(new Receita { Data = new DateTime(hoje.Year, hoje.Month, 12), Valor = 245, Categoria = CategoriaReceita.Vendas, Descricao = "Vendas" });
            services.AddSingleton<IRepository<Receita>>(receitaRepository);
        }

        public static void AddDespesasRepository(this IServiceCollection services)
        {
            var hoje = DateTime.Today;
            var ultimoMes = DateTime.Today.AddMonths(-1);
            var mesAnterior = DateTime.Today.AddMonths(-2);
            var despesaRepository = new MemoryRepository<Despesa>();

            despesaRepository.Add(new Despesa { Data = new DateTime(mesAnterior.Year, mesAnterior.Month, 25), Valor = 480, Categoria = CategoriaDespesa.Alimentação, Descricao = "Compra Mensal" });
            despesaRepository.Add(new Despesa { Data = new DateTime(mesAnterior.Year, mesAnterior.Month, 12), Valor = 40, Categoria = CategoriaDespesa.Transporte, Descricao = "Gasta com gasolina" });
            despesaRepository.Add(new Despesa { Data = new DateTime(ultimoMes.Year, ultimoMes.Month, 25), Valor = 280, Categoria = CategoriaDespesa.Alimentação, Descricao = "Compra semanal" });
            despesaRepository.Add(new Despesa { Data = new DateTime(ultimoMes.Year, ultimoMes.Month, 12), Valor = 10, Categoria = CategoriaDespesa.Extras, Descricao = "Gastos diversos" });
            despesaRepository.Add(new Despesa { Data = new DateTime(ultimoMes.Year, ultimoMes.Month, 4), Valor = 50, Categoria = CategoriaDespesa.Poupança, Descricao = "Poupança pessoal" });
            despesaRepository.Add(new Despesa { Data = new DateTime(hoje.Year, hoje.Month, 25), Valor = 80, Categoria = CategoriaDespesa.Transporte, Descricao = "Gasto com combustível" });
            despesaRepository.Add(new Despesa { Data = new DateTime(hoje.Year, hoje.Month, 14), Valor = 60, Categoria = CategoriaDespesa.Educação, Descricao = "Compra livro" });
            despesaRepository.Add(new Despesa { Data = new DateTime(hoje.Year, hoje.Month, 12), Valor = 25, Categoria = CategoriaDespesa.Vestuário, Descricao = "Compra camiseta" });
            services.AddSingleton<IRepository<Despesa>>(despesaRepository);
        }
    }
}