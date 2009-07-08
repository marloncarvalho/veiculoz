using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Objetos;

namespace Midas.VeiculoZ.Objetos
{

    /// <summary>
    /// Classe que representa um Tipo de Combustível.
    /// </summary>
    public class TipoCombustivel:ObjetoNegocio
    {

        /// <summary>
        /// Nome do Tipo de Combustível.
        /// </summary>
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

    }

}
