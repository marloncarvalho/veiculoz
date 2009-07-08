using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Objetos;

namespace Midas.VeiculoZ.Objetos
{

    /// <summary>
    /// Classe que representa um Posto de Combustível.
    /// </summary>
    public class Posto:ObjetoNegocio
    {

        private string nome;
        public string Nome
        {
            get { return this.PessoaJuridica.NomeFantasia; }
        }

        private string nomeDistribuidora;
        public string NomeDistribuidora
        {
            get { return this.Distribuidora.Nome; }
        }

        /// <summary>
        /// Referência para a PJ. 
        /// </summary>
        private PessoaJuridica pessoaJuridica;
        public PessoaJuridica PessoaJuridica
        {
            get { return pessoaJuridica; }
            set { pessoaJuridica = value; }
        }

        /// <summary>
        /// Endereço do Posto.
        /// </summary>
        private Endereco endereco;
        public Endereco Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        /// <summary>
        /// Distribuidora que fornece combustível para o Posto.
        /// </summary>
        private Distribuidora distribuidora;
        public Distribuidora Distribuidora
        {
            get { return distribuidora; }
            set { distribuidora = value; }
        }

        private string observacoes;
        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }
    }

}
