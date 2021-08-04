using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai_Patrimonio_API.Domains;
using Senai_Patrimonio_API.Interfaces;
using Senai_Patrimonio_API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Patrimonio_API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EquipamentosController : ControllerBase
    {
        /// <summary>
        /// Cria um objeto _EquipamentoRepository que irá receber todos os métodos definidos na interface
        /// </summary>
        private IEquipamentoRepository _equipamentoRepository { get; set; }

        /// <summary>
        /// Instancia este objeto para que haja a referência aos métodos no repositório
        /// </summary>
        public EquipamentosController()
        {
            _equipamentoRepository = new EquipamentoRepository();
        }

        /// <summary>
        /// Cadastra um novo equipamento
        /// </summary>
        /// <param name="novoEquipamento">Objeto clinica a ser cadastrado</param>
        /// <returns>Um StatusCode 201 - Created</returns>
        [Authorize]
        [HttpPost]
        public IActionResult Post(Equipamento novoEquipamento)
        {
            try
            {
                _equipamentoRepository.Cadastrar(novoEquipamento);

                return StatusCode(201);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        /// <summary>
        /// Lista todos equipamentos existentes
        /// </summary>
        /// <returns>Uma lista dos equipamentos e um statusCode 200 - Ok</returns>
        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_equipamentoRepository.Listar());
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        /// <summary>
        /// Busca um equipamento pelo seu id
        /// </summary>
        /// <param name="id">Id do equipamento buscada</param>
        /// <returns>Um equipamento buscado e um StatusCode 200 - Ok</returns>
        [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_equipamentoRepository.BuscarPorId(id));


            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        /// <summary>
        /// Atualiza um equipamento existente
        /// </summary>
        /// <param name="id">Id do equipamento a ser atualizada</param>
        /// <param name="equipamentoAtualizado">Objeto equipamentoAtualizado com as novas informações</param>
        /// <returns>Um StatusCode 204 - No Content</returns>
        [Authorize]
        [HttpPut("{id}")]
        public IActionResult Put(int id, Equipamento equipamentoAtualizado)
        {
            try
            {
                _equipamentoRepository.Atualizar(id, equipamentoAtualizado);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        /// <summary>
        /// Deleta um equipamento existente
        /// </summary>
        /// <param name="id">Id do equipamento a ser deletada</param>
        /// <returns>Um StatusCode 204 - No Content</returns>
        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _equipamentoRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }
    }
}

