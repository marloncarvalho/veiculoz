using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Midas.Nucleo.Dados;
using Midas.VeiculoZ.Objetos;
using System.Collections;

namespace Midas.VeiculoZ.Dados
{
    public interface IPercursoDados:IAcessoDados
    {
        Percurso ObterUltimoPercurso();
        int ObterIdAbastecimentoFinal(long id);
        IList ListarDadosVisao();
    }
}
