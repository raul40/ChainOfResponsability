using ChainOfResponsability.Handler.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Handler
{
    public class MandoCoordinador : BaseHandler
    {
        public override void ProcesarAutorizacion(int _iImporte, string _cConcepto)
        {
            if (_iImporte <= 5000)
            {
                Console.WriteLine(string.Format("{0} : Autorizada por el Coordinador", _cConcepto));
            }
            else
            {
                base.PasarSiguienteMando(_iImporte, _cConcepto);
            }
        }
    }
}
