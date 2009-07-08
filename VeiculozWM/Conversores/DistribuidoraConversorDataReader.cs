using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Midas.VeiculoZ.Objetos;

namespace Midas.VeiculoZ.Conversores
{

    /// <summary>
    /// Conversor de SqlCeDataReader para Distribuidora.
    /// </summary>
    public class DistribuidoraConversorDataReader:Midas.Nucleo.Conversor.IConversor
    {
        #region IConversor Members

        public object Converter(object entrada)
        {
            SqlCeDataReader dataReader = (SqlCeDataReader)entrada;
            Distribuidora distribuidora = new Distribuidora();
            distribuidora.Id = dataReader.GetInt32(0);
            distribuidora.Nome = dataReader.GetString(1);
            return distribuidora;

        }

        #endregion
    }

}
