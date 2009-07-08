using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Midas.Nucleo.Form;

namespace Midas.VeiculoZ
{
    static class Program
    {
        private static FormStack formStack = new FormStack();
        public static FormStack FormStack
        {
            get { return Program.formStack; }
            set { Program.formStack = value; }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            new Midas.Nucleo.Negocio.Carga().Iniciar();
            new VeiculoZ.Negocio.CargaVeiculoz().Iniciar();

            formStack.Push(typeof(Forms.Inicio));
            try
            {
                formStack.Run();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}