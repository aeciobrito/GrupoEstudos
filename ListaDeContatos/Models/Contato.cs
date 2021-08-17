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
        public string Telefone { get; set; }
        public string NumeroDaResidencia { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime CriacaoDoContato { get; set; }
    }
}
