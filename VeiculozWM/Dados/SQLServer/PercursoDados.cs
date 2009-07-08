using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Dados;
using Midas.VeiculoZ.Objetos;
using Midas.Nucleo.Dados.SQLServerCE;
using System.Collections;

namespace Midas.VeiculoZ.Dados.SQLServer
{
    public class PercursoDados:IPercursoDados
    {
        #region IAcessoDados Members

        public void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Percurso percurso = (Percurso)objeto;
            if (percurso.Id == 0)
            {
                Comando comando = new Comando(Recursos.ConstantesDados.InserirPercurso, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@odometroinicial", percurso.OdometroInicio);
                comando.AdicionarParametro("@odometrofinal", percurso.OdometroFim);
                comando.AdicionarParametro("@viagem", percurso.Viagem);
                comando.AdicionarParametro("@idabastecimentoinicial", percurso.AbastecimentoInicial.Id);
                if (percurso.AbastecimentoFinal != null)
                {
                    comando.AdicionarParametro("@idabastecimentofinal", percurso.AbastecimentoFinal.Id);
                }
                else
                {
                    comando.AdicionarParametro("@idabastecimentofinal", -1);
                }
                comando.AdicionarParametro("@idveiculo", percurso.Veiculo.Id);
                percurso.Id = comando.ExecutarInsercao();
            }
            else
            {
                Comando comando = new Comando(Recursos.ConstantesDados.AtualizarPercurso, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@odometroinicial", percurso.OdometroInicio);
                comando.AdicionarParametro("@odometrofinal", percurso.OdometroFim);
                comando.AdicionarParametro("@viagem", percurso.Viagem);
                comando.AdicionarParametro("@idveiculo", percurso.Veiculo.Id);
                comando.AdicionarParametro("@idabastecimentoinicial", percurso.AbastecimentoInicial.Id);
                if (percurso.AbastecimentoFinal != null)
                {
                    comando.AdicionarParametro("@idabastecimentofinal", percurso.AbastecimentoFinal.Id);
                }
                else
                {
                    comando.AdicionarParametro("@idabastecimentofinal", -1);
                }
                comando.AdicionarParametro("@id", percurso.Id);
                comando.Executar();
            }
        }

        public void Excluir(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.ExcluirPercurso, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            comando.Executar();
        }

        public Midas.Nucleo.Objetos.ObjetoNegocio Localizar(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarPercurso, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.PercursoConversorDataReader());
            if (lista.Count > 0)
                return (Percurso)lista[0];
            return null;
        }

        public System.Collections.IList Localizar()
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarTodosPercursos, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            return comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.PercursoConversorDataReader());
        }

        #endregion


        #region IPercursoDados Members

        public Percurso ObterUltimoPercurso()
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarUltimoPercurso, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.PercursoConversorDataReader());
            if (lista.Count > 0)
                return (Percurso)lista[0];
            return null;
        }

        public int ObterIdAbastecimentoFinal(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarIdAbastecimentoFinalPercurso, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            return (int)comando.ObterValorEscalar();
        }

        public IList ListarDadosVisao()
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarTodosPercursos, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            return comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.PercursoVisaoConversorDataReader());
        }

        #endregion
    }
}
