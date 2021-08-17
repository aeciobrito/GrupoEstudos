using ListaDeContatos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaDeContatos.Data
{
    public class ListaContatosContext : DbContext
    {
        public ListaContatosContext(DbContextOptions<ListaContatosContext> options) : base(options)
        {

        }

        public DbSet<Contato> Contatos { get; set; }
    }
}
