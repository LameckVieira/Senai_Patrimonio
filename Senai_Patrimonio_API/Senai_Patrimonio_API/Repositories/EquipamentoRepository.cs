using Senai_Patrimonio_API.Contexts;
using Senai_Patrimonio_API.Domains;
using Senai_Patrimonio_API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Patrimonio_API.Repositories
{
    public class EquipamentoRepository : IEquipamentoRepository
    {
        Senai_PatrimoniosContext ctx = new Senai_PatrimoniosContext();

        public void Atualizar(int id, Equipamento equipamentoAtualizado)
        {
            Equipamento equipamentoBuscado = ctx.Equipamentos.Find(id);

            if (equipamentoAtualizado != null)
            {
                equipamentoBuscado.Descricao = equipamentoAtualizado.Descricao;
            }

            if (equipamentoAtualizado != null)
            {
                equipamentoBuscado.Marca = equipamentoAtualizado.Marca;
            }

            if (equipamentoAtualizado != null)
            {
                equipamentoBuscado.Patrimonio = equipamentoAtualizado.Patrimonio;
            }

            if (equipamentoAtualizado != null)
            {
                equipamentoBuscado.Serie = equipamentoAtualizado.Serie;
            }

            if (equipamentoAtualizado != null)
            {
                equipamentoBuscado.Tipo = equipamentoAtualizado.Tipo;
            }

            if (equipamentoAtualizado != null)
            {
                equipamentoBuscado.Estado = equipamentoAtualizado.Estado;
            }


            ctx.Equipamentos.Update(equipamentoBuscado);

            ctx.SaveChanges();
        }

        public Equipamento BuscarPorId(int id)
        {
            return ctx.Equipamentos
                .Select(e => new Equipamento()
                {
                    IdEquipamento = e.IdEquipamento,
                    Descricao = e.Descricao,
                    Marca = e.Marca,
                    Tipo = e.Tipo,
                    Estado = e.Estado,
                    Patrimonio = e.Patrimonio,
                    Serie = e.Serie,

                    IdSalaNavigation = new Sala()
                    {
                        IdSala = e.IdSalaNavigation.IdSala,
                        Nome = e.IdSalaNavigation.Nome,
                        Andar = e.IdSalaNavigation.Andar,
                        Metragem = e.IdSalaNavigation.Metragem,
                    }
                })
                .FirstOrDefault(s => s.IdEquipamento == id);
        }

        public void Cadastrar(Equipamento novoEquipamento)
        {
            ctx.Equipamentos.Add(novoEquipamento);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Equipamentos.Remove(BuscarPorId(id));
            ctx.SaveChanges();
        }

        public List<Equipamento> Listar()
        {
            
        }
    }
}
