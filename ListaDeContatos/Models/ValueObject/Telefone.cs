using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaDeContatos.Models.ValueObject
{
    [Owned]
    public class Telefone
    {
        public string Ddd { get; set; }
        public string Numero { get; set; }
    }
}
