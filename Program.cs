using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternCuentaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta c = new Cuenta("Romina Menacho", 00054789);

            ICuentaBancaria cajaAhorros = new CuentaAhorro();
            ICuentaBancaria cuentaBlindada = new BlindajeDecorador(cajaAhorros);
            cuentaBlindada.AbrirCuenta(c);

            Console.ReadKey();
        }
    }
}
