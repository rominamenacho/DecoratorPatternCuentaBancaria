using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternCuentaBancaria
{
   abstract class CuentaDecorador : ICuentaBancaria
    {
        protected ICuentaBancaria cuentaDecorada;

        //va a recibir cualquier implementacion de ICuenta:CH o CCTE
        public CuentaDecorador(ICuentaBancaria cuentaDecorada)
        {
            this.cuentaDecorada = cuentaDecorada;
        }

        public virtual void AbrirCuenta(Cuenta c)
        {
            this.cuentaDecorada.AbrirCuenta(c);
        }
    }
}
