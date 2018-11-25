using System;
using System.Collections.Generic;
using System.Text;

namespace Logatti.ByBus.Domain.Entities
{
    public class Linha
    {
        public Linha()
        {

        }

        public Linha(string nome, string cNPJ)
        {
            Nome = nome;
            CNPJ = cNPJ;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public ICollection<Onibus> Onibus { get; set; }
        public ICollection<Segmento> Segmentos { get; set; }
    }
}
