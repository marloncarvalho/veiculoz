using System;
using System.Collections;
using System.Linq;
using System.Text;
using Midas.VeiculoZ.Objetos;
using Midas.Nucleo.Dados.SQLServerCE;
using Midas.Nucleo.Dados;

namespace Midas.VeiculoZ.Dados.SQLServer
{

    /// <summary>
    /// Acesso a Dados por SQL Server CE para Postos.
    /// </summary>
    public class PostoDados:IAcessoDados
    {

        #region IAcessoDados Members

        public void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Posto posto = (Posto)objeto;
            if (posto.Id == 0)
            {
                Comando comando = new Comando(Recursos.ConstantesDados.InserirPosto, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@observacoes", posto.Observacoes);
                comando.AdicionarParametro("@idendereco", posto.Endereco.Id);
                comando.AdicionarParametro("@iddistribuidora", posto.Distribuidora.Id.ToString());
                comando.AdicionarParametro("@idpessoajuridica", posto.PessoaJuridica.Id.ToString());
                posto.Id = comando.ExecutarInsercao();
            }
            else
            {
                Comando comando = new Comando(Recursos.ConstantesDados.AtualizarPosto, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@observacoes", posto.Observacoes);
                comando.AdicionarParametro("@idendereco", posto.Endereco.Id);
                comando.AdicionarParametro("@iddistribuidora", posto.Distribuidora.Id.ToString());
                comando.AdicionarParametro("@idpessoajuridica", posto.PessoaJuridica.Id.ToString());
                comando.AdicionarParametro("@id", posto.Id);
                comando.Executar();
            }
        }

        public void Excluir(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.ExcluirPosto, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            comando.Executar();
        }

        public Midas.Nucleo.Objetos.ObjetoNegocio Localizar(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarPosto, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.PostoConversorDataReader());
            if (lista.Count > 0)
                return (Posto)lista[0];
            return null;
        }

        public System.Collections.IList Localizar()
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarTodosPostos, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            return comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.PostoConversorDataReader());
        }

        #endregion

    }

}
