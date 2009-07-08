using System;
using System.Linq;
using System.Collections;
using System.Text;
using Midas.VeiculoZ.Objetos;
using Midas.Nucleo.Dados.SQLServerCE;
using Midas.Nucleo.Dados;

namespace Midas.VeiculoZ.Dados.SQLServer
{

    /// <summary>
    /// Acesso a Dados para Tipos de Combustível.
    /// </summary>
    public class TipoCombustivelDados:IAcessoDados
    {

        #region IAcessoDados Members

        public void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            TipoCombustivel tipo = (TipoCombustivel)objeto;
            if (tipo.Id == 0)
            {
                Comando comando = new Comando(Recursos.ConstantesDados.InserirTipoCombustivel, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@nome", tipo.Nome);
                tipo.Id = comando.ExecutarInsercao();
            }
            else
            {
                Comando comando = new Comando(Recursos.ConstantesDados.AtualizarTipoCombustivel, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@nome", tipo.Nome);
                comando.AdicionarParametro("@id", tipo.Id);
                comando.Executar();
            }

        }

        public void Excluir(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.ExcluirTipoCombustivel, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            comando.Executar();
        }

        public Midas.Nucleo.Objetos.ObjetoNegocio Localizar(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarTipoCombustivel, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.TipoCombustivelConversorDataReader());
            if (lista.Count > 0)
                return (TipoCombustivel)lista[0];
            return null;
        }

        public System.Collections.IList Localizar()
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarTodosTiposCombustivel, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.TipoCombustivelConversorDataReader());
            return lista;
        }

        #endregion

    }

}
