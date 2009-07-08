using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Objetos;

namespace Midas.VeiculoZ.Objetos
{

    /// <summary>
    /// Classe que representa um Motorista.
    /// </summary>
    public class Motorista:PessoaFisica
    {

        /// <summary>
        /// Número da Carteira de Motorista.
        /// </summary>
        private string numeroCarteira;
        public string NumeroCarteira
        {
            get { return numeroCarteira; }
            set { numeroCarteira = value; }
        }

    }

}
