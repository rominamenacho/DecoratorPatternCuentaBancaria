using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternCuentaBancaria
{
    interface ICuentaBancaria
    {
         void AbrirCuenta(Cuenta c);
    }
}
