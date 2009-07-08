using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Midas.Nucleo.Form;

namespace Midas.VeiculoZ.Forms
{
    public partial class Inicio : ListForm
    {
        public Inicio()
        {
            this.ConstrutorMenu = Forms.ConstrutorMenu.Instancia;
            InitializeComponent();
        }

        private void pPostos_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(ListagemPostos));
        }

        private void pAbastecimentos_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(ListagemAbastecimentos));
        }

    }

}