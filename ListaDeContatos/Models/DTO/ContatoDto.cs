using ListaDeContatos.Models.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaDeContatos.Models.DTO
{
    public class ContatoDto
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public Telefone Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public DateTime Nascimento { get; set; }
    }
}
