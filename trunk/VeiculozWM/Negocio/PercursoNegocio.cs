using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Negocio;
using Midas.VeiculoZ.Objetos;
using Midas.VeiculoZ.Dados.SQLServer;
using System.Collections;

namespace Midas.VeiculoZ.Negocio
{

    public class PercursoNegocio:NegocioGenerico
    {

        public PercursoNegocio()
        {
            this.AcessoDados = new Dados.SQLServer.PercursoDados();
        }

        public override void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Percurso percurso = (Percurso)objeto;
            
            Negocio.NegocioFactory.Instancia.AbastecimentoNegocio.Salvar(percurso.AbastecimentoInicial);
            if (percurso.AbastecimentoFinal != null)
            {
                Negocio.NegocioFactory.Instancia.AbastecimentoNegocio.Salvar(percurso.AbastecimentoFinal);
            }

            // TODO Ainda falta checar a invalidez do percurso.
            if (percurso.Id == null || percurso.Id == 0)
            {
                Percurso ultimoPercurso = this.ObterUltimoPercurso();
                if (ultimoPercurso != null)
                {
                    ultimoPercurso.AbastecimentoFinal = percurso.AbastecimentoInicial;
                    base.Salvar(ultimoPercurso);
                }
            }
            else
            {
                PercursoDados dados = (PercursoDados)this.AcessoDados;
                int id = dados.ObterIdAbastecimentoFinal(percurso.Id);
                Abastecimento abast = new Abastecimento();
                abast.Id = id;
                percurso.AbastecimentoFinal = abast;
            }

            // Salvar o Percurso.
            base.Salvar(percurso);
        }

        public override void Excluir(long id)
        {
            Percurso percurso = (Percurso)this.Obter(id);
            if (percurso.AbastecimentoInicial != null)
            {
                Negocio.NegocioFactory.Instancia.AbastecimentoNegocio.Excluir(percurso.AbastecimentoInicial.Id);
            }
            if (percurso.AbastecimentoFinal != null)
            {
                Negocio.NegocioFactory.Instancia.AbastecimentoNegocio.Excluir(percurso.AbastecimentoFinal.Id);
            }
            base.Excluir(id);
        }

        public Percurso ObterUltimoPercurso()
        {
            PercursoDados dados = (PercursoDados) this.AcessoDados;
            return dados.ObterUltimoPercurso();
        }

        public IList ListarVisao()
        {
            PercursoDados dados = (PercursoDados) this.AcessoDados;
            return dados.ListarDadosVisao();
        }

    }

}