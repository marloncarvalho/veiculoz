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
using Midas.VeiculoZ.Validador;
using Midas.Nucleo.Validador;
using Midas.Nucleo.Objetos;

namespace Midas.VeiculoZ.Forms
{

    public partial class CadastroDistribuidoras : CRUDForm
    {

        public override void Limpar()
        {
            this.tId.Text = "";
            this.tNome.Text = "";
        }

        public override void TratarDados()
        {
            Distribuidora distribuidora = (Distribuidora)GerenciadorDados.Instancia.Get();

            if (distribuidora  != null)
            {
                this.tId.Text = distribuidora.Id.ToString();
                this.tNome.Text = distribuidora.Nome;
            }
            else
            {
                this.tId.Text = "";
                this.tNome.Text = "";
            }
        }

        public CadastroDistribuidoras()
        {
            this.ConstrutorMenu = Forms.ConstrutorMenu.Instancia;
            this.Validador = new DistribuidoraValidador();
            InitializeComponent();
        }

        private void pVoltar_Click(object sender, EventArgs e)
        {
            GerenciadorDados.Instancia.Clear();
            Program.FormStack.Pop(1);
        }

        public override Midas.Nucleo.Objetos.ObjetoNegocio ConstruirObjeto()
        {
            Distribuidora distribuidora = new Distribuidora();
            if (this.tId.Text != "")
            {
                distribuidora.Id = Int32.Parse(this.tId.Text);
            }
            distribuidora.Nome = this.tNome.Text;
            return distribuidora;
        }

        public override void DoSalvar(ObjetoNegocio objeto)
        {
            Distribuidora distribuidora = (Distribuidora)objeto;
            Midas.VeiculoZ.VeiculozFachada.Instancia.SalvarDistribuidora(distribuidora);
            this.tId.Text = distribuidora.Id.ToString();
        }

        private void pSalvar_Click(object sender, EventArgs e)
        {
            base.Salvar();
        }

        private void pExcluir_Click(object sender, EventArgs e)
        {
            if (this.tId.Text != "")
            {
                long id = Int32.Parse(this.tId.Text);
                VeiculozFachada.Instancia.ExcluirDistribuidora(id);
                Program.FormStack.Pop(1);
            }
        }

    }

}