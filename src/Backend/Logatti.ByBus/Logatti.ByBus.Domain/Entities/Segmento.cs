using System;
using System.Collections.Generic;
using System.Text;

namespace Logatti.ByBus.Domain.Entities
{
    public class Segmento
    {
        public Segmento()
        {

        }

        public Segmento(int idLinha, string nome, string logradouro)
        {
            IdLinha = idLinha;
            Nome = nome;
            Logradouro = logradouro;
        }

        public int Id { get; set; }
        public int IdLinha { get; set; }
        public string Nome { get; set; }
        public string Logradouro { get; set; }
        public Linha Linha { get; set; }
        public ICollection<Horario> Horarios { get; set; }

    }
}
