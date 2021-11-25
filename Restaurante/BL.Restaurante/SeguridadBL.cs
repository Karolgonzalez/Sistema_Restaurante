using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Restaurante
{
    public class SeguridadBL
    {

       Contexto  _Contexto;

        public SeguridadBL()
        {
            _Contexto = new Contexto();
        }

        public usuario login(string usuario, string contrasena)
        {
            var Usuario = _Contexto.Usuarios.ToList();

            foreach (var UsuarioDB in Usuario)
            {
                if (usuario == UsuarioDB.Nombre && contrasena == UsuarioDB.Contrasena)
                {
                    return UsuarioDB;
                }
            }
            return null;
        }

        public class usuario
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Contrasena { get; set; }
        }

       
    }
}
