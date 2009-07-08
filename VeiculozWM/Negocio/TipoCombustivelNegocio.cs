using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Midas.VeiculoZ.Negocio
{

    /// <summary>
    /// Classe de Negócio para Tipos de Combustível.
    /// </summary>
    public class TipoCombustivelNegocio:Midas.Nucleo.Negocio.NegocioGenerico
    {

        public TipoCombustivelNegocio()
        {
            this.AcessoDados = new Midas.VeiculoZ.Dados.SQLServer.TipoCombustivelDados();
        }

    }

}
