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

    public partial class CadastroTiposCombustivel : CRUDForm
    {

        public override void Limpar()
        {
            this.tId.Text = "";
            this.tNome.Text = "";
        }

        public override void TratarDados()
        {
            TipoCombustivel tipoCombustivel = (TipoCombustivel)GerenciadorDados.Instancia.Get();

            if (tipoCombustivel != null)
            {
                this.tId.Text = tipoCombustivel.Id.ToString();
                this.tNome.Text = tipoCombustivel.Nome;
            }
            else
            {
                this.tId.Text = "";
                this.tNome.Text = "";
            }
        }

        public CadastroTiposCombustivel()
        {
            this.ConstrutorMenu = Forms.ConstrutorMenu.Instancia;
            InitializeComponent();
        }

        private void pVoltar_Click(object sender, EventArgs e)
        {
            GerenciadorDados.Instancia.Clear();
            Program.FormStack.Pop(1);
        }

        private void pSalvar_Click(object sender, EventArgs e)
        {
            TipoCombustivel tipo = new TipoCombustivel();
            if (this.tId.Text != "")
            {
                tipo.Id = Int32.Parse(this.tId.Text);
            }
            tipo.Nome = this.tNome.Text;
            Midas.VeiculoZ.VeiculozFachada.Instancia.SalvarTipoCombustivel(tipo);
            this.tId.Text = tipo.Id.ToString();
        }

        private void pExcluir_Click(object sender, EventArgs e)
        {
            if (this.tId.Text != "")
            {
                long id = Int32.Parse(this.tId.Text);
                VeiculozFachada.Instancia.ExcluirTipoCombustivel(id);
                Program.FormStack.Pop(1);
            }
        }


    }

}