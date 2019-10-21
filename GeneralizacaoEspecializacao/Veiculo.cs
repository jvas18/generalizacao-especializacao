using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralizacaoEspecializacao
{
    public class Veiculo
    {
        protected string renavam;
        protected string placa;
        public virtual void ImpressaoDados()
        {
            
        }
    }
}
