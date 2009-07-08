using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Dados;
using Midas.VeiculoZ.Objetos;
using System.Collections;
using Midas.Nucleo.Dados.SQLServerCE;

namespace Midas.VeiculoZ.Dados.SQLServer
{
    public class DistribuidoraDados:IAcessoDados
    {
        #region IAcessoDados Members

        public void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Distribuidora distribuidora = (Distribuidora)objeto;
            if (distribuidora.Id == 0)
            {
                Comando comando = new Comando(Recursos.ConstantesDados.InserirDistribuidora, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@nome", distribuidora.Nome);
                distribuidora.Id = comando.ExecutarInsercao();
            }
            else
            {
                Comando comando = new Comando(Recursos.ConstantesDados.AtualizarDistribuidora, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@nome", distribuidora.Nome);
                comando.AdicionarParametro("@id", distribuidora.Id);
                comando.Executar();
            }

        }

        public void Excluir(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.ExcluirDistribuidora, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            comando.Executar();
        }

        public Midas.Nucleo.Objetos.ObjetoNegocio Localizar(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarDistribuidora, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.DistribuidoraConversorDataReader());
            if (lista.Count > 0)
                return (Distribuidora)lista[0];
            return null;
        }

        public System.Collections.IList Localizar()
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarTodasDistribuidoras, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.DistribuidoraConversorDataReader());
            return lista;
        }

        #endregion

    }
}
