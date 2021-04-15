using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_CLIENTE
    {
        private int _IdCliente;
        private string _NombreCliente;
        private string _DireccionCliente;
        private string _TelefonoCliente;
        private string _emailCliente;

        public int IdCliente { get => _IdCliente; set => _IdCliente = value; }
        public string NombreCliente { get => _NombreCliente; set => _NombreCliente = value; }
        public string DireccionCliente { get => _DireccionCliente; set => _DireccionCliente = value; }
        public string TelefonoCliente { get => _TelefonoCliente; set => _TelefonoCliente = value; }
        public string EmailCliente { get => _emailCliente; set => _emailCliente = value; }
    }
}
