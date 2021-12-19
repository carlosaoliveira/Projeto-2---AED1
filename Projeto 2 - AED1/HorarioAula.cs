using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_2___AED1
{
    class HorarioAula
    {
        public int HoraInicio { get; set; }
        public int HoraFim { get; set; }
        public IList<string> NomesAlunosAgendados { get; set; }
    }
}
