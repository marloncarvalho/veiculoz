using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Midas.VeiculoZ.Objetos;
using Midas.Nucleo.Form;

namespace Midas.VeiculoZ.Forms
{
    public partial class ListagemDistribuidoras : ListForm
    {
        private IList lista;

        public ListagemDistribuidoras()
        {
            this.ConstrutorMenu = Forms.ConstrutorMenu.Instancia;
            InitializeComponent();
        }

        public override void TratarDados()
        {
            lista = VeiculozFachada.Instancia.ListarDistribuidoras();
            this.dataGrid.DataSource = lista;
            this.dataGridTableStyle1.MappingName = dataGrid.DataSource.GetType().Name;
        }

        private void pNovo_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(CadastroDistribuidoras));
        }

        private void pVoltar_Click(object sender, EventArgs e)
        {
            Program.FormStack.Pop(1);
        }

        private void pExcluir_Click(object sender, EventArgs e)
        {
            Distribuidora distribuidora = (Distribuidora)lista[this.dataGrid.CurrentRowIndex];
            VeiculozFachada.Instancia.ExcluirDistribuidora(distribuidora.Id);
            this.TratarDados();
        }

        private void pEditar_Click(object sender, EventArgs e)
        {
            Distribuidora distribuidora = (Distribuidora)lista[this.dataGrid.CurrentRowIndex];
            GerenciadorDados.Instancia.Set(distribuidora);
            Program.FormStack.Push(typeof(CadastroDistribuidoras));
        }

    }

}