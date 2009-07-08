using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Midas.VeiculoZ.Negocio
{
    
    public class VeiculosNegocio:Midas.Nucleo.Negocio.NegocioGenerico
    {

        public VeiculosNegocio()
        {
            this.AcessoDados = new Midas.VeiculoZ.Dados.SQLServer.VeiculoDados();
        }

    }

}
