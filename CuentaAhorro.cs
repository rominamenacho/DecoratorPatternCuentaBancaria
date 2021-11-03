using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternCuentaBancaria
{
    class CuentaAhorro : ICuentaBancaria
    {
        public void AbrirCuenta(Cuenta c)
        {
            Console.WriteLine("=============");
            Console.WriteLine("Se abrio una cuenta de ahorros");
            Console.WriteLine("Cliente: "+ c.NombreCliente + "Cuenta numero: "+ c.NumeroCuenta);
        }
    }
}
