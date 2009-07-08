using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.VeiculoZ.Objetos;
using System.Data.SqlServerCe;

namespace Midas.VeiculoZ.Conversores
{

    /// <summary>
    /// Conversor para Tipos de Combustível.
    /// </summary>
    public class TipoCombustivelConversorDataReader:Midas.Nucleo.Conversor.IConversor
    {

        #region IConversor Members

        public object Converter(object entrada)
        {
            SqlCeDataReader dataReader = (SqlCeDataReader)entrada;
            TipoCombustivel tipoCombustivel = new TipoCombustivel();
            tipoCombustivel.Id = dataReader.GetInt32(0);
            tipoCombustivel.Nome = dataReader.GetString(1);
            return tipoCombustivel;
        }

        #endregion
    }

}
