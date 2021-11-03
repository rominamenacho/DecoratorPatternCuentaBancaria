using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternCuentaBancaria
{
    class Cuenta
    {
        private string nombreCliente;
        private int numeroCuenta;

        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public int NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }

    public Cuenta(string cliente, int numCuenta) {
            this.NombreCliente = cliente;
            this.NumeroCuenta = numCuenta;
        }

    }
}
