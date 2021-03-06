﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Conversor;
using System.Data.SqlServerCe;
using Midas.VeiculoZ.Objetos;

namespace Midas.VeiculoZ.Conversores
{
    public class PercursoVisaoConversorDataReader:IConversor
    {
        #region IConversor Members

        public object Converter(object entrada)
        {
            SqlCeDataReader dataReader = (SqlCeDataReader)entrada;
            Percurso percurso = new Percurso();
            percurso.Id = dataReader.GetInt32(0);
            percurso.OdometroInicio = dataReader.GetInt64(1);
            percurso.OdometroFim = dataReader.GetInt64(2);
            if (dataReader.GetInt32(5) != -1)
            {
                percurso.AbastecimentoInicial = (Abastecimento)Negocio.NegocioFactory.Instancia.AbastecimentoNegocio.ObterSimplificado(dataReader.GetInt32(5));
            }
            if (dataReader.GetInt32(6) != -1)
            {
                percurso.AbastecimentoFinal = (Abastecimento)Negocio.NegocioFactory.Instancia.AbastecimentoNegocio.ObterSimplificado(dataReader.GetInt32(6));
            }
            return percurso;

        }

        #endregion

    }
}
