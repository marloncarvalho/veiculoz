using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Objetos;

namespace Midas.VeiculoZ.Objetos
{

    /// <summary>
    /// Classe que representa um Seguro de um Veículo.
    /// </summary>
    public class Seguro:ObjetoNegocio
    {

        /// <summary>
        /// Empresa responsável pelo seguro.
        /// </summary>
        private PessoaJuridica seguradora;
        public PessoaJuridica Seguradora
        {
            get { return seguradora; }
            set { seguradora = value; }
        }

        /// <summary>
        /// Data de Vencimento do Seguro.
        /// </summary>
        private DateTime vencimento;
        public DateTime Vencimento
        {
            get { return vencimento; }
            set { vencimento = value; }
        }

    }

}