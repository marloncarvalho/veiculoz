using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Midas.VeiculoZ.Objetos;
using Midas.Nucleo.Dados;

namespace Midas.VeiculoZ.Dados
{
    public interface IAbastecimentoDados:IAcessoDados
    {
        Abastecimento ObterSimplificado(long id);
    }
}
