using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.VeiculoZ.Objetos;

namespace Midas.VeiculoZ
{

    /// <summary>
    /// Fachada.
    /// </summary>
    public class VeiculozFachada:IVeiculozFachada
    {
        private static IVeiculozFachada instancia = new VeiculozFachada();
        public static IVeiculozFachada Instancia
        {
            get { return VeiculozFachada.instancia; }
            set { VeiculozFachada.instancia = value; }
        }

        private VeiculozFachada() { }

        #region IVeiculozFachada Members

        public System.Collections.IList  ListarTiposCombustivel()
        {
            return Negocio.NegocioFactory.Instancia.TipoCombustivelNegocio.Listar();
        }

        public void SalvarTipoCombustivel(Midas.VeiculoZ.Objetos.TipoCombustivel tipo)
        {
            Negocio.NegocioFactory.Instancia.TipoCombustivelNegocio.Salvar(tipo);
        }

        public void ExcluirTipoCombustivel(long id)
        {
            Negocio.NegocioFactory.Instancia.TipoCombustivelNegocio.Excluir(id);
        }

        public System.Collections.IList ListarVeiculos()
        {
            return Negocio.NegocioFactory.Instancia.VeiculoNegocio.Listar();
        }

        public void SalvarVeiculo(Midas.VeiculoZ.Objetos.Veiculo veiculo)
        {
            Negocio.NegocioFactory.Instancia.VeiculoNegocio.Salvar(veiculo);
        }

        public void ExcluirVeiculo(long id)
        {
            Negocio.NegocioFactory.Instancia.VeiculoNegocio.Excluir(id);
        }

        public System.Collections.IList ListarPostos()
        {
            return Negocio.NegocioFactory.Instancia.PostoNegocio.Listar();
        }

        public void SalvarPosto(Midas.VeiculoZ.Objetos.Posto posto)
        {
            Negocio.NegocioFactory.Instancia.PostoNegocio.Salvar(posto);
        }

        public void ExcluirPosto(long id)
        {
            Negocio.NegocioFactory.Instancia.PostoNegocio.Excluir(id);
        }

        public System.Collections.IList ListarDistribuidoras()
        {
            return Negocio.NegocioFactory.Instancia.DistribuidoraNegocio.Listar();
        }

        public void SalvarDistribuidora(Midas.VeiculoZ.Objetos.Distribuidora distribuidora)
        {
            Negocio.NegocioFactory.Instancia.DistribuidoraNegocio.Salvar(distribuidora);
        }

        public void ExcluirDistribuidora(long id)
        {
            Negocio.NegocioFactory.Instancia.DistribuidoraNegocio.Excluir(id);
        }

        public System.Collections.IList ListarPercursos()
        {
            return Negocio.NegocioFactory.Instancia.PercursoNegocio.ListarVisao();
        }

        public void SalvarPercurso(Midas.VeiculoZ.Objetos.Percurso percurso)
        {
            Negocio.NegocioFactory.Instancia.PercursoNegocio.Salvar(percurso);
        }

        public void ExcluirPercurso(long id)
        {
            Negocio.NegocioFactory.Instancia.PercursoNegocio.Excluir(id);
        }


        public Midas.VeiculoZ.Objetos.Percurso ObterUltimoPercurso()
        {
            return Negocio.NegocioFactory.Instancia.PercursoNegocio.ObterUltimoPercurso();
        }

        public Midas.VeiculoZ.Objetos.Percurso ObterPercurso(long id)
        {
            return (Percurso)Negocio.NegocioFactory.Instancia.PercursoNegocio.Obter(id);
        }

        #endregion
    }

}
