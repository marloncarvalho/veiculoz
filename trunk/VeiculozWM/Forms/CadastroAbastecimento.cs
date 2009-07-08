using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Midas.VeiculoZ.Objetos;
using Midas.Nucleo.Form;
using Midas.Nucleo.Objetos;
using Midas.VeiculoZ.Validador;
using Midas.Nucleo.Validador;

namespace Midas.VeiculoZ.Forms
{

    public partial class CadastroAbastecimento : CRUDForm
    {

        public CadastroAbastecimento()
        {
            this.ConstrutorMenu = Forms.ConstrutorMenu.Instancia;
            InitializeComponent();
            cmbVeiculos.DataSource = Negocio.NegocioFactory.Instancia.VeiculoNegocio.Listar();
            cmbVeiculos.ValueMember = "Id";
            cmbVeiculos.DisplayMember = "Modelo";

            cmbTipoCombustivel.DataSource = Negocio.NegocioFactory.Instancia.TipoCombustivelNegocio.Listar();
            cmbTipoCombustivel.ValueMember = "Id";
            cmbTipoCombustivel.DisplayMember = "Nome";

            cmbPosto.DataSource = Negocio.NegocioFactory.Instancia.PostoNegocio.Listar();
            cmbPosto.ValueMember = "Id";
            cmbPosto.DisplayMember = "Nome";
        }

        public override void  Limpar()
        {
            tId.Text = "";
            tIdAbastecimento.Text = "";
            tKmFinal.Text = "";
            tKmInicial.Text = "";
            tLitros.Text = "";
            tObs.Text = "";
            tValor.Text = "";
            tValorLitro.Text = "";
            chkTanqueCheio.Checked = false;
            chkViagem.Checked = false;
            cmbPosto.SelectedItem = new Posto();
            cmbTipoCombustivel.SelectedItem = new TipoCombustivel();
            cmbVeiculos.SelectedItem = new Veiculo();
        }

        public override void TratarDados()
        {
            Percurso percurso = (Percurso)GerenciadorDados.Instancia.Get();
            if (percurso != null)
            {
                tId.Text = percurso.Id.ToString();
                tIdAbastecimento.Text = percurso.AbastecimentoInicial.Id.ToString();
                tKmInicial.Value = percurso.OdometroInicio;
                tKmFinal.Value = percurso.OdometroFim;
                chkViagem.Checked = percurso.Viagem;
                cmbVeiculos.SelectedItem = percurso.Veiculo;
                data.Value = percurso.AbastecimentoInicial.Data;
                hora.Value = percurso.AbastecimentoInicial.Data;
                cmbPosto.SelectedItem = percurso.AbastecimentoInicial.Posto;
                cmbTipoCombustivel.SelectedItem = percurso.AbastecimentoInicial.TipoCombustivel;
                chkTanqueCheio.Checked = percurso.AbastecimentoInicial.TanqueCheio;
                tValor.Text = percurso.AbastecimentoInicial.Valor.ToString();
                tValorLitro.Text = percurso.AbastecimentoInicial.ValorLitro.ToString();
                tObs.Text = percurso.AbastecimentoInicial.Observacoes;
                tLitros.Text = percurso.AbastecimentoInicial.Litros.ToString();
            }
            else
            {
                Percurso p = VeiculozFachada.Instancia.ObterUltimoPercurso();
                if (p != null)
                {
                    tKmInicial.Value = p.OdometroFim;
                }
            }
        }

        private void pVoltar_Click(object sender, EventArgs e)
        {
            GerenciadorDados.Instancia.Clear();
            Program.FormStack.Pop(1);

        }

