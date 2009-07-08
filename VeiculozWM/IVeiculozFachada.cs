using System;
using System.Collections;
using System.Linq;
using System.Text;
using Midas.VeiculoZ.Objetos;

namespace Midas.VeiculoZ
{

    /// <summary>
    /// Fachada para o Sistema VeículoZ.
    /// </summary>
    public interface IVeiculozFachada
    {

        /// <summary>
        /// Listar todos os tipos de combustível.
        /// </summary>
        /// <returns>Lista de Tipos de Combustível.</returns>
        IList ListarTiposCombustivel();

        /// <summary>
        /// Salvar um Tipo de Combustível.
        /// </summary>
        /// <param name="tipo">Tipo de Combustível a ser salvo.</param>
        void SalvarTipoCombustivel(Midas.VeiculoZ.Objetos.TipoCombustivel tipo);

        /// <summary>
        /// Excluir um Tipo de Combustível.
        /// </summary>
        /// <param name="id">Identificador</param>
        void ExcluirTipoCombustivel(long id);

        /// <summary>
        /// Listar todos os veículos.
        /// </summary>
        /// <returns>Lista de Veículos</returns>
        IList ListarVeiculos();

        /// <summary>
        /// Salvar um Veículo.
        /// </summary>
        /// <param name="veiculo">Veículo a ser salvo.</param>
        void SalvarVeiculo(Midas.VeiculoZ.Objetos.Veiculo veiculo);

        /// <summary>
        /// Excluir um Veículo.
        /// </summary>
        /// <param name="id">Identificador do Veículo</param>
        void ExcluirVeiculo(long id);

        /// <summary>
        /// Listar todos os postos.
        /// </summary>
        /// <returns>Lista de Postos</returns>
        IList ListarPostos();

        /// <summary>
        /// Salvar um Posto.
        /// </summary>
        /// <param name="posto">Posto a ser salvo.</param>
        void SalvarPosto(Midas.VeiculoZ.Objetos.Posto posto);

        /// <summary>
        /// Excluir um Posto.
        /// </summary>
        /// <param name="id">Identificador do Posto.</param>
        void ExcluirPosto(long id);

        IList ListarDistribuidoras();
        void SalvarDistribuidora(Midas.VeiculoZ.Objetos.Distribuidora distribuidora);
        void ExcluirDistribuidora(long id);
        IList ListarPercursos();
        void SalvarPercurso(Midas.VeiculoZ.Objetos.Percurso percurso);
        void ExcluirPercurso(long id);
        Percurso ObterUltimoPercurso();
        Percurso ObterPercurso(long id);
    }

}
