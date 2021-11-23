using Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginUsuarioDAL
    {
        public string ValidarLogin(LoginUsuarioDAL loginDAL, out string LoginValidado)
        {
            try
            {
                SqlConnection connection = new StrConexao().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("AddUsuarios", connection);
                sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

                LoginValidado = "Bem-Vinda professora Vanessa ^-^";
                return "Login Validado";
            }
            catch(SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}
