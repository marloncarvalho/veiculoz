using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.VeiculoZ.Recursos;
using Midas.Nucleo.Recursos;
using Midas.Nucleo.Dados.SQLServerCE;
using Midas.VeiculoZ.Objetos;

namespace Midas.VeiculoZ.Negocio
{

    /// <summary>
    /// Carga do Sistema VeículoZ.
    /// </summary>
    public class CargaVeiculoz:Midas.Nucleo.Negocio.ICargaSistema
    {

        #region ICargaSistema Members

        public void Iniciar()
        {
            SQLServerCE servidor = new SQLServerCE(Midas.Nucleo.Recursos.ConstantesGerais.BancoVeiculoZ);

            // Criar o banco de dados para o Financeiro.
            if (!servidor.BancoExiste())
            {
                servidor.CriarBancoDados();
                this.IniciarTabelas();
                this.CriarDadosIniciais();
            }

        }

        private void CriarDadosIniciais()
        {
            Distribuidora shell = new Distribuidora();
            shell.Nome = "Shell";
            VeiculozFachada.Instancia.SalvarDistribuidora(shell);

            Distribuidora br = new Distribuidora();
            br.Nome = "BR Distribuidora";
            VeiculozFachada.Instancia.SalvarDistribuidora(br);

            Distribuidora esso = new Distribuidora();
            esso.Nome = "Esso";
            VeiculozFachada.Instancia.SalvarDistribuidora(esso);

            Distribuidora ipiranga = new Distribuidora();
            ipiranga.Nome = "Ipiranga";
            VeiculozFachada.Instancia.SalvarDistribuidora(ipiranga);

            TipoCombustivel alcool = new TipoCombustivel();
            alcool.Nome = "Álcool";
            VeiculozFachada.Instancia.SalvarTipoCombustivel(alcool);

            TipoCombustivel gasolina = new TipoCombustivel();
            gasolina.Nome = "Gasolina Aditivada";
            VeiculozFachada.Instancia.SalvarTipoCombustivel(gasolina);

            TipoCombustivel gasolina2 = new TipoCombustivel();
            gasolina2.Nome = "Gasolina Comum";
            VeiculozFachada.Instancia.SalvarTipoCombustivel(gasolina2);

            TipoCombustivel gnv = new TipoCombustivel();
            gnv.Nome = "GNV";
            VeiculozFachada.Instancia.SalvarTipoCombustivel(gnv);

            TipoCombustivel diesel = new TipoCombustivel();
            diesel.Nome = "Diesel";
            VeiculozFachada.Instancia.SalvarTipoCombustivel(diesel);
        }

        private void IniciarTabelas()
        {
            new Comando(ConstantesDados.TabelaTipoCombustivel, ConstantesGerais.BancoVeiculoZ).Executar();
            new Comando(ConstantesDados.TabelaVeiculo, ConstantesGerais.BancoVeiculoZ).Executar();
            new Comando(ConstantesDados.TabelaDistribuidora, ConstantesGerais.BancoVeiculoZ).Executar();
            new Comando(ConstantesDados.TabelaPosto, ConstantesGerais.BancoVeiculoZ).Executar();
            new Comando(ConstantesDados.TabelaPercurso, ConstantesGerais.BancoVeiculoZ).Executar();
            new Comando(ConstantesDados.TabelaAbastecimento, ConstantesGerais.BancoVeiculoZ).Executar();
        }

        #endregion

    }

}
