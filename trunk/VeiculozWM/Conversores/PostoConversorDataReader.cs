using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Midas.VeiculoZ.Objetos;
using Midas.Nucleo.Objetos;
using Midas.Nucleo.Conversor;

namespace Midas.VeiculoZ.Conversores
{

    /// <summary>
    /// Conversor de SqlCeDataReader para Posto.
    /// </summary>
    public class PostoConversorDataReader:Midas.Nucleo.Conversor.IConversor
    {

        #region IConversor Members

        /// <summary>
        /// Converter um SqlCeDataReader em um objeto Posto.
        /// </summary>
        /// <param name="entrada">SqlCeDataReader</param>
        /// <returns>Posto</returns>
        public object Converter(object entrada)
        {
            SqlCeDataReader dataReader = (SqlCeDataReader)entrada;
            Posto posto = new Posto();
            posto.Id = dataReader.GetInt32(0);
            posto.Distribuidora = (Distribuidora)Negocio.NegocioFactory.Instancia.DistribuidoraNegocio.Obter(dataReader.GetInt32(1));
            posto.PessoaJuridica = (PessoaJuridica)Midas.Nucleo.Negocio.NegocioFactory.Instancia.PessoaJuridicaNegocio.Obter(dataReader.GetInt32(2));
            posto.Endereco = (Endereco)Midas.Nucleo.Negocio.NegocioFactory.Instancia.EnderecoNegocio.Obter(dataReader.GetInt32(3));
            posto.Observacoes = dataReader.GetString(4);
            return posto;
        }

        #endregion

    }

}
