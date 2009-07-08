using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Negocio;

namespace Midas.VeiculoZ.Negocio
{
    public class DistribuidoraNegocio:NegocioGenerico
    {
        public DistribuidoraNegocio()
        {
            this.AcessoDados = new Dados.SQLServer.DistribuidoraDados();
        }
    }
}
