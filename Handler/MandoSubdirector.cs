using ChainOfResponsability.Handler.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Handler
{
    public class MandoSubdirector : BaseHandler
    {
        public override void ProcesarAutorizacion(int _iImporte, string _cConcepto)
        {
            if (_iImporte > 10000 && _iImporte <= 15000)
            {
                Console.WriteLine(string.Format("{0} : Autorizada por el Subdirector", _cConcepto));
            }
            else
            {
                base.PasarSiguienteMando(_iImporte, _cConcepto);
            }
        }
    }
}
