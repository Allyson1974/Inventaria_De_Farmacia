﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.InventarioFarmacia
{
    public class SeguridadBL
    {

        List<Usurario> ListadeUsusarios;

        Contexto _contexto;// no est

        public SeguridadBL()
        {
            {
                _contexto = new Contexto();
            }
            ListadeUsusarios = new List<Usurario>();

            var usuario1 = new Usurario();
            usuario1.Nombre = "admin";
            usuario1.Contraseña = "123";

            var usuario2 = new Usurario();
            usuario2.Nombre = "administrador";
            usuario2.Contraseña = "4567";

            ListadeUsusarios.Add(usuario1);
            ListadeUsusarios.Add(usuario2);

        }
      public  bool Autorizar(string usuario, string contrasena )

        {
            var usuarios = _contexto.Usuarios.ToList();
            
            foreach (var usuarioDB in usuarios)
            {
                if (usuario == usuarioDB.Nombre && contrasena == usuarioDB.Contraseña)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
