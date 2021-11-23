using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Usuario
    {
        private string Nome;
        private string Status;
        private string CPF;
        private string Email;

        public Usuario()
        {

        }

        public Usuario(string nome, string cpf, string email, string status)
        {
            this.Nome = nome;
            this.Status = status;
            this.CPF = cpf;
            this.Email = email;
        }

        public string User_Nome { get => Nome; set => Nome = value; }
        public string User_Status { get => Status; set => Status = value; }
        public string User_CPF { get => CPF; set => CPF = value; }
        public string User_Email { get => Email; set => Email = value; }
    }
}
