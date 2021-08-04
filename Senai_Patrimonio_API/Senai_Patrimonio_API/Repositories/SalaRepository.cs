using Senai_Patrimonio_API.Contexts;
using Senai_Patrimonio_API.Domains;
using Senai_Patrimonio_API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Patrimonio_API.Repositories
{
    public class SalaRepository : ISalaRepository
    {

        Senai_PatrimoniosContext ctx = new Senai_PatrimoniosContext();

        public void Atualizar(int id, Sala salaAtualizada)
        {
            Sala salaBuscada = ctx.Salas.Find(id);

            if (salaAtualizada != null)
            {
                salaBuscada.Nome = salaAtualizada.Nome;
            }

            if (salaAtualizada != null)
            {
                salaBuscada.Andar = salaAtualizada.Andar;
            }

            if (salaAtualizada != null)
            {
                salaBuscada.Metragem = salaAtualizada.Metragem;
            }

            ctx.Salas.Update(salaBuscada);

            ctx.SaveChanges();
        }

        public Sala BuscarPorId(int id)
        {
            return ctx.Salas
                .Select(s => new Sala()
                {
                    IdSala = s.IdSala,
                    Nome = s.Nome,
                    Andar = s.Andar,
                    Metragem = s.Metragem
                })
                .FirstOrDefault(s => s.IdSala == id);
        }

        public void Cadastrar(Sala novaSala)
        {
            ctx.Salas.Add(novaSala);            
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Salas.Remove(BuscarPorId(id));
            ctx.SaveChanges();
        }

        public List<Sala> Listar()
        {
            return ctx.Salas
                .Select(s => new Sala()
                {
                    IdSala = s.IdSala,
                    Nome = s.Nome,
                    Andar = s.Andar,
                    Metragem = s.Metragem                    
                })
                .ToList();
        }
    }
}
