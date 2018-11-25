using System;
using System.Collections.Generic;
using System.Text;

namespace Logatti.ByBus.Domain.Entities
{
    public class Horario
    {
        public Horario()
        {
        }

        public Horario(int idSegmento, int idTipoDia, string tabelaHoras)
        {
            IdSegmento = idSegmento;
            IdTipoDia = idTipoDia;
            TabelaHoras = tabelaHoras;
        }

        public int Id { get; set; }
        public int IdSegmento { get; set; }
        public Segmento Segmento { get; set; }
        public int IdTipoDia { get; set; }
        public string TabelaHoras { get; set; }
        //public TipoDia TipoDia { get; set; }
    }
}
