using Senai_Patrimonio_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Patrimonio_API.Interfaces
{
    interface ISalaRepository
    {
        List<Sala> Listar();

        void Cadastrar(Sala novaSala);

        void Deletar(int id);

        void Atualizar(int id, Sala salaAtualizada);

        Sala BuscarPorId(int id);
    }
}
