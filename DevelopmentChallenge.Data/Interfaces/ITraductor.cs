using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Interfaces
{
    public interface ITraductor
    {
        string TraducirHeader();
        string TraducirListaVacia();
        string TraducirForma(int tipo, int cantidad);
        string TraducirPerimetro();
        string TraducirFormas();
    }
}
