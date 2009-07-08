using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Conversor;
using System.Data.SqlServerCe;
using Midas.VeiculoZ.Objetos;

namespace Midas.VeiculoZ.Conversores
{
    public class AbastecimentoVisaoConversorDataReader:IConversor
    {
        #region IConversor Members

        public object Converter(object entrada)
        {
            SqlCeDataReader dataReader = (SqlCeDataReader)entrada;
            Abastecimento abastecimento = new Abastecimento();
            abastecimento.Id = dataReader.GetInt32(0);
            abastecimento.Data = dataReader.GetDateTime(2);
            abastecimento.Valor = dataReader.GetDecimal(6);
            abastecimento.ValorLitro = dataReader.GetDecimal(7);
            return abastecimento;
        }

        #endregion

    }
}
