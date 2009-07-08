using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Midas.VeiculoZ.Negocio
{

    public sealed class NegocioFactory
    {

        private static NegocioFactory instancia = new NegocioFactory();
        public static NegocioFactory Instancia
        {
            get { return instancia; }
            set { instancia = value; }
        }

        private TipoCombustivelNegocio tipoCombustivelNegocio;
        public TipoCombustivelNegocio TipoCombustivelNegocio
        {
            get 
            {
                if (tipoCombustivelNegocio == null)
                {
                    tipoCombustivelNegocio = new TipoCombustivelNegocio();
                }
                return tipoCombustivelNegocio; 
            }
            set { tipoCombustivelNegocio = value; }
        }

        private VeiculosNegocio veiculoNegocio;
        public VeiculosNegocio VeiculoNegocio
        {
            get 
            {
                if (veiculoNegocio == null)
                {
                    veiculoNegocio = new VeiculosNegocio();
                }
                return veiculoNegocio; 
            }
            set { veiculoNegocio = value; }
        }

        private PostoNegocio postoNegocio;
        public PostoNegocio PostoNegocio
        {
            get 
            {
                if (postoNegocio == null)
                {
                    postoNegocio = new PostoNegocio();
                }
                return postoNegocio; 
            }
            set { postoNegocio = value; }
        }

        private DistribuidoraNegocio distribuidoraNegocio;
        public DistribuidoraNegocio DistribuidoraNegocio
        {
            get 
            {
                if (distribuidoraNegocio == null)
                {
                    distribuidoraNegocio = new DistribuidoraNegocio();
                }
                return distribuidoraNegocio; 
            }
            set { distribuidoraNegocio = value; }
        }

        private PercursoNegocio percursoNegocio;
        public PercursoNegocio PercursoNegocio
        {
            get 
            {
                if (percursoNegocio == null)
                {
                    percursoNegocio = new PercursoNegocio();
                }
                return percursoNegocio; 
            }
            set { percursoNegocio = value; }
        }

        private AbastecimentoNegocio abastecimentoNegocio;
        public AbastecimentoNegocio AbastecimentoNegocio
        {
            get 
            {
                if (abastecimentoNegocio == null)
                {
                    abastecimentoNegocio = new AbastecimentoNegocio();
                }
                return abastecimentoNegocio; 
            }
            set { abastecimentoNegocio = value; }
        }
    }

}
