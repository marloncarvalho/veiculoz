using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Objetos;

namespace Midas.VeiculoZ.Objetos
{

    /// <summary>
    /// Classe que representa um Percurso realizado por um Veículo.
    /// </summary>
    public class Percurso:ObjetoNegocio
    {

        public long KmRodados
        {
            get
            {
                return odometroFim - odometroInicio;
            }
        }

        public float ConsumoMedio
        {
            get
            {
                if (abastecimentoInicial != null && abastecimentoFinal != null)
                {
                    if (KmRodados <= 0)
                    {
                        return 0;
                    }
                    else
                    {
                        if (LitrosConsumidos <= 0)
                        {
                            return 0;
                        }
                        else
                        {
                            return (float)(KmRodados / LitrosConsumidos);
                        }
                    }
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal LitrosConsumidos
        {
            get
            {
                if (abastecimentoInicial != null && abastecimentoFinal != null)
                {
                    if (abastecimentoInicial.TanqueCheio && abastecimentoFinal.TanqueCheio)
                    {
                        return abastecimentoFinal.Litros;
                    }
                    else
                    {
                        return abastecimentoInicial.Litros;
                    }
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Valor marcado no odômetro no início do percurso.
        /// </summary>
        private long odometroInicio;
        public long OdometroInicio
        {
            get { return odometroInicio; }
            set { odometroInicio = value; }
        }

        /// <summary>
        /// Valor marcado no odômetro no final do percurso.
        /// </summary>
        private long odometroFim;
        public long OdometroFim
        {
            get { return odometroFim; }
            set { odometroFim = value; }
        }

        /// <summary>
        /// Identifica se este percurso foi realizado em uma viagem.
        /// </summary>
        private Boolean viagem;
        public Boolean Viagem
        {
            get { return viagem; }
            set { viagem = value; }
        }

        /// <summary>
        /// O abastecimento usado no início do Percurso.
        /// </summary>
        private Abastecimento abastecimentoInicial;
        public Abastecimento AbastecimentoInicial
        {
            get { return abastecimentoInicial; }
            set { abastecimentoInicial = value; }
        }

        /// <summary>
        /// Abastecimento realizado ao final do Percurso.
        /// </summary>
        private Abastecimento abastecimentoFinal;
        public Abastecimento AbastecimentoFinal
        {
            get { return abastecimentoFinal; }
            set { abastecimentoFinal = value; }
        }

        /// <summary>
        /// Veículo usado no Percurso.
        /// </summary>
        private Veiculo veiculo;
        public Veiculo Veiculo
        {
            get { return veiculo; }
            set { veiculo = value; }
        }

        public string DescricaoDetalhada
        {
            get
            {
                return this.AbastecimentoInicial.Data.ToString("dd/MM/yyyy") + " - " + this.KmRodados.ToString() + "Km com " + this.LitrosConsumidos.ToString("N2") + "L = " + this.ConsumoMedio.ToString("N2") + "Km/L";
            }
        }

    }
}