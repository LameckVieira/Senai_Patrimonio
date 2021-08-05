using Senai_Patrimonio_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Patrimonio_API.Interfaces
{
    interface ISalaRepository
    {
        /// <summary>
        /// Lista todas as salas
        /// </summary>
        /// <returns>Uma lista de salas</returns>
        List<Sala> Listar();

        /// <summary>
        /// Cadastra uma nova sala
        /// </summary>
        /// <param name="novaSala">Objeto novaSala que será cadastrado</param>
        void Cadastrar(Sala novaSala);

        /// <summary>
        /// Deleta uma sala existente
        /// </summary>
        /// <param name="id">ID da sala que será deletada</param>
        void Deletar(int id);

        /// <summary>
        /// Atualiza uma sala existente
        /// </summary>
        /// <param name="id">Id da sala que será atualizada</param>
        /// <param name="salaAtualizada">Objeto salaAtualizada que receberá os novos valores</param>
        void Atualizar(int id, Sala salaAtualizada);

        /// <summary>
        /// Buscar uma sala por seu id
        /// </summary>
        /// <param name="id">id da sala a ser buscada</param>
        /// <returns>uma sala buscada</returns>
        Sala BuscarPorId(int id);
    }
}
