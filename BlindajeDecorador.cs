using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternCuentaBancaria
{
    class BlindajeDecorador : CuentaDecorador
    {
        public BlindajeDecorador(ICuentaBancaria cuentaDecorada) : base(cuentaDecorada)
        {
        }
        //hay que sobreescribirlo para que haga las decoraciones
       public override void AbrirCuenta(Cuenta c)
        {
            cuentaDecorada.AbrirCuenta(c);
            AgregarBlindaje(c);
        }

        public void AgregarBlindaje(Cuenta c)
        {
            Console.WriteLine("Se agrego blindaje a la cuenta del cliente " + c.NombreCliente + ", cuenta numero " + c.NumeroCuenta);
        }
    }
}
