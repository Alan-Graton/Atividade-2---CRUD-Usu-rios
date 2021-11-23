using Classes;
using Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDAL
    {
        public string AddUsuarios(Usuario usuario)
        {
            string procedureExito = "";
            try
            {
                SqlConnection connection = new StrConexao().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("AddUsuarios", connection);
                sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

                sqlProcedure.Parameters.Add("Nome", SqlDbType.VarChar).Value = usuario.User_Nome;
                sqlProcedure.Parameters.Add("CPF", SqlDbType.VarChar).Value = usuario.User_CPF;
                sqlProcedure.Parameters.Add("Email", SqlDbType.VarChar).Value = usuario.User_Email;
                sqlProcedure.Parameters.Add("Status", SqlDbType.VarChar).Value = usuario.User_Status;

                sqlProcedure.ExecuteNonQuery();

                return procedureExito = "Usuário Cadastrado com Sucesso";
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        public Usuario ConsultarCadastroUsuarios(string nome, out string retorno)
        {
            retorno = "";
            try
            {
                SqlConnection connection = new StrConexao().GetConnection();
                SqlCommand command = new SqlCommand("ConsultarCadastroUsuarios", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("Nome", SqlDbType.VarChar).Value = nome;
                command.Parameters.Add("Retorno", SqlDbType.VarChar).Value = retorno;

                SqlDataReader reader = command.ExecuteReader();
                Usuario usuario = new Usuario();

                reader.Read();

                usuario.User_Nome = reader["Nome"].ToString();
                usuario.User_Email = reader["Email"].ToString();
                usuario.User_CPF = reader["CPF"].ToString();
                usuario.User_Status = reader["StatusUser"].ToString();

                retorno = "Usuário Encontrado";
                return usuario;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        public string AlterarCadastroUsuarios(Usuario usuario)
        {
            string procedureExito = "";
            try
            {
                SqlConnection connection = new StrConexao().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("AlterarCadastroUsuarios", connection);
                sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

                sqlProcedure.Parameters.Add("Nome", SqlDbType.VarChar).Value = usuario.User_Nome;
                sqlProcedure.Parameters.Add("CPF", SqlDbType.VarChar).Value = usuario.User_CPF;
                sqlProcedure.Parameters.Add("Email", SqlDbType.VarChar).Value = usuario.User_Email;
                sqlProcedure.Parameters.Add("Status", SqlDbType.VarChar).Value = usuario.User_Status;

                sqlProcedure.ExecuteNonQuery();

                return procedureExito = "Usuário alterado com sucesso";
            }
            catch(Exception err)
            {
                throw new Exception(err.Message);
            }
        }
        public List<Usuario> ListarUsuarios(out string retorno)
        {
            List<Usuario> usuariosListados = new List<Usuario>();
            SqlConnection connection = new StrConexao().GetConnection();
            try
            {
                string query = "SELECT * from TB_Usuario";
                SqlCommand comando = new SqlCommand(query, connection);
                SqlDataReader resultado = comando.ExecuteReader();
                while (resultado.Read())
                {
                    usuariosListados.Add(new Usuario()
                    {
                        User_Nome = resultado["Nome"].ToString(),
                        User_CPF = resultado["CPF"].ToString(),
                        User_Status = resultado["StatusUser"].ToString(),
                        User_Email = resultado["Email"].ToString()
                    });
                }

                retorno = "Hóspedes localizados com sucesso!";
                return usuariosListados;
            }
            catch (Exception err)
            {
                retorno = err.Message;
                return usuariosListados;
            }
            finally
            {
                connection.Close();
            }
        }

        public string DeleteUsuarios(string nome)
        {
            string procedureExito = "";
            Usuario usuarios = new Usuario();
            try
            {
                SqlConnection connection = new StrConexao().GetConnection();
                SqlCommand sqlProcedure = new SqlCommand("DeleteUsuarios", connection);
                sqlProcedure.CommandType = System.Data.CommandType.StoredProcedure;

                sqlProcedure.Parameters.Add("Nome", SqlDbType.VarChar).Value = nome;

                sqlProcedure.ExecuteNonQuery();

                return procedureExito = "Usuário Deletado com Sucesso";
            }
            catch(SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}
