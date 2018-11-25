using System.Collections.Generic;

namespace Logatti.ByBus.Domain.Entities
{
    public class Onibus
    {
        public Onibus()
        {

        }

        public Onibus(int idLinha, string cNPJ)
        {
            IdLinha = idLinha;
            CNPJ = cNPJ;
        }

        public int Id { get; set; }
        public int IdLinha { get; set; }
        public string CNPJ { get; set; }
        public Empresa Empresa { get; set; }
        public Linha Linha { get; set; }
    }
}
