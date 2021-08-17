using ListaDeContatos.Data;
using ListaDeContatos.Models;
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
        public IActionResult CadastrarContato(Contato contato)
        {
            _context.Contatos.Add(contato);
            _context.SaveChanges();
            return Ok("Contato cadastrado.");
        }
    }
}
