using FinancialProject.Client.Shared;
using FinancialProject.Server.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinancialProject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DespesasController : ControllerBase
    {
        private readonly IRepository<Despesa> _receitaRepository;
        public DespesasController(IRepository<Despesa> receitaRepository)
        {
            _receitaRepository = receitaRepository;
        }
        [HttpGet]
        public IEnumerable<Despesa> Get()
        {
            return _receitaRepository.GetAll()
                       .OrderBy(r => r.Data);
        }

        [HttpPost]
        public void Post(Despesa receita)
        {
            _receitaRepository.Add(receita);
        }

        [HttpDelete("{id?}")]
        public void Delete(Guid id)
        {
            var entity = _receitaRepository.GetAll()
                  .Single(item => item.Id == id);

            _receitaRepository.Remove(entity);
        }
    }
}