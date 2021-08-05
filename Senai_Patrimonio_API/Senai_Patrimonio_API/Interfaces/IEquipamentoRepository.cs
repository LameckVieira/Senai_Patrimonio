using Senai_Patrimonio_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Patrimonio_API.Interfaces
{
    interface IEquipamentoRepository
    {
        /// <summary>
        /// Lista os equipamentos cadastrados
        /// </summary>
        /// <returns>Uma lista de equipamentos</returns>
        List<Equipamento> Listar();

        /// <summary>
        /// Cadastra uma nova sala
        /// </summary>
        /// <param name="novaSala">Objeto equipamento</param>
        void Cadastrar(Equipamento novaSala);

        /// <summary>
        /// Deleta uma sala existente 
        /// </summary>
        /// <param name="id">id da sala a ser deletada</param>
        void Deletar(int id);

        /// <summary>
        /// Atualiza uma sala existente
        /// </summary>
        /// <param name="id">id da sala a ser atualizada</param>
        /// <param name="salaAtualizada">objeto salaAtualizada com os novos valores</param>
        void Atualizar(int id, Equipamento salaAtualizada);

        /// <summary>
        /// Busca um equipamento pelo seu id 
        /// </summary>
        /// <param name="id">id do equipamento a ser buscado</param>
        /// <returns>Um equipamento buscado</returns>
        Equipamento BuscarPorId(int id);
    }
}
