using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Handler.Interfaces
{
    public interface IHandler
    {
        void ProcesarAutorizacion(int _iImporte, string _cConcepto);
    }
}
