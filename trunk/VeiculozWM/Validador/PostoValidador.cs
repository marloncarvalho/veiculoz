using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.VeiculoZ.Objetos;
using Midas.Nucleo.Validador;

namespace Midas.VeiculoZ.Validador
{
    public class PostoValidador:Midas.Nucleo.Validador.IValidador
    {

        #region IValidador Members

        public Midas.Nucleo.Validador.Validacao Validar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Validacao v = new Validacao();
            Posto posto = (Posto)objeto;
            v.Passou = true;
            if (posto.Distribuidora == null)
            {
                v.Passou = false;
                v.AdicionarMensagem("Informe a Distribuidora.");
            }
            if (posto.Nome == null || posto.Nome == "")
            {
                v.Passou = false;
                v.AdicionarMensagem("Informe o Nome.");
            }
            return v;
        }

        #endregion

    }

}
