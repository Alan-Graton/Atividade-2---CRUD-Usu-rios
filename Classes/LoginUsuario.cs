using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class LoginUsuario
    {
        private string UsuarioLogin;
        private string SenhaLogin;

        public LoginUsuario()
        {

        }

        public LoginUsuario(string login, string senha)
        {
            this.UsuarioLogin = login;
            this.SenhaLogin = senha;
        }

        public string LoginNomeUsuario { get => UsuarioLogin; set => UsuarioLogin = value; }
        public string LoginSenhaUsuario { get => UsuarioLogin; set => UsuarioLogin = value; }
    }
}
