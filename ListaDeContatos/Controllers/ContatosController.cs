using ListaDeContatos.Data;
using ListaDeContatos.Models;
using ListaDeContatos.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaDeContatos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatosController : ControllerBase
    {
        private ListaContatosContext _context;

        public ContatosController(ListaContatosContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CadastrarContato(ContatoDto contatoDto)
        {
            var contato = new Contato();

            contato.Nascimento = contatoDto.Nascimento;
            contato.PrimeiroNome = contatoDto.PrimeiroNome;
            contato.UltimoNome = contatoDto.UltimoNome;
            contato.Telefone = contatoDto.Telefone;
            contato.Endereco = contatoDto.Endereco;
            contato.CriacaoDoContato = DateTime.Now;

            _context.Contatos.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }
    }
}
