using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeLogin
{
    static class CadastroUsuario
    {
        private static Usuario[] usuarios =
        {
            new Usuario(){Nome = "Jaqueline", Senha = "abc123" },
            new Usuario(){Nome = "Danilo", Senha = "123abc" },
            new Usuario(){Nome = "Joao Manoel", Senha = "abcd" }

        };
        private static Usuario _userLogado = null;

        public static Usuario UsuarioLogado
        {
            get { return _userLogado; }
           private set { _userLogado = value; }
        }

        public static bool login(string nome, string senha) 
        {
            foreach (Usuario usuario in usuarios) 
            {
                if( usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }
    }
}
