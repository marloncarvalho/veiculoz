using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Negocio;
using Midas.VeiculoZ.Objetos;
using Midas.VeiculoZ.Dados.SQLServer;
using Midas.VeiculoZ.Dados;

namespace Midas.VeiculoZ.Negocio
{
    public class AbastecimentoNegocio:NegocioGenerico
    {
        public AbastecimentoNegocio()
        {
            this.AcessoDados = new Dados.SQLServer.AbastecimentoDados();
        }

        public Abastecimento ObterSimplificado(long id)
        {
            IAbastecimentoDados dados = (IAbastecimentoDados)this.AcessoDados;
            return dados.ObterSimplificado(id);
        }

    }
}
