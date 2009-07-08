using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Objetos;

namespace Midas.VeiculoZ.Objetos
{
    public class Distribuidora:ObjetoNegocio
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private System.Drawing.Image logotipo;
        public System.Drawing.Image Logotipo
        {
            get { return logotipo; }
            set { logotipo = value; }
        }
    }
}
