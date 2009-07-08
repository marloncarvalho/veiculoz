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
using Midas.Nucleo.Validador;

namespace Midas.VeiculoZ.Forms
{

    public partial class CadastroPostos : CRUDForm
    {

        public CadastroPostos()
        {
            this.ConstrutorMenu = Forms.ConstrutorMenu.Instancia;
            InitializeComponent();
            this.cmbDistribuidora.ValueMember = "Id";
            this.cmbDistribuidora.DisplayMember = "Nome";
            this.cmbDistribuidora.DataSource = VeiculozFachada.Instancia.ListarDistribuidoras();
        }

        public override void  Limpar()
        {
            this.tId.Text = "";
            this.tEnderecoId.Text = "";
            this.tBairro.Text = "";
            this.tCEP.Text = "";
            this.tRua.Text = "";
            this.tNumero.Text = "";
            this.tComplemento.Text = "";
            this.cmbCidade.SelectedItem = null;
            this.tCNPJ.Text = "";
            this.tPJId.Text = "";
            this.tNome.Text = "";
            this.tObs.Text = "";

        }

        public override void TratarDados()
        {
            Posto posto = (Posto)GerenciadorDados.Instancia.Get();
            if (posto != null)
            {
                this.tId.Text = posto.Id.ToString();
                // Endereço
                this.tEnderecoId.Text = posto.Endereco.Id.ToString();
                this.tBairro.Text = posto.Endereco.Bairro;
                this.tCEP.Text = posto.Endereco.CodigoPostal;
                this.tRua.Text = posto.Endereco.Logradouro;
                this.tNumero.Text = posto.Endereco.Numero;
                this.tComplemento.Text = posto.Endereco.Complemento;
                if ( posto.Endereco.Cidade != null ) 
                {
                    this.cmbCidade.SelectedItem = posto.Endereco;
                }
                // Empresa.
                this.tCNPJ.Text = posto.PessoaJuridica.CNPJ;
                this.tPJId.Text = posto.PessoaJuridica.Id.ToString();
                // Posto.
                this.tNome.Text = posto.PessoaJuridica.NomeFantasia;
                this.tObs.Text = posto.Observacoes;
            }
        }

        private void pVoltar_Click(object sender, EventArgs e)
        {
            GerenciadorDados.Instancia.Clear();
            Program.FormStack.Pop(1);

        }

        private void pSalvar_Click(object sender, EventArgs e)
        {
            Posto posto = new Posto();
            if (this.tId.Text != "")
            {
                posto.Id = Int32.Parse(this.tId.Text);
            }
            PessoaJuridica pj = new PessoaJuridica();
            if (this.tPJId.Text != "")
            {
                pj.Id = Int32.Parse(this.tPJId.Text);
            }
            pj.CNPJ = this.tCNPJ.Text;
            pj.NomeFantasia = tNome.Text;
            posto.PessoaJuridica = pj;
            posto.Observacoes = this.tObs.Text;
            posto.Distribuidora = (Distribuidora)this.cmbDistribuidora.SelectedItem;
            Endereco endereco = new Endereco();
            if (this.tEnderecoId.Text != "")
            {
                endereco.Id = Int32.Parse(this.tEnderecoId.Text);
            }
            endereco.Bairro = this.tBairro.Text;
            endereco.Logradouro = this.tRua.Text;
            endereco.Complemento = this.tComplemento.Text;
            endereco.CodigoPostal = this.tCEP.Text;
            endereco.Numero = this.tNumero.Text;
            endereco.Cidade = null;
            endereco.CodigoPostal = tCEP.Text;
            posto.Endereco = endereco;

            Validacao v = new Midas.VeiculoZ.Validador.PostoValidador().Validar(posto);
            if (v.Passou)
            {
                VeiculozFachada.Instancia.SalvarPosto(posto);
                this.tId.Text = posto.Id.ToString();
                this.tPJId.Text = posto.PessoaJuridica.Id.ToString();
                this.tEnderecoId.Text = posto.Endereco.Id.ToString();
            }
            else
            {
                MessageBox.Show(v.Mensagem, "Erro");
            }
        }

        private void pExcluir_Click(object sender, EventArgs e)
        {
            if (this.tId.Text != "")
            {
                Int32 id = Int32.Parse(this.tId.Text);
                VeiculozFachada.Instancia.ExcluirPosto(id);
                Program.FormStack.Pop(1);
            }
        }

        public override void Lembrar()
        {
            this.cmbDistribuidora.ValueMember = "Id";
            this.cmbDistribuidora.DisplayMember = "Nome";
            this.cmbDistribuidora.DataSource = VeiculozFachada.Instancia.ListarDistribuidoras();
        }

        private void pAddDistrib_Click_1(object sender, EventArgs e)
        {
            GerenciadorDados.Instancia.Clear();
            Program.FormStack.Remember();
            Program.FormStack.Push(typeof(CadastroDistribuidoras));
        }

    }

}