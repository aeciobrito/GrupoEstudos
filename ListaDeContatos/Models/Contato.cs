using ListaDeContatos.Models.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaDeContatos.Models
{
    public class Contato
    {       
        public int Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public Telefone Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime CriacaoDoContato { get; set; }
    }
}
