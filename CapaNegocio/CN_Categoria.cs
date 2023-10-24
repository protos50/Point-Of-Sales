﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private CD_Categoria ocd_categoria = new CD_Categoria();

        public List<Categoria> ObtenerCategorias()
        {
            return ocd_categoria.ObtenerCategorias();
        }

        public bool AgregarCategoria(Categoria categoria)
        {
            // Puedes agregar validaciones u otra lógica de negocio aquí antes de llamar al método en la capa de datos.
            return ocd_categoria.AgregarCategoria(categoria);
        }

        public bool EditarCategoria(Categoria categoria)
        {
            // Puedes agregar validaciones u otra lógica de negocio aquí antes de llamar al método en la capa de datos.
            return ocd_categoria.EditarCategoria(categoria);
        }
    }
}
