using Microsoft.EntityFrameworkCore;

namespace ListaDeContatos.Models.ValueObject
{
    [Owned]
    public class Endereco
    {
        public string Numero { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
    }
}