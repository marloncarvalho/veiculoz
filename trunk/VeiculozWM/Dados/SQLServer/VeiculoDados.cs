using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.VeiculoZ.Objetos;
using Midas.Nucleo.Dados.SQLServerCE;
using System.Collections;
using Midas.Nucleo.Dados;

namespace Midas.VeiculoZ.Dados.SQLServer
{
    
    public class VeiculoDados:IAcessoDados
    {

        #region IAcessoDados Members

        public void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Veiculo veiculo = (Veiculo)objeto;
            if (veiculo.Id == 0)
            {
                Comando comando = new Comando(Recursos.ConstantesDados.InserirVeiculo, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@placa", veiculo.Placa);
                comando.AdicionarParametro("@renavam", veiculo.Renavam);
                comando.AdicionarParametro("@modelo", veiculo.Modelo);
                comando.AdicionarParametro("@marca", veiculo.Marca);
                comando.AdicionarParametro("@cor", veiculo.Cor);
                veiculo.Id = comando.ExecutarInsercao();
            }
            else
            {
                Comando comando = new Comando(Recursos.ConstantesDados.AtualizarVeiculo, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
                comando.AdicionarParametro("@placa", veiculo.Placa);
                comando.AdicionarParametro("@renavam", veiculo.Renavam);
                comando.AdicionarParametro("@modelo", veiculo.Modelo);
                comando.AdicionarParametro("@marca", veiculo.Marca);
                comando.AdicionarParametro("@cor", veiculo.Cor);
                comando.AdicionarParametro("@id", veiculo.Id);
                comando.Executar();
            }
        }

        public void Excluir(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.ExcluirVeiculo, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            comando.Executar();
        }

        public Midas.Nucleo.Objetos.ObjetoNegocio Localizar(long id)
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarVeiculo, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            comando.AdicionarParametro("@id", id);
            IList lista = comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.VeiculoConversorDataReader());
            if (lista.Count > 0)
                return (Veiculo)lista[0];
            return null;
        }

        public System.Collections.IList Localizar()
        {
            Comando comando = new Comando(Recursos.ConstantesDados.SelecionarTodosVeiculos, Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);
            return comando.ExecutarQuery(new Midas.VeiculoZ.Conversores.VeiculoConversorDataReader());
        }

        #endregion

    }

}
