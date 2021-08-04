using Senai_Patrimonio_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Patrimonio_API.Interfaces
{
    interface IUsuarioRepository
    {
        Usuario login(string email, string senha);
    }
}
