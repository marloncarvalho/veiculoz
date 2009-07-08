using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Objetos;

namespace Midas.VeiculoZ.Objetos
{

    /// <summary>
    /// Classe que representa um abastecimento.
    /// </summary>
    public class Abastecimento:ObjetoNegocio
    {

        public decimal Litros
        {
            get
            {
                if (this.valorLitro <= 0)
                {
                    return 0;
                }
                else
                {
                    return this.Valor / this.ValorLitro;
                }
            }
        }

        /// <summary>
        /// Data em que foi realizado o abastecimento.
        /// </summary>
        private DateTime data;
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        /// <summary>
        /// Posto em que foi realizado o abastecimento.
        /// </summary>
        private Posto posto;
        public Posto Posto
        {
            get { return posto; }
            set { posto = value; }
        }

        /// <summary>
        /// Identifica se no abastecimento o tanque foi completado ou não.
        /// </summary>
        private Boolean tanqueCheio;
        public Boolean TanqueCheio
        {
            get { return tanqueCheio; }
            set { tanqueCheio = value; }
        }

        /// <summary>
        /// Valor total pago pelo abastecimento.
        /// </summary>
        private Decimal valor;
        public Decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        /// <summary>
        /// Valor que foi pago pelo litro do combustível.
        /// </summary>
        private Decimal valorLitro;
        public Decimal ValorLitro
        {
            get { return valorLitro; }
            set { valorLitro = value; }
        }

        /// <summary>
        /// Tipo de Combustível usado no abastecimento.
        /// </summary>
        private TipoCombustivel tipoCombustivel;
        public TipoCombustivel TipoCombustivel
        {
            get { return tipoCombustivel; }
            set { tipoCombustivel = value; }
        }

        /// <summary>
        /// Observações sobre o abastecimento.
        /// </summary>
        private string observacoes;
        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }

    }

}
