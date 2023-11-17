using System;

namespace presentacion6
{
  public class clsClientes
  {
    private int idCliente;
        public int IdCliente { get => idCliente; set => idCliente = value; }
        private string _Nombres;
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        private string _Apellidos;
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
    }
}