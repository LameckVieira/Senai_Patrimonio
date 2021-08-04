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
    public class SalasController : ControllerBase
    {
        /// <summary>
        /// Cria um objeto _salaRepository que irá receber todos os métodos definidos na interface
        /// </summary>
        private ISalaRepository _salaRepository { get; set; }

        /// <summary>
        /// Instancia este objeto para que haja a referência aos métodos no repositório
        /// </summary>
        public SalasController()
        {
            _salaRepository = new SalaRepository();
        }

        /// <summary>
        /// Cadastra um nova sala
        /// </summary>
        /// <param name="novaSala">Objeto sala a ser cadastrado</param>
        /// <returns>Um StatusCode 201 - Created</returns>
        [Authorize]
        [HttpPost]
        public IActionResult Post(Sala novaSala)
        {
            try
            {
                _salaRepository.Cadastrar(novaSala);

                return StatusCode(201);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        /// <summary>
        /// Lista todas salas existentes
        /// </summary>
        /// <returns>Uma lista das salas e um statusCode 200 - Ok</returns>
        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_salaRepository.Listar());
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        /// <summary>
        /// Busca uma sala pelo seu id
        /// </summary>
        /// <param name="id">Id da sala buscada</param>
        /// <returns>Uma sala buscada e um StatusCode 200 - Ok</returns>
        [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_salaRepository.BuscarPorId(id));


            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        /// <summary>
        /// Atualiza uma sala existente
        /// </summary>
        /// <param name="id">Id da sala a ser atualizada</param>
        /// <param name="salaAtualizada">Objeto salaAtualizada com as novas informações</param>
        /// <returns>Um StatusCode 204 - No Content</returns>
        [Authorize]
        [HttpPut("{id}")]
        public IActionResult Put(int id, Sala salaAtualizada)
        {
            try
            {
                _salaRepository.Atualizar(id, salaAtualizada);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        /// <summary>
        /// Deleta uma sala existente
        /// </summary>
        /// <param name="id">Id da sala a ser deletada</param>
        /// <returns>Um StatusCode 204 - No Content</returns>
        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _salaRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }
    }
}
