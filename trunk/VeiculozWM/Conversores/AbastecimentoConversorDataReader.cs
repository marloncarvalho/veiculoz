using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Conversor;
using System.Data.SqlServerCe;
using Midas.VeiculoZ.Objetos;

namespace Midas.VeiculoZ.Conversores
{
    public class AbastecimentoConversorDataReader:IConversor
    {
        #region IConversor Members

        public object Converter(object entrada)
        {
            SqlCeDataReader dataReader = (SqlCeDataReader)entrada;
            Abastecimento abastecimento = new Abastecimento();
            abastecimento.Id = dataReader.GetInt32(0);
            abastecimento.Posto = (Posto)Negocio.NegocioFactory.Instancia.PostoNegocio.Obter(dataReader.GetInt32(1));
            abastecimento.Data = dataReader.GetDateTime(2);
            abastecimento.Observacoes = dataReader.GetString(3);
            abastecimento.TanqueCheio = dataReader.GetBoolean(4);
            abastecimento.TipoCombustivel = (TipoCombustivel)Negocio.NegocioFactory.Instancia.TipoCombustivelNegocio.Obter(dataReader.GetInt32(5));
            abastecimento.Valor = dataReader.GetDecimal(6);
            abastecimento.ValorLitro = dataReader.GetDecimal(7);
            return abastecimento;
        }

        #endregion
    }
}
