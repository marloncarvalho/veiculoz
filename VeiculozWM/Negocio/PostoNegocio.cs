using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Midas.Nucleo.Negocio;
using Midas.VeiculoZ.Objetos;

namespace Midas.VeiculoZ.Negocio
{
    
    public class PostoNegocio:Midas.Nucleo.Negocio.NegocioGenerico
    {
        private EnderecoNegocio enderecoNegocio = new EnderecoNegocio();
        private PessoaJuridicaNegocio pessoaJuridicaNegocio = Midas.Nucleo.Negocio.NegocioFactory.Instancia.PessoaJuridicaNegocio;

        public PostoNegocio()
        {
            this.AcessoDados = new Midas.VeiculoZ.Dados.SQLServer.PostoDados();
        }

        public override void Salvar(Midas.Nucleo.Objetos.ObjetoNegocio objeto)
        {
            Posto posto = (Posto)objeto;
            pessoaJuridicaNegocio.Salvar(posto.PessoaJuridica);
            enderecoNegocio.Salvar(posto.Endereco);
            base.Salvar(posto);
        }

        public override void Excluir(long id)
        {
            Posto posto = (Posto)this.Obter(id);
            enderecoNegocio.Excluir(posto.Endereco.Id);
            pessoaJuridicaNegocio.Excluir(posto.PessoaJuridica.Id);
            base.Excluir(id);
        }

    }

}
