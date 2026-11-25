using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPU.Domain
{
    public class RegistroPeriferico
    {
        public int IdRegistroPeriferico { get; set; }

        public int IdRegistro { get; set; }
        public int IdPeriferico { get; set; }

        public Registro Registro { get; set; }
        public Periferico Periferico { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
