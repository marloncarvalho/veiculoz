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
    public partial class ListagemPostos: ListForm
    {
        private IList lista;

        public ListagemPostos()
        {
            this.ConstrutorMenu = Forms.ConstrutorMenu.Instancia;
            InitializeComponent();
        }

        public override void TratarDados()
        {
            lista = VeiculozFachada.Instancia.ListarPostos();
            this.dataGrid.DataSource = lista;
            this.dataGridTableStyle1.MappingName = dataGrid.DataSource.GetType().Name;
        }

        private void pNovo_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(CadastroPostos));
        }

        private void pVoltar_Click(object sender, EventArgs e)
        {
            Program.FormStack.Pop(1);
        }

        private void pExcluir_Click(object sender, EventArgs e)
        {
            Posto posto = (Posto)lista[this.dataGrid.CurrentRowIndex];
            VeiculozFachada.Instancia.ExcluirPosto(posto.Id);
            this.TratarDados();
        }

        private void pEditar_Click(object sender, EventArgs e)
        {
            Posto posto = (Posto)lista[this.dataGrid.CurrentRowIndex];
            GerenciadorDados.Instancia.Set(posto);
            Program.FormStack.Push(typeof(CadastroPostos));
        }

    }

}