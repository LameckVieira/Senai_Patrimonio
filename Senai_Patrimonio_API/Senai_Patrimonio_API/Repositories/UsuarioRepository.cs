using Senai_Patrimonio_API.Contexts;
using Senai_Patrimonio_API.Domains;
using Senai_Patrimonio_API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Patrimonio_API.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        Senai_PatrimoniosContext ctx = new Senai_PatrimoniosContext();
        
        public Usuario BuscarPorId(int id)
        {
            // Retorna o primeiro usuário encontrado para o ID informado, sem exibir sua senha
            return ctx.Usuarios
                .Select(u => new Usuario()
                {
                    IdUsuario = u.IdUsuario,                   
                    Email = u.Email              
                })
                .FirstOrDefault(u => u.IdUsuario == id);
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            // Adiciona este novoUsuario
            ctx.Usuarios.Add(novoUsuario);

            // Salva as informações para serem gravadas no banco de dados
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            // Remove o tipo de usuário que foi buscado
            ctx.Usuarios.Remove(BuscarPorId(id));

            // Salva as alterações
            ctx.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            // Retorna uma lista com todas as informações dos tipos de usuários, exceto as senhas
            return ctx.Usuarios
                .Select(u => new Usuario()
                {
                    IdUsuario = u.IdUsuario,                    
                    Email = u.Email             
                })
                .ToList();
        }
        
        public Usuario Login(string email, string senha)
        {
            return ctx.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
    }
}
