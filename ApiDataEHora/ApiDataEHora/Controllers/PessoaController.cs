using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiDataEHora.Models;

namespace ApiDataEHora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Pessoa>> Get()
        {
            var pessoa = new Pessoa()
            {
                Nome = "Glauber",
                Idade = DateTime.Now.Year - 1983
            };

            var pessoa2 = new Pessoa()
            {
                Nome = "Pedro",
                Idade = DateTime.Now.Year - 2018
            };

            var pessoa3 = new Pessoa()
            {
                Nome = "Alexandre",
                Idade = DateTime.Now.Year - 1997
            };

            var pessoa4 = new Pessoa()
            {
                Nome = "João",
                Idade = DateTime.Now.Year - 2007
            };

            var pessoas = new List<Pessoa>();
            pessoas.Add(pessoa);
            pessoas.Add(pessoa2);
            pessoas.Add(pessoa3);
            pessoas.Add(pessoa4);

            return pessoas;
        } 
    }
}