        private void pSalvar_Click(object sender, EventArgs e)
        {
            Percurso percurso = new Percurso();
            Abastecimento abastecimento = new Abastecimento();
            if (tIdAbastecimento.Text != "")
            {
                abastecimento.Id = Int32.Parse(tIdAbastecimento.Text);
            }
            abastecimento.Data = new DateTime(this.data.Value.Year, this.data.Value.Month, this.data.Value.Day, this.hora.Value.Hour, this.hora.Value.Minute, this.hora.Value.Second);
            abastecimento.Observacoes = tObs.Text;
            abastecimento.Posto = (Posto)cmbPosto.SelectedItem;
            abastecimento.TanqueCheio = chkTanqueCheio.Checked;
            abastecimento.TipoCombustivel = (TipoCombustivel)cmbTipoCombustivel.SelectedItem;
            if (tValor.Text != "")
            {
                abastecimento.Valor = decimal.Parse(tValor.Text);
            }
            if (tValorLitro.Text != "")
            {
                abastecimento.ValorLitro = decimal.Parse(tValorLitro.Text);
            }

            percurso.AbastecimentoInicial = abastecimento;
            if (tId.Text != "")
            {
                percurso.Id = Int32.Parse(tId.Text);
            }
            percurso.OdometroFim = (long)tKmFinal.Value;
            percurso.OdometroInicio = (long)tKmInicial.Value;
            percurso.Veiculo = (Veiculo)cmbVeiculos.SelectedItem;
            percurso.Viagem = chkViagem.Checked;

            Validacao validacao = new PercursoValidador().Validar(percurso);
            if (validacao.Passou)
            {
                Negocio.NegocioFactory.Instancia.PercursoNegocio.Salvar(percurso);
                tId.Text = percurso.Id.ToString();
                MessageBox.Show("Abastecimento Cadastrado com Sucesso.", "Informação");
            }
            else
            {
                MessageBox.Show(validacao.Mensagem, "Erro");
            }
        }

        private void pExcluir_Click(object sender, EventArgs e)
        {
            if (tId.Text != "")
            {
                int id = Int32.Parse(tId.Text);
                Negocio.NegocioFactory.Instancia.PercursoNegocio.Excluir(id);
            }
        }

        public override void Lembrar()
        {
            cmbVeiculos.DataSource = Negocio.NegocioFactory.Instancia.VeiculoNegocio.Listar();
            cmbVeiculos.ValueMember = "Id";
            cmbVeiculos.DisplayMember = "Modelo";

            cmbTipoCombustivel.DataSource = Negocio.NegocioFactory.Instancia.TipoCombustivelNegocio.Listar();
            cmbTipoCombustivel.ValueMember = "Id";
            cmbTipoCombustivel.DisplayMember = "Nome";

            cmbPosto.DataSource = Negocio.NegocioFactory.Instancia.PostoNegocio.Listar();
            cmbPosto.ValueMember = "Id";
            cmbPosto.DisplayMember = "Nome";

        }

        private void pAddPosto_Click(object sender, EventArgs e)
        {
            GerenciadorDados.Instancia.Clear();
            Program.FormStack.Remember();
            Program.FormStack.Push(typeof(CadastroPostos));
        }

        private void pAddTipo_Click(object sender, EventArgs e)
        {
            GerenciadorDados.Instancia.Clear();
            Program.FormStack.Remember();
            Program.FormStack.Push(typeof(CadastroTiposCombustivel));
        }

        private void pAddVeiculo_Click(object sender, EventArgs e)
        {
            GerenciadorDados.Instancia.Clear();
            Program.FormStack.Remember();
            Program.FormStack.Push(typeof(CadastroVeiculos));
        }

        private void CalcularLitros()
        {
            if (tValor.Text != "" && tValorLitro.Text != "")
            {
                try
                {
                    decimal valor = Decimal.Parse(tValor.Text);
                    decimal valorLitro = Decimal.Parse(tValorLitro.Text);
                    tLitros.Text = (valor/valorLitro).ToString("N3");
                }
                catch (Exception e)
                {
                    tLitros.Text = "";
                }
            }
        }

        private void tValorLitro_KeyUp(object sender, KeyEventArgs e)
        {
            this.CalcularLitros();
        }

        private void tValor_KeyUp(object sender, KeyEventArgs e)
        {
            this.CalcularLitros();
        }

    }

}