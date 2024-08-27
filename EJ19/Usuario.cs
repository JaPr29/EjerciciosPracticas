using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ19
{
    class Usuario
    {
        public Usuario(string usuario, string contraseña)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;
        }

        public string usuario { get; set; }
        public string contraseña { get; set; }
        
    }
}
