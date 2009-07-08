using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Midas.Nucleo.Form;

namespace Midas.VeiculoZ.Forms
{
    public sealed class ConstrutorMenu:IConstrutorMenu
    {
        private System.Windows.Forms.MenuItem miOpcoes = new System.Windows.Forms.MenuItem();
        private System.Windows.Forms.MenuItem miOpcoesCadastros = new System.Windows.Forms.MenuItem();
        private System.Windows.Forms.MenuItem miOpcoesCadastros_TipoCombustivel = new System.Windows.Forms.MenuItem();
        private System.Windows.Forms.MenuItem miOpcoesCadastros_Veiculos = new System.Windows.Forms.MenuItem();
        private System.Windows.Forms.MenuItem miOpcoesCadastros_Distribuidoras = new System.Windows.Forms.MenuItem();
        private System.Windows.Forms.MenuItem miOpcoesCadastros_Postos = new System.Windows.Forms.MenuItem();
        private System.Windows.Forms.MainMenu mainMenu = new System.Windows.Forms.MainMenu();

        private static ConstrutorMenu instancia = new ConstrutorMenu();
        public static ConstrutorMenu Instancia
        {
            get { return ConstrutorMenu.instancia; }
            set { ConstrutorMenu.instancia = value; }
        }

        private ConstrutorMenu()
        {
            this.miOpcoes = new System.Windows.Forms.MenuItem();
            this.miOpcoes.Text = "Opções";
            this.miOpcoes.MenuItems.Add(this.miOpcoesCadastros);
            this.miOpcoesCadastros.Text = "Cadastros";
            this.miOpcoesCadastros_Postos.Text = "Postos";
            this.miOpcoesCadastros_TipoCombustivel.Text = "Tipo de Combustível";
            this.miOpcoesCadastros_Veiculos.Text = "Veículos";
            this.miOpcoesCadastros_Distribuidoras.Text = "Distribuidoras";
            this.miOpcoesCadastros.MenuItems.Add(this.miOpcoesCadastros_Postos);
            this.miOpcoesCadastros.MenuItems.Add(this.miOpcoesCadastros_TipoCombustivel);
            this.miOpcoesCadastros.MenuItems.Add(this.miOpcoesCadastros_Veiculos);
            this.miOpcoesCadastros.MenuItems.Add(this.miOpcoesCadastros_Distribuidoras);
            this.mainMenu.MenuItems.Add(this.miOpcoes);
            this.miOpcoesCadastros_TipoCombustivel.Click += new System.EventHandler(this.miOpcoesCadastros_TipoCombustivel_Click);
            this.miOpcoesCadastros_Veiculos.Click += new System.EventHandler(this.miOpcoesCadastros_Veiculo_Click);
            this.miOpcoesCadastros_Distribuidoras.Click += new System.EventHandler(this.miOpcoesCadastros_Distribuidoras_Click);
            this.miOpcoesCadastros_Postos.Click += new System.EventHandler(this.miOpcoesCadastros_Postos_Click);
        }

        public MainMenu Construir()
        {
            return this.mainMenu;
        }

        private void miOpcoesCadastros_TipoCombustivel_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(ListagemTiposCombustivel));
        }
        
        private void miOpcoesCadastros_Veiculo_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(ListagemVeiculos));
        }

        private void miOpcoesCadastros_Distribuidoras_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(ListagemDistribuidoras));
        }

        private void miOpcoesCadastros_Postos_Click(object sender, EventArgs e)
        {
            Program.FormStack.Push(typeof(ListagemPostos));
        }

    }
}
