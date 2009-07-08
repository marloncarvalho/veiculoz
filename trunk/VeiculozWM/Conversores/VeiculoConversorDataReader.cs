using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using Midas.VeiculoZ.Objetos;

namespace Midas.VeiculoZ.Conversores
{
    
    public class VeiculoConversorDataReader:Midas.Nucleo.Conversor.IConversor
    {


        #region IConversor Members

        public object Converter(object entrada)
        {
            SqlCeDataReader dataReader = (SqlCeDataReader)entrada;
            Veiculo veiculo = new Veiculo();
            veiculo.Id = dataReader.GetInt32(0);
            veiculo.Placa = dataReader.GetString(1);
            veiculo.Renavam = dataReader.GetString(2);
            veiculo.Cor = dataReader.GetString(3);
            veiculo.Modelo = dataReader.GetString(4);
            veiculo.Marca = dataReader.GetString(5);
            return veiculo;
        }

        #endregion
    }

}