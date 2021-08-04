using Senai_Patrimonio_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Patrimonio_API.Interfaces
{
    interface IEquipamentoRepository
    {
        List<Equipamento> Listar();

        void Cadastrar(Equipamento novaSala);

        void Deletar(int id);

        void Atualizar(int id, Equipamento salaAtualizada);

        Equipamento BuscarPorId(int id);
    }
}
