using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_CUENTA
    {
        private int _IdCuenta;
        private int _IdCliente;
        private int _BalanceCuenta;
        private int _Num_Cuenta;

        public int IdCuenta { get => _IdCuenta; set => _IdCuenta = value; }
        public int BalanceCuenta { get => _BalanceCuenta; set => _BalanceCuenta = value; }
        public int Num_Cuenta { get => _Num_Cuenta; set => _Num_Cuenta = value; }
        public int IdCliente { get => _IdCliente; set => _IdCliente = value; }
    }
}
