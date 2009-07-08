using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Objetos;

namespace Midas.VeiculoZ.Objetos
{

    /// <summary>
    /// Classe que representa um Carro.
    /// </summary>
    public class Veiculo:ObjetoNegocio
    {

        /// <summary>
        /// Número da Placa do Veículo.
        /// </summary>
        private string placa;
        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        /// <summary>
        /// Número do RENAVAM do Veículo.
        /// </summary>
        private string renavam;
        public string Renavam
        {
            get { return renavam; }
            set { renavam = value; }
        }

        /// <summary>
        /// Cor do Veículo.
        /// </summary>
        private string cor;
        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        /// <summary>
        /// Modelo do Veículo.
        /// </summary>
        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        /// <summary>
        /// Marca do Veículo.
        /// </summary>
        private string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

    }

}
