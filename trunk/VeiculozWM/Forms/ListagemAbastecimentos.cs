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
    public partial class ListagemAbastecimentos: ListForm
    {
        private IList lista;

        public ListagemAbastecimentos()
        {
            this.ConstrutorMenu = Forms.ConstrutorMenu.Instancia;
            InitializeComponent();
        }

        public override void TratarDados()
        {
            lista = VeiculozFachada.Instancia.ListarPercursos();
            this.dataGrid.DataSource = lista;
            this.dataGridTableStyle1.MappingName = dataGrid.DataSource.GetType().Name;
        }

        private void pNovo_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(CadastroAbastecimento));
        }

        private void pVoltar_Click(object sender, EventArgs e)
        {
            Program.FormStack.Pop(1);
        }

        private void pExcluir_Click(object sender, EventArgs e)
        {
            Percurso percurso = (Percurso)lista[this.dataGrid.CurrentRowIndex];
            VeiculozFachada.Instancia.ExcluirPercurso(percurso.Id);
            this.TratarDados();
        }

        private void pEditar_Click(object sender, EventArgs e)
        {
            Percurso percurso = (Percurso)lista[this.dataGrid.CurrentRowIndex];
            Percurso obtido = VeiculozFachada.Instancia.ObterPercurso(percurso.Id);
            GerenciadorDados.Instancia.Set(obtido);
            Program.FormStack.Push(typeof(CadastroAbastecimento));
        }

    }

}