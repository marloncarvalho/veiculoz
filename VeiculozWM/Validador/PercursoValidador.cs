using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.VeiculoZ.Objetos;
using Midas.Nucleo.Validador;

namespace Midas.VeiculoZ.Validador
{
    public class PercursoValidador:Midas.Nucleo.Validador.IValidador
    {
        #region IValidador Members

        public Midas.Nucleo.Validador.Validacao Validar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Percurso percurso = (Percurso)objeto;
            if (percurso.Veiculo == null)
            {
                return new Validacao(false, "Informe o Veículo.");
            }
            if (percurso.AbastecimentoInicial == null)
            {
                return new Validacao(false, "Informe os dados do Abastecimento.");
            }
            if (percurso.AbastecimentoInicial.Posto == null || percurso.AbastecimentoInicial.Posto.Id == -1)
            {
                return new Validacao(false, "Informe o Posto do Abastecimento.");
            }
            if (percurso.AbastecimentoInicial.TipoCombustivel == null || percurso.AbastecimentoInicial.TipoCombustivel.Id == 0)
            {
                return new Validacao(false, "Informe o Tipo de Combustível.");
            }
            if (percurso.AbastecimentoInicial.Valor <= 0)
            {
                return new Validacao(false, "Informe o Valor total do abastecimento.");
            }
            if (percurso.AbastecimentoInicial.ValorLitro <= 0)
            {
                return new Validacao(false, "Informe o Valor do Litro.");
            }
            if (percurso.OdometroFim <= 0)
            {
                return new Validacao(false, "Informe a Quilometragem Final.");
            }
            if (percurso.OdometroInicio <= 0)
            {
                return new Validacao(false, "Informe a Quilometragem Inicial.");
            }
            if (percurso.OdometroInicio >= percurso.OdometroFim)
            {
                return new Validacao(false, "A Quilometragem Inicial não pode ser maior que a Quilometragem Final.");
            }
            return new Validacao(true, "");
        }

        #endregion
    }
}
