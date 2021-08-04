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

        public Usuario login(string email, string senha)
        {         
            
            return ctx.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
           
        }
    }
}
