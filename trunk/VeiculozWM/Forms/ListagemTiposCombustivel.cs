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
    public partial class ListagemTiposCombustivel : ListForm
    {
        private IList lista;

        public ListagemTiposCombustivel()
        {
            this.ConstrutorMenu = Forms.ConstrutorMenu.Instancia;
            InitializeComponent();
        }

        public override void TratarDados()
        {
            lista = VeiculozFachada.Instancia.ListarTiposCombustivel();
            this.dataGrid.DataSource = lista;
            this.dataGridTableStyle1.MappingName = dataGrid.DataSource.GetType().Name;
        }

        private void pNovo_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(CadastroTiposCombustivel));
        }

        private void pVoltar_Click(object sender, EventArgs e)
        {
            Program.FormStack.Pop(1);
        }

        private void pExcluir_Click(object sender, EventArgs e)
        {
            TipoCombustivel tipo = (TipoCombustivel)lista[this.dataGrid.CurrentRowIndex];
            VeiculozFachada.Instancia.ExcluirTipoCombustivel(tipo.Id);
            this.TratarDados();
        }

        private void pEditar_Click(object sender, EventArgs e)
        {
            TipoCombustivel tipo = (TipoCombustivel)lista[this.dataGrid.CurrentRowIndex];
            GerenciadorDados.Instancia.Set(tipo);
            Program.FormStack.Push(typeof(CadastroTiposCombustivel));
        }

    }

}