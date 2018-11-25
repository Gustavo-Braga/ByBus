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
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        //public Onibus Onibus { get; set; }
        public ICollection<Segmento> Segmentos { get; set; }
    }
}
