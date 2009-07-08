using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Validador;
using Midas.VeiculoZ.Objetos;

namespace Midas.VeiculoZ.Validador
{
    public class DistribuidoraValidador:IValidador
    {
        #region IValidador Members

        public Validacao Validar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Distribuidora distribuidora = (Distribuidora)objeto;
            if (distribuidora.Nome == null || distribuidora.Nome == "")
            {
                return new Validacao(false, "Informe o Nome da Distribuidora.");
            }
            return new Validacao(true, "");
        }

        #endregion
    }
}
