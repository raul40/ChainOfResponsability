using ChainOfResponsability.Handler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Handler.Abstract
{
    public abstract class BaseHandler : IHandler
    {
        IHandler SiguienteMando;

        public void AsignarSiguienteMando(IHandler _SiguienteAlMando)
        {
            SiguienteMando = _SiguienteAlMando;
        }

        public void PasarSiguienteMando(int _iImporte, string _cConcepto)
        {
            if (SiguienteMando != null)
                SiguienteMando.ProcesarAutorizacion(_iImporte, _cConcepto);
        }

        public abstract void ProcesarAutorizacion(int _iImporte, string _cConcepto);
    }
}
