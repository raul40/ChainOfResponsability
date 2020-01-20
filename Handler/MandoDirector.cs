using ChainOfResponsability.Handler.Abstract;
using ChainOfResponsability.Handler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Handler
{
    public class MandoDirector : BaseHandler
    {
        public override void ProcesarAutorizacion(int _iImporte, string _cConcepto)
        {
            if (_iImporte > 15000 && _iImporte <= 50000)
            {
                Console.WriteLine(string.Format("{0} : Autorizada por el Director", _cConcepto));
            }
            else if (_iImporte > 50000)
            {
                Console.WriteLine("La solicitud fue denegada");
            }
        }
    }
}
