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

namespace Midas.VeiculoZ.Forms
{
    public partial class CadastroVeiculos : CRUDForm
    {
        public CadastroVeiculos()
        {
            this.ConstrutorMenu = Forms.ConstrutorMenu.Instancia;
            InitializeComponent();
        }

        public override void  Limpar()
        {
            this.tId.Text = "";
            this.tCor.Text = "";
            this.tMarca.Text = "";
            this.tModelo.Text = "";
            this.tPlaca.Text = "";
            this.tRenavam.Text = "";
        }

        public override void TratarDados()
        {
            Veiculo veiculo = (Veiculo)GerenciadorDados.Instancia.Get();

            if (veiculo != null)
            {
                this.tId.Text = veiculo.Id.ToString();
                this.tCor.Text = veiculo.Cor;
                this.tMarca.Text = veiculo.Marca;
                this.tModelo.Text = veiculo.Modelo;
                this.tPlaca.Text = veiculo.Placa;
                this.tRenavam.Text = veiculo.Renavam;
            }
            else
            {
                this.Limpar();
            }
        }

        private void pVoltar_Click(object sender, EventArgs e)
        {
            GerenciadorDados.Instancia.Clear();
            Program.FormStack.Pop(1);

        }

        private void pSalvar_Click(object sender, EventArgs e)
        {
            Veiculo veiculo = new Veiculo();
            if (this.tId.Text != "")
            {
                veiculo.Id = Int32.Parse(this.tId.Text);
            }
            veiculo.Cor = tCor.Text;
            veiculo.Renavam = tRenavam.Text;
            veiculo.Placa = tPlaca.Text;
            veiculo.Marca = tMarca.Text;
            veiculo.Modelo = tModelo.Text;
            VeiculozFachada.Instancia.SalvarVeiculo(veiculo);
            this.tId.Text = veiculo.Id.ToString();
        }

        private void pExcluir_Click(object sender, EventArgs e)
        {
            if (this.tId.Text != "")
            {
                long id = Int32.Parse(this.tId.Text);
                VeiculozFachada.Instancia.ExcluirVeiculo(id);
                Program.FormStack.Pop(1);
            }
        }

    }
}