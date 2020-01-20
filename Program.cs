using ChainOfResponsability.Handler;
using ChainOfResponsability.Handler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            int iMonto = 0;
            var PrimerMando = new MandoCoordinador();
            var SegundoMando = new MandoGerente();
            var TercerMando = new MandoSubdirector();
            var CuartoMando = new MandoDirector();

            //Crear Cadena
            PrimerMando.AsignarSiguienteMando(SegundoMando);
            SegundoMando.AsignarSiguienteMando(TercerMando);
            TercerMando.AsignarSiguienteMando(CuartoMando);

            Console.WriteLine("Escriba un concepto de la compra");
            string cConcepto = Console.ReadLine();

            Console.WriteLine("Capture el Monto de la compra");
            int.TryParse(Console.ReadLine(), out iMonto);

            PrimerMando.ProcesarAutorizacion(iMonto, cConcepto);
            Console.ReadLine();
        }
    }
}
